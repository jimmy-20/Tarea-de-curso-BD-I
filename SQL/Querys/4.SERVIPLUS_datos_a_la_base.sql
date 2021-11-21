USE SERVIPLUS
GO

---Insertando datos en la tabla Cliente
Insert into Cliente values ('Juan','Alexander','Barrios','Chamorro','875463520','Praderas de Sandino V etapa','juanbarrios@gmail.com','Habilitado')
Insert into Cliente values ('Joel','Jose','Barrios','Ortiz','45653258','El Doral','joelbarrios@gmail.com','Habilitado')
Insert into Cliente values ('Luis','Alejandro','Alvarado','Gomez','54786325','Barrio Cuba','a.alvarado@hotmail.com','Habilitado')
Insert into Cliente values ('Jeison','Jose','Suarez','Jimenez','53658596','Barrio tierra prometida','jSuarez@gmail.com','Habilitado')
Insert into Cliente values ('Penélope','Rosa','Aragón','Ortiz','76342589','Urbanizacion Santa Rosa','a.penelope_@hotmail.com','Habilitado')
Insert into Cliente values ('Axel','Eduardo','Valle','Saenz','54687566','San Judas','axel_sz@gmail.com','Habilitado')
Insert into Cliente values ('Kevin','Jose','Urbina','Ortiz','58965874','El Recreo','k_ortiz@gmail.com','Habilitado')

GO

--- insertando datos en la tabla mecánico
Insert into Mecanico values ('Juan','Pablo','Aguirre','Ortiz','Automatizacion',5000,'San Andres I Etapa Casa H-2','45468156','juan@hotmail.com','Activo')
Insert into Mecanico values ('Danilo','Jose','Corrales','Jimenez','Sistemas y equipos electricos',5500,'Barrio Cuba','65987425','danicorral@hotmail.com','Activo')
Insert into Mecanico values ('Allan','Abner','Zambrana','Torrez','Sistemas termicos',7500,'Santa Eduviges Casa M-12','45123568','alanzam@gmail.com','Activo')
Insert into Mecanico values ('Cristopher','Rodney','Corrales','Lario','Sistemas electricos',8600,'Linda Vista 3 C. al lago','95868745','rodneylario@gmail.com','Activo')
Insert into Mecanico values ('Ebner','Alexis','Ponce','Ortiz','Mantenimiento',56325,'DGI principal 2 C al lago','65369885','ebalexis@hotmail.com','Activo')

GO

--- insertando datos en la tabla repuesto 
Insert into Repuesto values ('Bandas del motor','Honda','SS101',100,3)
Insert into Repuesto values ('Cigüeñales','KIA','QWA22',300,4)
Insert into Repuesto values ('Pistones','Yamaha','AQW2',25,21)
Insert into Repuesto values ('Sistema de aire acondicionado','BOSCH','SLA1',590,4)
Insert into Repuesto values ('Bateria','ACDelco','QWS2',850,9)
Insert into Repuesto values ('Caja de cambio','VALEO','SOCA1',50,5)

GO
---insertando datos en la tabla vehículo
Insert into Vehiculo values (1,'BMW','X4','2018')
Insert into Vehiculo values (1,'BMW','SERIE 3','2010')
Insert into Vehiculo values (4,'Audi','X4','2012')
Insert into Vehiculo values (3,'Ford','F150','1999')
Insert into Vehiculo values (2,'Seat','F50','2018')
Insert into Vehiculo values (5,'Lexus','MA10','2014')
Insert into Vehiculo values (6,'Seat','F50','2018')
Insert into Vehiculo values (7,'Opel','R50','2020')

GO

---insertando datos en la tabla servicio
Insert into Servicio values ('Cambio de aceite',140,'ORDINARIO','Habilitado')
Insert into Servicio values ('Cambio de Bandas del Motor',180,'EXTRAORDINARIO','Habilitado')
Insert into Servicio values ('Mantenimiento 10000 km',1800,'ORDINARIO','Habilitado')
Insert into Servicio values ('Mantenimiento 5000 km ',1500,'ORDINARIO','Habilitado')
Insert into Servicio values ('Revisión del Sistema Eléctrico',400,'EXTRAORDINARIO','Habilitado')
Insert into Servicio values ('Reparación de aire acondicionado',2000,'EXTRAORDINARIO','Habilitado')

GO

---insertando datos en la tabla Mantenimiento
Insert into Mantenimiento values (1,'2021-11-18','2021-11-24','En espera')
Insert into Mantenimiento values (2,'2021-11-18','2021-11-25','En espera')
Insert into Mantenimiento values (3,'2021-11-18','2021-11-26','En espera')
Insert into Mantenimiento values (4,'2021-11-18','2021-11-27','En espera')
Insert into Mantenimiento values (6,'2021-11-18','2021-11-28','En espera')
Insert into Mantenimiento values (7,'2021-11-18','2021-11-30','En espera')
Insert into Mantenimiento values (8,'2021-11-16','2021-12-03','En espera')

--Falta la inserccion de datos en los detalles de Mantenimiento



 --BACKUP DATABASE	SERVIPLUS TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\SERVIPLUS.bak'

