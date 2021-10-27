use SERVIPLUS
go


---Insertando datos en la tabla cliente
Insert into Clientes values ('Juan','Barrios','875463520','Praderas de Sandino V etapa','juanbarrios@gmail.com')
Insert into Clientes values ('Joel','Barrios','45653258','El Doral','joelbarrios@gmail.com')
Insert into Clientes values ('Alejandor','Alvarado','54786325','Barrio Cuba','a.alvarado@hotmail.com')
Insert into Clientes values ('Jeison','Suarez','53658596','Barrio tierra prometida','jSuarez@gmail.com')
Insert into Clientes values ('Penélope','Aragón','76342589','Urbanizacion Santa Rosa','a.penelope_@hotmail.com')
Insert into Clientes values ('Axel','Saenz','54687566','San Judas','axel_sz@gmail.com')
Insert into Clientes values ('Kevin','Ortiz','58965874','El Recreo','k_ortiz@gmail.com')

select * from Clientes

--- insertando datos en la tabla mecánico
Insert into Mecanicos values ('Juan','Ortiz','Automatizacion','45468156',5000,'Activo')
Insert into Mecanicos values ('Danilo','Corrales','Sistemas y equipos electricos','65987425',5500,'Activo')
Insert into Mecanicos values ('Allan','Zambrana','Sistemas termicos','45123568',7500,'Activo')
Insert into Mecanicos values ('Cristopher','Corrales','Sistemas electricos','95868745',8600,'Activo')
Insert into Mecanicos values ('Ebner','Ponce','Mantenimiento','65369885',56325,'Activo')

select * from Mecanicos

--- insertando datos en la tabla repuesto 
Insert into Repuestos values ('Bandas del motor','Original','Honda','SS101')
Insert into Repuestos values ('Cigüeñales','Remplazo','KIA','QWA22')
Insert into Repuestos values ('Pistones','Remplazo','Yamaha','AQW2')
Insert into Repuestos values ('Sistema de aire acondicionado','Original','BOSCH','SLA1')
Insert into Repuestos values ('Bateria','Remplazo','ACDelco','QWS2')
Insert into Repuestos values ('Caja de cambio','Original','VALEO','SOCA1')

select * from Repuestos
---insertando datos en la tabla vehículo
Insert into Vehiculos values (1,'BMW','X4','2018')
Insert into Vehiculos values (1,'BMW','SERIE 3','2010')

Insert into Vehiculos values (4,'Audi','X4','2012')
Insert into Vehiculos values (3,'Ford','F150','1999')
Insert into Vehiculos values (2,'Seat','F50','2018')
Insert into Vehiculos values (5,'Lexus','MA10','2014')
Insert into Vehiculos values (6,'Seat','F50','2018')
Insert into Vehiculos values (7,'Opel','R50','2020')

select * from Vehiculos

---insertando datos en la tabla Mantenimiento
Insert into Mantenimientos values (1,'2020-03-03','2020-03-03','Reparado')
Insert into Mantenimientos values (2,'2020-11-12','2020-11-13','Reparado')
Insert into Mantenimientos values (3,'2020-12-23','2020-12-23','Reparado')
Insert into Mantenimientos values (4,'2020-06-03','2020-06-03','Reparado')
Insert into Mantenimientos values (6,'2020-06-12','2020-06-15','Reparado')
Insert into Mantenimientos values (5,'2020-03-03','2020-03-03','Reparado')
Insert into Mantenimientos values (1,'2020-12-03','2020-12-03','Reparado')

select * from Mantenimientos

---insertando datos en la tabla servicio
Insert into Servicios values ('Cambio de aceite',140,'ORDINARIO')

Insert into Servicios values ('Cambio de Bandas del Motor',180,'EXTRAORDINARIO')
Insert into Servicios values ('Mantenimiento 10000 km',1800,'ORDINARIO')
Insert into Servicios values ('Mantenimiento 5000 km ',1500,'ORDINARIO')
Insert into Servicios values ('Revisión del Sistema Eléctrico',400,'EXTRAORDINARIO')
Insert into Servicios values ('Reparación de aire acondicionado',2000,'EXTRAORDINARIO')

select * from Servicios

---insertando datos es detallemantenimiento 
 Insert into [Detalle de Mantenimiento] values (1,1,1,1)
 Insert into [Detalle de Mantenimiento] values (2,2,1,2)
 Insert into [Detalle de Mantenimiento] values (3,1,2,3)
 Insert into [Detalle de Mantenimiento] values (4,3,2,4)
 Insert into [Detalle de Mantenimiento] values (3,2,2,2)

 select * from [Detalle de Mantenimiento]

 ---insertando datos en detallerepuesto
 Insert into [Detalle de Repuestos] values (1,150,2,0)
 Insert into [Detalle de Repuestos] values (2,134,2,0)
 Insert into [Detalle de Repuestos] values (3,150,2,0)
 Insert into [Detalle de Repuestos] values (4,300,1,0)
 Insert into [Detalle de Repuestos] values (5,134,1,0)
 Insert into [Detalle de Repuestos] values (6,300,1,0)

 select * from Repuestos
 select * from [Detalle de Repuestos]
 ----consultando a todas las tablas
 select * from [Detalle de Repuestos]
 select * from Clientes
 select * from [Detalle de Mantenimiento]
 select * from Servicios
 select * from Mantenimientos
 select * from Vehiculos
 select * from Mecanicos
 select * from Repuestos


 BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'

