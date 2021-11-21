USE SERVIPLUS
--Tabla de colaboradores a los cuales les pertenece un usuario
CREATE TABLE Colaboradores(
IdColaborador int primary key identity(1,1) not null,
FirstName varchar (30) not null,
LastName varchar(30) not null,
Telefono varchar (30) not null,
Especialidad varchar (50) not null
)
GO
--Tabla de users que van a entrar al servidor/ DB
Create table Usuarios(
IdUsuario int identity(1,1) primary key not null,
IdColaborador int foreign key references Colaboradores(IdColaborador) not null,
Username varchar(80) not null,
Contraseña varchar(80) not null,
Rol varchar(80) not null,
Estado varchar(80) not null
) 
GO
---------------------------------------------------------------------
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
insert into Colaboradores(FirstName,LastName,Especialidad,Telefono) values (@FirstName,@LastName,@Especialidad,@Telefono)

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
			
Select 'Acceso Exitoso' as Resultado,c.FirstName+' '+c.LastName as Usuario, Rol,u.Username from Usuarios u
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
c.FirstName as Nombre,
c.LastName as Apellido,
Especialidad,
Telefono,
Rol,
Estado 
from Usuarios u
inner join Colaboradores c
on c.IdColaborador = u.IdColaborador
where c.FirstName like @dato + '%' 
or c.LastName like @dato + '%' 
or Especialidad like @dato + '%' 
or Telefono like @dato + '%' 
or Rol like @dato + '%' 
or Estado  like @dato + '%' 

--------------------------------------------------------------------------------------
--Creando Usuario
EXECUTE Crear_Usuario 'Leonardo', 'Duarte', '7802-9877', 'Sistemas', 'ElChamoLeo', 'Servi.Plus.2021','Admin'
EXECUTE Crear_Usuario 'Jimmy', 'Soza', '7802-9756', 'Sistemas', 'Jaso', 'Jaso', 'Admin'
EXECUTE Crear_Usuario 'Massiel', 'Fonseca', '78990677', 'Sistemas', 'MassielFonseca', 'MassielFonseca', 'Admin'

--Usando Procedimiento almacenado Validar usuarios
Execute Validar_Acceso 'ElChamoLeo', 'Servi.Plus.2021'
Execute Validar_Acceso 'ElChamoLeo', 'Servi.Plus.202'

--------------------------------------------------------------------------------------------------------------------------------------------
--Restauracion de la base de datos 
BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'

Restore DataBase SERVIPLUS from Disk =  'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak' with replace