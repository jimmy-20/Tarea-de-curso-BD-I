CREATE PROCEDURE Recaudacion_Año_Mes @Año int, @Mes int
AS
IF exists (
           SELECT 
		   FechaSalida
		   FROM Mantenimiento
		   WHERE YEAR(FechaSalida) = @Año and MONTH(FechaSalida) = @Mes
           )
SELECT
v.Marca as Marca,
v.Modelo as Modelo,
m.FechaIngreso as Entrada,
m.FechaSalida as Salida,
s.Descripcion as Servicio,
dr.Cantidad as Cantida,
ROUND (dm.Precio  

	   ,2) as Total 
FROM Mantenimiento m
inner join Vehiculo v
on m.IdVehiculo = v.IdVehiculo
inner join Detalle_Mantenimiento dm
on dm.IdMantenimiento = m.IdMantenimiento
inner join Detalle_Repuesto dr
on dr.IdDetalleMantenimiento = dm.IdDetalleMantenimiento
inner join Servicio s
on s.IdServicio = dm.IdServicio

CREATE FUNCTION Total_Mantenimiento_Repuestos (@IdDetalleMantenimiento int)
RETURNS float
AS
BEGIN
DECLARE @Total_Repuestos float

SET @TOTAL_Repuestos = (
                        SELECT
						SUM (Cantidad * Precio)
						FROM Detalle_Repuesto
						WHERE IdDetalleMantenimiento = @IdDetalleMantenimiento
						
                       )

