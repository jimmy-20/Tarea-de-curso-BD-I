USE SERVIPLUS

--CREAR LOGINS, ADD USER and ADD ROLE MEMBER
USE SERVIPLUS
GO
CREATE LOGIN AdminServiPlus WITH PASSWORD = 'serviplus2021'
EXEC sp_adduser AdminServiPlus, AdminServiPlus
EXEC sp_addrolemember db_owner, AdminServiPlus
SELECT @@SERVERNAME
---------------------------------------------------------------------
GO
--    procedimiento almacenado para insertar usuario
CREATE procedure Crear_Usuario
@FirstName varchar(80),
@LastName varchar(80),
@Telefono varchar(80),
@Especialidad varchar(80),
@username varchar(80),
@contraseña varchar(80),
@rol varchar(80)

as 
insert into Colaboradores(PrimerNombre,PrimerApellido,Especialidad,Telefono) values (@FirstName,@LastName,@Especialidad,@Telefono)

Declare @IdColaborador int
set @IdColaborador = (select MAX(IdColaborador) from Colaboradores)
insert into Usuarios(IdColaborador,Username,Contraseña,Rol,Estado) 
values 
(@IdColaborador,@username,ENCRYPTBYPASSPHRASE(@contraseña,@contraseña),@rol,'Habilitado')

select 'Usuario creado' as Resultado

--     Procedimiento para validar el acceso al sistema 
CREATE PROCEDURE Validar_Acceso
@usuario varchar(50),
@contraseña varchar(50)

as
if exists (Select username from Usuarios 
			where cast(DECRYPTBYPASSPHRASE(@contraseña,Contraseña) as  varchar(100)) = @contraseña
			and username = @usuario and Estado = 'Habilitado')
			
Select 'Acceso Exitoso' as Resultado,c.PrimerNombre+' '+c.PrimerApellido as Usuario, Rol,u.Username from Usuarios u
inner join Colaboradores c
on c.IdColaborador = u.IdColaborador
where cast(DECRYPTBYPASSPHRASE(@contraseña,Contraseña) as  varchar(100)) = @contraseña
and username = @usuario and Estado = 'Habilitado'

else

Select 'Acceso Denegado' as Resultado

--Procedimiento para la validacion de nuevo usuario al sistema 
CREATE PROCEDURE Validar_Creacion_Usuario
@usuario varchar(50)

as
if exists (Select username from Usuarios where username = @usuario)
Select 'Acceso Denegado' as Resultado
else
Select 'Acceso Exitoso' as Resultado

--Procedimiento para la busqueda usuarios/Colaboradores
CREATE procedure Buscar_Usuario
@dato varchar(100)
as
Select
c.PrimerNombre as Nombre,
c.PrimerApellido as Apellido,
Especialidad,
Telefono,
Rol,
Estado 
from Usuarios u
inner join Colaboradores c
on c.IdColaborador = u.IdColaborador
where c.PrimerNombre like @dato + '%' 
or c.PrimerApellido like @dato + '%' 
or Especialidad like @dato + '%' 
or Telefono like @dato + '%' 
or Rol like @dato + '%' 
or Estado  like @dato + '%' 

--------------------------------------------------------------------------------------
--Creando Usuario
EXECUTE Crear_Usuario 'Leonardo', 'Duarte', '7802-9877', 'Sistemas', 'Leoduartejr', 'elchamoleo','Admin'
EXECUTE Crear_Usuario 'Jimmy', 'Soza', '7802-9756', 'Sistemas', 'Jaso', 'Jaso', 'Admin'
EXECUTE Crear_Usuario 'Massiel', 'Fonseca', '78990677', 'Sistemas', 'Massiel', 'MassielFonseca', 'Admin'

--Usando Procedimiento almacenado Validar usuarios
Execute Validar_Acceso 'leoduartejr', 'elchamoleo'
Execute Validar_Acceso 'ElChamoLeo', 'Servi.Plus.202'

--------------------------------------------------------------------------------------------------------------------------------------------
--Restauracion de la base de datos 
BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'

Restore DataBase SERVIPLUS from Disk =  'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak' with replace