
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

--Procedimiento mostrar todos los repuestos/Detalle de repuesto
ALTER procedure [dbo].[Mostrar_Repuestos]
as
select 
r.NoRepuesto as [No Repuesto],
Titulo,
Descripcion,
Marca,
Modelo,
d.CostoUnitario as [Costo Unitario],
d.Descuento,
d.Cantidad,
ROUND((d.CostoUnitario*d.Cantidad)-(d.Descuento*d.Cantidad),2) as [Costo Total]
from Repuestos r 
inner join [Detalle de Repuestos] d
on d.NoRepuesto = r.NoRepuesto

alter table [Detalle de Repuestos]
add Descuento float 


--Procedimiento mostrar todos los mantenimientos como reporte 
ALTER procedure [dbo].[Mostrar_Mantenimientos]
as
--Procedimiento mostrar todos los mantenimientos como reporte 
ALTER procedure [dbo].[Mostrar_Mantenimientos]
as
select 
m.NoMantenimiento as [No Mantenimiento],
c.p_nombre+' '+c.p_apellido as [Cliente],
v.Marca+', '+ v.Modelo +', '+ CONVERT(nvarchar(50),YEAR(v.Año),0) as [Vehiculo],
s.Descripcion as Servicio,
s.Precio as [Costo del servicio],
s.[Tipo de Mantenimiento],
r.Titulo+', '+r.Marca+', '+r.Modelo  as Repuesto,
r.Descripcion [Descripcion de repuesto],
dr.CostoUnitario as [Costo por repuesto],
dr.Descuento as [Descuento por repuesto],
dr.Cantidad as [Cantidad de repuestos],
m.Estado as [Estado del vehiculo],
FechaIngreso as [Fecha de ingreso],
FechaSalida as [Fecha de salida],
me.p_nombre+' '+me.p_apellido as [Mecanico a cargo],
ROUND(((dr.CostoUnitario*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) as [Costo Total]
from Mantenimientos m
inner join Vehiculos v 
on v.NoVehiculo = m.NoVehiculo
inner join Clientes c
on c.NoCliente = v.NoCliente 
inner join [Detalle de Mantenimiento] dm
on dm.NoMantenimiento = m.NoMantenimiento
inner join Servicios s 
on s.NoServicio = dm.NoServicio
inner join Repuestos r 
on r.NoRepuesto = dm.NoRepuesto
inner join Mecanicos me
on me.NoMecanico = dm.NoMecanico
inner join [Detalle de Repuestos] dr
on dr.NoRepuesto = r.NoRepuesto

/*select 
m.NoMantenimiento as [No Mantenimiento],
c.p_nombre+' '+c.p_apellido as [Nombre del Cliente],
v.Marca as [Marca del vehiculo],
v.Modelo as [Modelo del vehiculo],
v.Año as [Año del vehiculo],
s.Descripcion as Servicio,
s.Precio,
s.[Tipo de Mantenimiento],
r.Titulo as Repuesto,
r.Descripcion,
r.Marca as [Marca del Repuesto],
r.Modelo as [Modelo del Repuesto],
me.p_nombre+' '+me.p_apellido as [Mecanico a cargo],
dr.CostoUnitario as [Costo por Unidad],
dr.Descuento,
dr.Cantidad,
FechaIngreso as [Fecha de ingreso],
FechaSalida as [Fecha de salida],
m.Estado,
ROUND(((dr.CostoUnitario*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) as [Costo Total]
from Mantenimientos m
inner join Vehiculos v 
on v.NoVehiculo = m.NoVehiculo
inner join Clientes c
on c.NoCliente = v.NoCliente 
inner join [Detalle de Mantenimiento] dm
on dm.NoMantenimiento = m.NoMantenimiento
inner join Servicios s 
on s.NoServicio = dm.NoServicio
inner join Repuestos r 
on r.NoRepuesto = dm.NoRepuesto
inner join Mecanicos me
on me.NoMecanico = dm.NoMecanico
inner join [Detalle de Repuestos] dr
on dr.NoRepuesto = r.NoRepuesto*/


select * from [Detalle de Repuestos]
select * from Mantenimientos
select * from [Detalle de Mantenimiento]

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


	BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'