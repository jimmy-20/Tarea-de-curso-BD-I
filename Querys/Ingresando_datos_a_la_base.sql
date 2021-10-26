use Servicios_de_mantenimiento
go


---Insertando datos en la tabla cliente
Insert into Cliente values ('Juan','Jos�','Barrios','Canales')

Insert into Cliente values ('Joel','Antonio','Barrios','Mend�za')
Insert into Cliente values ('Alejandor','','Alvarado','P�rez')
Insert into Cliente values ('Jeison','Jos�','Suarez','Jim�nez')
Insert into Cliente values ('Pen�lope','Daniela','Arag�n','Portocarrero')
Insert into Cliente values ('Axel','Karim','Saenz','Juarez')
Insert into Cliente values ('Kevin','Antonio','Ortiz','')

select * from Cliente

--- insertando datos en la tabla mec�nico
Insert into Mec�nico values ('Juan','Carlos','Villanueva','Ortiz')
Insert into Mec�nico values ('Danilo','Jos�','Corrales','L�pez')
Insert into Mec�nico values ('Allan','','Zambrana','')
Insert into Mec�nico values ('Cristopher','','Corrales','Martinez')
Insert into Mec�nico values ('Ebner','Camilo','Ponce','Ramierez')

select * from Mec�nico

--- insertando datos en la tabla repuesto 
Insert into Repuesto values ('Honda','SS101',150)
Insert into Repuesto values ('Yamaha','QWA22',134)
Insert into Repuesto values ('BOSCH','SLA1',300)
Insert into Repuesto values ('ACDelco','QWS2',134)
Insert into Repuesto values ('VALEO','SOCA1',300)

---insertando datos en la tabla veh�culo
Insert into Veh�culo values (1,'BMW','X4','2018')
Insert into Veh�culo values (1,'BMW','SERIE 3','2010')

Insert into Veh�culo values (4,'Audi','X4','2012')
Insert into Veh�culo values (3,'Ford','F150','1999')
Insert into Veh�culo values (2,'Seat','F50','2018')
Insert into Veh�culo values (5,'Lexus','MA10','2014')
Insert into Veh�culo values (6,'Seat','F50','2018')
Insert into Veh�culo values (7,'Opel','R50','2020')

select * from Veh�culo

---insertando datos en la tabla Mantenimiento
Insert into Mantenimiento values (1,'2020-03-03','2020-03-03','Reparado')
Insert into Mantenimiento values (2,'2020-11-12','2020-11-13','Reparado')
Insert into Mantenimiento values (3,'2020-12-23','2020-12-23','Reparado')
Insert into Mantenimiento values (4,'2020-06-03','2020-06-03','Reparado')
Insert into Mantenimiento values (6,'2020-06-12','2020-06-15','Reparado')
Insert into Mantenimiento values (5,'2020-03-03','2020-03-03','Reparado')
Insert into Mantenimiento values (1,'2020-12-03','2020-12-03','Reparado')

select * from Mantenimiento

---insertando datos en la tabla servicio
Insert into Servicio values ('Cambio de aceite',140,'ORDINARIO')

Insert into Servicio values ('Cambio de Bandas del Motor',180,'EXTRAORDINARIO')
Insert into Servicio values ('Mantenimiento 10000 km',1800,'ORDINARIO')
Insert into Servicio values ('Mantenimiento 5000 km ',1500,'ORDINARIO')
Insert into Servicio values ('Revisi�n del Sistema El�ctrico',400,'EXTRAORDINARIO')
Insert into Servicio values ('Reparaci�n de aire acondicionado',2000,'EXTRAORDINARIO')


---insertando datos es detallemantenimiento 
 Insert into Detalle_Mantenimiento values (1,1,1,2700)
 Insert into Detalle_Mantenimiento values (1,2,1,2900)
 Insert into Detalle_Mantenimiento values (1,1,2,2000)
 Insert into Detalle_Mantenimiento values (1,3,2,2000)
 Insert into Detalle_Mantenimiento values (3,2,2,1500)

 select * from Detalle_Mantenimiento

 ---insertando datos en detallerepuesto
 Insert into Detalle_Repuesto values (1,1,500,1)
 Insert into Detalle_Repuesto values (2,2,900,1)
 Insert into Detalle_Repuesto values (3,3,100,1)
 Insert into Detalle_Repuesto values (1,3,800,2)
 Insert into Detalle_Repuesto values (4,4,100,1)

 ----consultando a todas las tablas
 select * from Detalle_Repuesto
 select * from Cliente
 select * from Detalle_Mantenimiento
 select * from Servicio
 select * from Mantenimiento
 select * from Veh�culo
 select * from Mec�nico




