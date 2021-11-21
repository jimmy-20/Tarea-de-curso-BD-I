USE SERVIPLUS
GO

CREATE PROCEDURE Cambiar_Estado_Cliente @IdCliente int
AS

if exists(SELECT
    *
    FROM
    Cliente
    where IdCliente = @IdCliente and Estado = 'Habilitado'
    )
UPDATE Cliente SET
Estado = 'Deshabilitado'
WHERE IdCliente = @IdCliente
ELSE
UPDATE Cliente SET
Estado = 'Habilitado'
WHERE IdCliente = @IdCliente

CREATE PROCEDURE Cambiar_Estado_Servicio @IdServicio int
AS

IF exists (
           SELECT
		   *
		   FROM
		   Servicio 
		   WHERE IdServicio = @IdServicio and Estado = 'Habilitado'
           )
UPDATE Servicio SET
Estado = 'Deshabilitado'
WHERE IdServicio = @IdServicio
ELSE
UPDATE Servicio SET
Estado = 'Habilitado'
WHERE IdServicio = @IdServicio

CREATE PROCEDURE Cambiar_Estado_Mecanico @IdMecanico int
AS
IF exists (
           SELECT
		   *
		   FROM Mecanico
		   WHERE IdMecanico = @IdMecanico and Estado = 'Habilitado'
           )
UPDATE Mecanico SET
Estado = 'Deshabilitado'
WHERE IdMecanico = @IdMecanico
ELSE
UPDATE Mecanico SET
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