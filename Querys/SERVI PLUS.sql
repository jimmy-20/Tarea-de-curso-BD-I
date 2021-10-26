Create database SERVIPLUS
use SERVIPLUS

create table Clientes(
NoCliente int identity(1,1) primary key not null,
[Primer Nombre] nvarchar(50) not null,
[Segundo Apellido] nvarchar(50) not null
)

create table Mecanicos(
NoMecanico int identity(1,1) primary key not null,
[Primer Nombre] nvarchar(50) not null,
[Segundo Apellido] nvarchar(50) not null
)

Create table Vehiculos(
NoVehiculo int identity(1,1) primary key not null,
NoCliente int foreign key references Clientes(NoCliente) not null,
Marca nvarchar(50) not null,
Modelo nvarchar(50) not null,
Año date not null
)

create table Mantenimientos(
NoMantenimiento  int identity(1,1) primary key not null,
NoVehiculo int foreign key references Vehiculos(NoVehiculo) not null,
FechaIngreso date not null,
FechaSalida date not null,
)

create table Servicios(
NoServicio int identity(1,1) primary key not null,
Descripcion nvarchar(70) not null,
Precio float not null,
[Tipo de Mantenimiento] nvarchar(50) not null
)

create table Repuestos(
NoRepuesto int identity(1,1) primary key not null,
Titulo nvarchar(50) not null,
Descripcion nvarchar(70) not null,
Marca nvarchar(50) not null,
Modelo nvarchar(50) not null,
Costo float not null,
)

Create table [Detalle de Repuestos](
NoDetRepuestos int identity(1,1) not null,
NoRepuesto int foreign key references Repuestos(NoRepuesto) not null,
Cantidad int not null,
Primary key(NoDetRepuestos,NoRepuesto)
)

Create table [Detalle de Mantenimiento](
NoDetMant int identity(1,1) not null,
NoMantenimiento int foreign key references Mantenimientos(NoMantenimiento),
NoServicio int foreign key references Servicios(NoServicio) not null,
NoRepuesto int foreign key references Repuestos(NoRepuesto) ,
NoMecanico int foreign key references Mecanicos(NoMecanico) not null,
Primary key(NoDetMant,NoMantenimiento)
)
