select @@SERVERNAME
--Login que me sirve como conexion al servidor
Use SERVIPLUS
go
Create login AdminServiPlus with password = 'Servi.Plus.2021'
go
Use SERVIPLUS
go 
sp_adduser AdminServiPlus, AdminServiPlus

--Dando permisos a AdminServiPlus
	--Procedimientos Almacenados: 
Grant execute on Validar_Acceso to AdminServiPlus
Grant execute on Crear_Usuario to AdminServiPlus
Grant execute on Buscar_Usuario to AdminServiPlus
Grant execute on Validar_Creacion_Usuario to AdminServiPlus
Grant execute on Mostrar_Usuarios to AdminServiPlus
Grant execute on Mostrar_Clientes to AdminServiPlus
Grant execute on Mostrar_Vehiculos to AdminServiPlus
Grant execute on Mostrar_Mecanicos to AdminServiPlus
Grant execute on Mostrar_Servicios to AdminServiPlus
Grant execute on Mostrar_Repuestos to AdminServiPlus
Grant execute on Mostrar_Mantenimientos to AdminServiPlus
Grant execute on Buscar_Vehiculo to AdminServiPlus
Grant execute on Buscar_Cliente to AdminServiPlus
Grant execute on Buscar_Mecanico to AdminServiPlus
Grant execute on Buscar_Servicio to AdminServiPlus
Grant execute on Buscar_Mantenimiento to AdminServiPlus

	--Tablas: 
Grant select on Usuarios to AdminServiPlus
Grant select on Clientes to AdminServiPlus
Grant select on Mantenimientos to AdminServiPlus
Grant select on Mecanicos to AdminServiPlus
Grant select on Servicios to AdminServiPlus
Grant select on Vehiculos to AdminServiPlus
Grant select on Repuestos to AdminServiPlus
Grant select on Colaboradores to AdminServiPlus
------------------------------------------------------
--Tabla de colaboradores a los cuales les pertenece un usuario
CREATE TABLE Colaboradores(
IdColaborador int primary key identity(1,1) not null,
FirstName varchar (30) not null,
LastName varchar(30) not null,
Telefono varchar (30) not null,
Especialidad varchar (50) not null
)

--Tabla de users que van a entrar al servidor/ DB
Create table Usuarios(
IdUsuario int identity(1,1) primary key not null,
IdColaborador int foreign key references Colaboradores(IdColaborador) not null,
Username varchar(80) not null,
Contraseña varchar(80) not null,
Rol varchar(80) not null,
Estado varchar(80) not null
) 

---------------------------------------------------------------------
--procedimiento almacenado para insertar usuario
Alter procedure Crear_Usuario
@FirstName varchar(80),
@LastName varchar(80),
@Telefono varchar(80),
@Especialidad varchar(80),
@username varchar(80),
@contraseña varchar(80),
@rol varchar(80)

as 
insert into Colaboradores(FirstName,LastName,Especialidad,Telefono) values (@FirstName,@LastName,@Especialidad,@Telefono)

Declare @IdColaborador varchar(10)
set @IdColaborador = (select MAx(IdColaborador)from Colaboradores)

insert into Usuarios(IdColaborador,Username,Contraseña,Rol,Estado) values (@IdColaborador,@username,ENCRYPTBYPASSPHRASE(@contraseña,@contraseña),@rol,'Habilitado')

select 'Se ha finalizado el procedimientos exitosamente' as Resultado

--Procedimiento para validar el acceso al sistema 
Alter procedure Validar_Acceso
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

--------------------------------------------------------------------------------------
--Insertar un colaborador
insert into Colaboradores(FirstName,LastName,Especialidad,Telefono) values ('Leonardo','Duarte','Gerente','57646294')
insert into Colaboradores(FirstName,LastName,Especialidad,Telefono) values ('Jimmy','Soza','Recursos Humanos','75369885')
select * from Colaboradores

--Insertando un usuaior sin procedimiento
insert into Usuarios(IdColaborador,Username,Contraseña,Rol,Estado)
values (1,'ElChamoLeo','Servi.Plus.2021','Admin','Habilitado')

--Usando Procedimiento almacenado Crea usuarios
Execute dbo.Crear_Usuario 1,'ElChamoLeo','Servi.Plus.2021','Admin'
Execute dbo.Crear_Usuario 1,'Jimmy','jimmySoza','Admin'

select * from Usuarios
--Usando Procedimiento almacenaodo Validar usuarios
Execute Validar_Acceso 'ElChamoLeo', 'Servi.Plus.2021'
Execute Validar_Acceso 'ElChamoLeo', 'Servi.Plus.202'

select * from Colaboradores
select * from Usuarios

--Probando el procedimiento almacenado Crear usuario modificado
execute Crear_Usuario 'Leonardo','Duarte','57646294','Ejecutivo','leoduartejr','pass.word.2020','Admin'
execute Crear_Usuario 'Jimmy','Soza','75856936','Analista','Jimmy','jimmysoza','Admin'
execute Crear_Usuario 'Massiel','Fonseca','58646358','Finanzas','Massiel','massielfonseca','Admin'

--------------------------------------------------------------------------------------------------------------------------------------------
--Restauracion de la base de datos 
BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'

Restore DataBase SERVIPLUS from Disk =  'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak' with replace