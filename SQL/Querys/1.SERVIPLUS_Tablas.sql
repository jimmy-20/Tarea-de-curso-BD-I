--Ejecutar todo el Query y luego trabajar con el Login AdminServiPlus
CREATE LOGIN AdminServiPlus WITH PASSWORD = 'ServiPlus2021'
CREATE DATABASE SERVIPLUS
GO
USE SERVIPLUS
GO
--Creacion de catalogos
CREATE TABLE Cliente(
IdCliente int primary key identity(1,1),
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50),
Telefono varchar(20),
Direccion varchar(50),
Correo varchar(50),
Estado varchar(20)
)
GO

CREATE TABLE Vehiculo(
IdVehiculo int primary key identity(1,1),
IdCliente int foreign key references Cliente(IdCliente),
Marca varchar(50),
Modelo varchar(50),
Año int
)
GO

CREATE TABLE Servicio(
IdServicio int primary key identity(1,1),
Descripcion varchar(50),
Precio decimal,
TipoMantenimiento varchar(50),
Estado varchar(50)
)
GO

CREATE TABLE Repuesto(
IdRepuesto int primary key identity(1,1),
Descripcion varchar(50),
Marca varchar(50),
Modelo varchar(50),
Precio decimal,
Cantidad int
)
GO

CREATE TABLE Mecanico(
IdMecanico int primary key identity(1,1),
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50),
Especialidad varchar(50),
Salario decimal,
Direccion varchar(50),
Telefono varchar (50),
Correo varchar(50),
Estado varchar(20)
)
GO

--Tablas de operaciones
CREATE TABLE Mantenimiento(
IdMantenimiento int primary key identity(1,1) not null,
IdVehiculo int foreign key references Vehiculo(IdVehiculo),
FechaIngreso date,
FechaSalida date,
Estado varchar(20)
)
GO

CREATE TABLE Detalle_Mantenimiento(
IdDetalleMantenimiento int primary key identity(1,1),
IdMantenimiento int foreign key references Mantenimiento(IdMantenimiento) not null,
IdMecanico int foreign key references Mecanico(IdMecanico),
Precio decimal
)
GO

CREATE TABLE Detalle_Servicio(
IdDetalleServicio int primary key identity(1,1),
IdServicio int foreign key references Servicio(IdServicio),
Precio decimal
)
GO

CREATE TABLE Detalle_Repuesto(
IdDetalleRepuesto int primary key identity(1,1),
IdRepuesto int foreign key references Repuesto(IdRepuesto),
Cantidad int,
Precio decimal
)
GO

CREATE TABLE Detalle_Servicio_Repuesto(
IdDetalleMantenimiento int foreign key references Detalle_Mantenimiento(IdDetalleMantenimiento),
IdDetalleServicio int foreign key references Detalle_Servicio(IdDetalleServicio),
IdDetalleRepuesto int foreign key references Detalle_Repuesto(IdDetalleRepuesto)

primary key(IdDetalleMantenimiento,IdDetalleServicio,IdDetalleRepuesto)
)
GO
EXEC sp_adduser AdminServiPlus, AdminServiPlus
EXEC sp_addrolemember db_owner, AdminServiPlus