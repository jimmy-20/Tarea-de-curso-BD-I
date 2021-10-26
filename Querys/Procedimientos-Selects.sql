Select * from Usuarios
Select * from Colaboradores
select * from Clientes

Update Usuarios set IdColaborador= 2 where IdUsuario=4
Update Colaboradores set Especialidad = 'Analista' where IdColaborador=2
Alter table Mecanicos 
add Especialidad nvarchar(50) not null
Alter table Mecanicos 
add Telefono nvarchar(50) not null
Alter table Mecanicos 
add Salario float not null
Alter table Mecanicos 
add Estado nvarchar(30) not null

--Procedimientos

--Procedimiento mostrar usuario/colabs
Create procedure [dbo].[Mostrar_Usuarios]

as
Select c.FirstName as Nombre, 
c.LastName as Apellido, 
Especialidad,
Telefono,
Rol,
Estado 
from Usuarios u 
inner join Colaboradores c 
on c.IdColaborador = u.IdColaborador

--Procedimiento mostrar todos los clientes
Create procedure [dbo].[Mostrar_Clientes]
as
Select 
NoCliente as [No Cliente],
p_nombre as Nombre,
p_apellido as Apellido,
telefono,
Direccion from Clientes

--Procedimiento mostrar todos los mecanicos
Create procedure [dbo].[Mostrar_Mecanicos]
as
Select 
NoMecanico as [No Mecanico],
p_nombre as Nombre,
p_apellido as Apellido,
Especialidad,
telefono,
Salario,
Estado
from Mecanicos

--Procedimiento mostrar todos los mecanicos
Alter procedure [dbo].[Mostrar_Servicios]
as
Select 
NoServicio as [No Servicio],
Descripcion,
Precio,
[Tipo de Mantenimiento]
from Servicios

--Procedimiento mostrar todos los vehiculos con sus clientes
ALTER procedure [dbo].[Mostrar_Vehiculos]
as
select 
NoVehiculo as [No Vehiculo],
Marca,
Modelo,
Año, 
c.p_nombre+' '+c.p_apellido as [Cliente/Dueño] 
from Vehiculos v 
inner join Clientes c 
on c.NoCliente = v.NoCliente

--Procedimiento para la validacion de nuevo usuario al sistema 

Alter procedure Validar_Creacion_Usuario
@usuario varchar(50)

as
if exists (Select username from Usuarios where username = @usuario)
			Select 'Acceso Denegado' as Resultado
			else
			Select 'Acceso Exitoso' as Resultado


--Procedimiento para la busqueda usuarios/Colaboradores

ALTER procedure [dbo].[Buscar_Usuario]
	 @dato varchar(20)
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