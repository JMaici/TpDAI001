Create procedure sp_ListarPizzas 
as
begin
SELECT * FROM Pizzas
END

CREATE PROCEDURE sp_ObtenerPizzaPorID
@pId int
AS 
BEGIN
SELECT * FROM Pizzas 
WHERE Pizzas.Id = @pId
END

CREATE PROCEDURE sp_EliminarPizza
@pId int
AS 
BEGIN
DELETE FROM Pizzas 
WHERE Id = @pId
END

CREATE PROCEDURE sp_AgregarPizza
@pNombre varchar(150),
@pLibreGluten bit,
@pImporte float,
@pDescripcion varchar(800)
AS 
BEGIN
INSERT INTO Pizzas VALUES (@pNombre, @pLibreGluten, @pImporte, @pDescripcion)
END

CREATE PROCEDURE sp_ModificarPizza
@pNombre varchar(150),
@pLibreGluten bit,
@pImporte float,
@pDescripcion varchar(800),
@pId int

AS 
BEGIN
UPDATE Pizzas Set Nombre = @pNombre, LibreGluten = @pLibreGluten, Importe = @pImporte, Descripcion = @pDescripcion WHERE Id = @pId
END

