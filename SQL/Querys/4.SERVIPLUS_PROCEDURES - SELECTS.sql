--Procedimiento mostrar usuario/colabo
USE SERVIPLUS
GO
CREATE PROCEDURE Mostrar_Usuarios
as
Select
u.IdUsuario as IdUsuario,
c.PrimerNombre + ' '+ c.SegundoNombre as Nombres, 
c.PrimerApellido + ' '+  c.SegundoApellido as Apellidos, 
Especialidad as Especialidad,
c.Telefono as Telefono,
u.Rol as Rol,
u.Estado as Estado
from Usuarios u 
inner join Colaboradores c 
on c.IdColaborador = u.IdColaborador

--Procedimiento mostrar todos los clientes
CREATE PROCEDURE Mostrar_Clientes
as
Select 
IdCliente as [No Cliente],
PrimerNombre + ' ' + SegundoNombre as Nombres,
PrimerApellido + ' ' + SegundoApellido as Apellidos,
Telefono as Telefono,
Direccion as Direccion,
Correo as Correo,
Estado as Estado
from Clientes

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
from Mecanicos

--Procedimiento mostrar todos los mecanicos
CREATE PROCEDURE Mostrar_Servicios
as
Select 
IdServicio as IdServicio,
Descripcion as Descripcion,
Precio as Precio,
TipoMantenimiento as [Tipon de Mantenimiento],
Estado as Estado
from Servicios

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
from Vehiculos v 
inner join Clientes c 
on c.IdCliente = v.IdCliente

--Procedimiento mostrar todos los repuestos/Detalle de repuesto
CREATE PROCEDURE Mostrar_Repuestos
as
select 
*
from 
Repuestos r

--NOTA: Hay que hablar sobre esto en un momento, no hay que pedir todo...
--Procedimiento mostrar todos los mantenimientos como reporte 
CREATE procedure [dbo].[Mostrar_Mantenimientos]
as
select 
m.IdMantenimiento as [No Mantenimiento],
c.PrimerNombre+' '+c.PrimerApellido as [Cliente],
v.Marca+', '+ v.Modelo +', '+ CONVERT(nvarchar(50),YEAR(v.Año),0) as [Vehiculo],
s.Descripcion as Servicio,
s.Precio as [Precio del servicio],
s.TipoMantenimiento as [Tipo de Mantenimiento],
r.Marca+', '+r.Modelo  as Repuesto,
r.Descripcion [Repuesto],
dr.Precio as [Precio del Repuesto],
dr.Descuento as [Descuento por repuesto],
dr.Cantidad as [Cantidad de repuestos],
m.Estado as [Estado del vehiculo],
FechaIngreso as [Fecha de ingreso],
FechaSalida as [Fecha de salida],
me.PrimerNombre+' '+me.PrimerApellido as [Mecanico a cargo],
ROUND(((dr.Precio*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) as [Costo Total]
from Mantenimientos m
inner join Vehiculos v 
on v.IdVehiculo = m.IdVehiculo
inner join Clientes c
on c.IdCliente = v.IdCliente 
inner join Detalle_Mantenimientos dm
on dm.IdMantenimiento = m.IdMantenimiento
inner join Servicios s 
on s.IdServicio = dm.IdServicio
inner join Mecanicos me
on me.IdMecanico = dm.IdMecanico
inner join Detalle_Repuestos dr
on dr.IdDetalleMantenimiento = dm.IdDetalleMantenimiento
inner join Repuestos r 
on r.IdRepuesto = dr.IdRepuesto

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
from Clientes c
where c.PrimerNombre + ' ' + c.SegundoNombre like '%'+@dato + '%' 
	or c.PrimerApellido + ' ' + c.SegundoApellido like '%'+@dato + '%' 
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
from Vehiculos v 
inner join Clientes c 
on c.IdCliente = v.IdCliente
where v.Marca like @dato + '%' 
	or v.Modelo like @dato + '%' 
	or v.Año like @dato + '%' 
	or  (c.PrimerNombre + ' ' + c.SegundoApellido)  like '%'+@dato + '%' 

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
from Mecanicos
where (PrimerNombre + ' ' + SegundoNombre) like '%'+@dato + '%' 
	or (PrimerApellido + ' ' + SegundoApellido) like '%'+@dato + '%'
	or Especialidad like @dato + '%' 
	or Telefono like @dato + '%'
	or Direccion like '%'+@dato + '%'
	or Correo like @dato + '%'
	or Estado like @dato + '%' 

--   Procedimiento almacenado de Buscar Repuesto
CREATE PROCEDURE Buscar_Repuesto @dato varchar(100)
AS
SELECT
*
FROM
Repuestos
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
from Servicios
where Descripcion like @dato + '%' 
	  or Precio like @dato + '%' 
	  or TipoMantenimiento like @dato + '%'

--VER P.A
--Procedimiento para la busqueda Mantenimientos
	CREATE procedure [dbo].[Buscar_Mantenimiento]
	 @dato varchar(100)
as

select 
m.IdMantenimiento as [No Mantenimiento],
c.PrimerNombre+' '+c.PrimerApellido as [Cliente],
v.Marca+', '+ v.Modelo +', '+ CONVERT(nvarchar(50),YEAR(v.Año),0) as [Vehiculo],
s.Descripcion as Servicio,
s.Precio as [Costo del servicio],
s.TipoMantenimiento as [Tipo de Mantenimiento],
r.Marca+', '+r.Modelo  as Repuesto,
r.Descripcion [Descripcion de repuesto],
dr.Precio as [Costo por repuesto],
dr.Descuento as [Descuento por repuesto],
dr.Cantidad as [Cantidad de repuestos],
m.Estado as [Estado del vehiculo],
FechaIngreso as [Fecha de ingreso],
FechaSalida as [Fecha de salida],
me.PrimerNombre+' '+me.PrimerApellido as [Mecanico a cargo],
ROUND(((dr.Precio*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) as [Costo Total]
from Mantenimientos m
inner join Vehiculos v 
on v.IdVehiculo = m.IdVehiculo
inner join Clientes c
on c.IdCliente = v.IdCliente 
inner join Detalle_Mantenimientos dm
on dm.IdMantenimiento = m.IdMantenimiento
inner join Servicios s 
on s.IdServicio = dm.IdServicio
inner join Mecanicos me
on me.IdMecanico = dm.IdMecanico
inner join Detalle_Repuestos dr
on dr.IdDetalleMantenimiento = dm.IdDetalleMantenimiento
inner join Repuestos r 
on r.IdRepuesto = dr.IdRepuesto
	where (c.PrimerNombre+' '+c.PrimerApellido) like '%'+@dato + '%' 
	or (v.Marca+', '+ v.Modelo +', '+ CONVERT(nvarchar(50),YEAR(v.Año),0)) like @dato + '%' 
	or s.Descripcion like @dato + '%'
	or s.Precio like @dato + '%' 
	or s.TipoMantenimiento like @dato + '%' 
	or (r.Marca+', '+r.Modelo ) like @dato + '%' 
	or r.Descripcion like @dato + '%' 
	or dr.Precio like @dato + '%' 
	or dr.Descuento  like @dato + '%' 
	or dr.Cantidad like @dato + '%' 
	or m.Estado like @dato + '%' 
	or FechaIngreso  like @dato + '%' 
	or FechaSalida like @dato + '%' 
	or (me.PrimerNombre+' '+me.PrimerApellido) like @dato + '%' 
	or ROUND(((dr.Precio*dr.Cantidad)-(dr.Cantidad*dr.Descuento))+(s.Precio),2) like @dato + '%' 

--Procedimiento almacenado para cambiar el estado en las tablas

USE SERVIPLUS
GO

CREATE PROCEDURE Cambiar_Estado_Cliente @IdCliente int
AS

if exists(SELECT
    *
    FROM
    Clientes
    where IdCliente = @IdCliente and Estado = 'Habilitado'
    )
UPDATE Clientes SET
Estado = 'Deshabilitado'
WHERE IdCliente = @IdCliente
ELSE
UPDATE Clientes SET
Estado = 'Habilitado'
WHERE IdCliente = @IdCliente

CREATE PROCEDURE Cambiar_Estado_Servicio @IdServicio int
AS

IF exists (
           SELECT
		   *
		   FROM
		   Servicios 
		   WHERE IdServicio = @IdServicio and Estado = 'Habilitado'
           )
UPDATE Servicios SET
Estado = 'Deshabilitado'
WHERE IdServicio = @IdServicio
ELSE
UPDATE Servicios SET
Estado = 'Habilitado'
WHERE IdServicio = @IdServicio

CREATE PROCEDURE Cambiar_Estado_Mecanico @IdMecanico int
AS
IF exists (
           SELECT
		   *
		   FROM Mecanicos
		   WHERE IdMecanico = @IdMecanico and Estado = 'Habilitado'
           )
UPDATE Mecanicos SET
Estado = 'Deshabilitado'
WHERE IdMecanico = @IdMecanico
ELSE
UPDATE Mecanicos SET
Estado = 'Habilitado'
WHERE IdMecanico = @IdMecanico

CREATE PROCEDURE Cambiar_Estado_Usuario @IdUsuario int
AS
IF exists (
           SELECT
		   *
		   FROM Usuarios
		   WHERE IdUsuario = @IdUsuario and Estado = 'Habilitado'
           )
UPDATE Usuarios SET
Estado = 'Deshabilitado'
WHERE IdUsuario = @IdUsuario
ELSE
UPDATE Usuarios SET
Estado = 'Habilitado'
WHERE IdUsuario = @IdUsuario

	BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'