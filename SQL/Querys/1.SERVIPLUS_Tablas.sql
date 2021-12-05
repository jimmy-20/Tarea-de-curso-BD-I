--Ejecutar todo el Query y luego trabajar con el Login AdminServiPlus
CREATE DATABASE SERVIPLUS
GO

USE SERVIPLUS
GO
--Creacion de catalogos
CREATE TABLE Clientes(
IdCliente int primary key identity(1,1) not null,
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50) ,
Telefono varchar(20) not null,
Direccion varchar(50) not null,
Correo varchar(50) not null,
Estado varchar(20) not null
)
GO

CREATE TABLE Vehiculos(
IdVehiculo int primary key identity(1,1) not null,
IdCliente int foreign key references Clientes(IdCliente) not null,
Marca varchar(50) not null,
Modelo varchar(50) not null,
Año int not null
)
GO

CREATE TABLE Servicios(
IdServicio int primary key identity(1,1) not null,
Descripcion varchar(50) not null,
Precio decimal not null,
Descuento decimal not null, --descuento en inventario
TipoMantenimiento varchar(50) not null,
Estado varchar(20) not null
)
GO

CREATE TABLE Repuestos(
IdRepuesto int primary key identity(1,1) not null,
Descripcion varchar(50) not null,
Marca varchar(50) not null,
Modelo varchar(50) not null,
Precio decimal not null,
Descuento decimal not null, --descuento en  inventario
Cantidad int not null,
Estado varchar(20)
)
GO

CREATE TABLE Mecanicos(
IdMecanico int primary key identity(1,1) not null,
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50) not null,
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50) not null,
Especialidad varchar(50) not null,
Salario decimal not null,
Direccion varchar(50) not null,
Telefono varchar (50) not null,
Correo varchar(50) not null,
Estado varchar(20) not null
)
GO

--Tablas de operaciones
CREATE TABLE Mantenimientos(
IdMantenimiento int primary key identity(1,1) not null,
IdVehiculo int foreign key references Vehiculos(IdVehiculo) not null,
FechaIngreso date not null,
FechaSalida date not null,
Estado varchar(20) not null
)
GO

CREATE TABLE Detalle_Mantenimientos(
IdDetalleMantenimiento int primary key identity(1,1) not null,
IdMantenimiento int foreign key references Mantenimientos(IdMantenimiento) not null,
IdMecanico int foreign key references Mecanicos(IdMecanico),
IdServicio int foreign key references  Servicios(IdServicio) not null,
Precio decimal not null,
Descuento decimal not null, --descuento del servicio aplicado
Estado varchar(20)
)
GO

CREATE TABLE Detalle_Repuestos(
IdDetalleMantenimiento int foreign key references Detalle_Mantenimientos(IdDetalleMantenimiento) not null,
IdRepuesto int foreign key references Repuestos(IdRepuesto),
Cantidad int not null,
Precio decimal not null,
Descuento decimal not null -- descuento aplicado
)

--Tabla de colaboradores a los cuales les pertenece un usuario
CREATE TABLE Colaboradores(
IdColaborador int primary key identity(1,1) not null,
PrimerNombre varchar(50) not null,
SegundoNombre varchar(50),
PrimerApellido varchar(50) not null,
SegundoApellido varchar(50) not null,
Telefono varchar (30) not null,
Especialidad varchar (50) not null
)
GO
--Tabla de users que van a entrar al servidor/ DB
Create table Usuarios(
IdUsuario int identity(1,1) primary key not null,
IdColaborador int foreign key references Colaboradores(IdColaborador) not null,
Usuario varchar(80) not null,
Contraseña varchar(80) not null,
Rol varchar(80) not null,
Estado varchar(20) not null
) 