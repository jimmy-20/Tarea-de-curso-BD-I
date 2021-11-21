--Procedimiento mostrar usuario/colabo
USE SERVIPLUS
GO
CREATE PROCEDURE Mostrar_Usuarios
as
Select
u.IdUsuario as IdUsuario,
c.FirstName as Nombre, 
c.LastName as Apellido, 
Especialidad as Especialidad,
c.Telefono as Telefono,
u.Rol as Rol,
u.Estado as Estado
from Usuarios u 
inner join Colaboradores c 
on c.IdColaborador = u.IdColaborador

--Procedimiento mostrar todos los clientes
CREATE procedure Mostrar_Clientes
as
Select 
IdCliente as [No Cliente],
PrimerNombre + ' ' + SegundoNombre as Nombres,
PrimerApellido + ' ' + SegundoApellido as Apellidos,
Telefono as Telefono,
Direccion as Direccion,
Correo as Correo,
Estado as Estado
from Cliente

--Procedimiento mostrar todos los mecanicos
Create procedure Mostrar_Mecanicos
as
Select 
IdMecanico as IdMecanico,
PrimerNombre + ' ' + SegundoNombre as Nombre,
PrimerApellido + ' ' + SegundoApellido as Apellido,
Especialidad as Especialidad,
Telefono as Telefono,
Salario as Salario,
Direccion as Direccion,
Correo as Correo,
Estado as Estado
from Mecanico

--Procedimiento mostrar todos los mecanicos
CREATE PROCEDURE Mostrar_Servicios
as
Select 
IdServicio as IdServicio,
Descripcion as Descripcion,
Precio as Precio,
TipoMantenimiento as TipoMantenimiento,
Estado as Estado
from Servicio

--Procedimiento mostrar todos los vehiculos con sus clientes
CREATE PROCEDURE Mostrar_Vehiculos
as
select 
v.IdVehiculo as IdVehiculo,
c.IdCliente as IdCliente,
c.PrimerNombre + ' ' + c.PrimerApellido as Cliente,
v.Marca,
v.Modelo,
v.Año
from Vehiculo v 
inner join Cliente c 
on c.IdCliente = v.IdCliente

--Procedimiento mostrar todos los repuestos/Detalle de repuesto
CREATE PROCEDURE Mostrar_Repuestos
as
select 
*
from 
Repuesto 

--NOTA: Hay que hablar sobre esto en un momento, no hay que pedir todo...
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


--Procedimiento para la busqueda Clientes

CREATE PROCEDURE Buscar_Cliente
@dato varchar(100)
as
Select
c.PrimerNombre + ' ' + c.SegundoNombre as Nombres,
c.PrimerApellido + ' ' + c.SegundoApellido as Apellidos,
c.Telefono as Telefono,
c.Direccion as Direcion,
c.Correo as Correo,
Estado as Estado
from Cliente c
where c.PrimerNombre + ' ' + c.SegundoNombre like @dato + '%' 
	or c.PrimerApellido + ' ' + c.SegundoApellido like @dato + '%' 
	or c.Telefono like @dato + '%'  
	or  c.Direccion  like @dato + '%' 
	or c.Correo like @dato + '%'

--Procedimiento para la busqueda Vehiculos

CREATE PROCEDURE Buscar_Vehiculo
@dato varchar(100)
as

select 
v.IdVehiculo as IdVehiculo,
c.IdCliente as IdCliente,
c.PrimerNombre + ' ' + c.PrimerApellido as Cliente,
v.Marca,
v.Modelo,
v.Año
from Vehiculo v 
inner join Cliente c 
on c.IdCliente = v.IdCliente
where v.Marca like @dato + '%' 
	or v.Modelo like @dato + '%' 
	or v.Año like @dato + '%' 
	or  (c.PrimerNombre + ' ' + c.SegundoApellido)  like @dato + '%' 

--Procedimiento para la busqueda Mecanicos
CREATE PROCEDURE Buscar_Mecanico
@dato varchar(100)
as
Select 
IdMecanico as IdMecanico,
PrimerNombre + ' ' + SegundoNombre as Nombre,
PrimerApellido + ' ' + SegundoApellido as Apellido,
Especialidad as Especialidad,
Telefono as Telefono,
Salario as Salario,
Direccion as Direccion,
Correo as Correo,
Estado as Estado
from Mecanico
where (PrimerNombre + ' ' + SegundoNombre) like @dato + '%' 
	or (PrimerApellido + ' ' + SegundoApellido) like @dato + '%' 
	or Especialidad like @dato + '%' 
	or Telefono like @dato + '%'
	or Direccion like @dato + '%'
	or Correo like @dato + '%'
	or Estado like @dato + '%' 

--   Procedimiento almacenado de Buscar Repuesto
CREATE PROCEDURE Buscar_Repuesto @dato varchar(100)
AS
SELECT
*
FROM
Repuesto
WHERE Descripcion like @dato + '%'
      or Marca like @dato + '%'
	  or Modelo like @dato + '%'

--Procedimiento para la busqueda Servicios

CREATE PROCEDURE Buscar_Servicio
	 @dato varchar(100)
as

Select 
IdServicio as IdServicio,
Descripcion as Descripcion,
Precio as Precio,
TipoMantenimiento as TipoMantenimiento,
Estado as Estado
from Servicio
where Descripcion like @dato + '%' 
	  or Precio like @dato + '%' 
	  or TipoMantenimiento like @dato + '%'

--VER P.A
--Procedimiento para la busqueda Mantenimientos
	ALTER procedure [dbo].[Buscar_Mantenimiento]
	 @dato varchar(100)
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
	where (c.p_nombre+' '+c.p_apellido) like '%'+@dato + '%' 
	or (v.Marca+', '+ v.Modelo +', '+ CONVERT(nvarchar(50),YEAR(v.Año),0)) like @dato + '%' 
	or s.Descripcion like @dato + '%'
	or s.Precio like @dato + '%' 
	or s.[Tipo de Mantenimiento] like @dato + '%' 
	or (r.Titulo+', '+r.Marca+', '+r.Modelo ) like @dato + '%' 
	or r.Descripcion like @dato + '%' 
	or dr.CostoUnitario like @dato + '%' 
	or dr.Descuento  like @dato + '%' 
	or dr.Cantidad like @dato + '%' 
	or m.Estado like @dato + '%' 
	or FechaIngreso  like @dato + '%' 
	or FechaSalida like @dato + '%' 
	or (me.p_nombre+' '+me.p_apellido) like @dato + '%' 
	or ROUND(((dr.CostoUnitario*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) like @dato + '%' 

	BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'