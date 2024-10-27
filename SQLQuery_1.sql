use PROMOS_DB
go
/*                
--create procedure storedListar as 
SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Id as IdMarca, m.Descripcion as DescripcionM, c.Id as IdCategoria, c.Descripcion as DescripcionC, i.Id as IdImagen, i.ImagenUrl as Imagen 
    FROM ARTICULOS a LEFT JOIN CATEGORIAS c ON c.Id = a.IdCategoria LEFT JOIN MARCAS m ON m.Id = a.IdMarca LEFT JOIN IMAGENES i ON i.IdArticulo = a.Id 
--exec storedListar*/

/*SELECT * From Clientes
SELECT * From ARTICULOS
SELECT * From CATEGORIAS
SELECT * From MARCAS
SELECT * From IMAGENES
SELECT * From Vouchers
SELECT IdCliente, FechaCanje, IdArticulo FROM Vouchers*/

SELECT * From Clientes
SELECT * From ARTICULOS
SELECT * From Vouchers 
--create procedure storedListar as 
SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, m.Id as IdMarca, m.Descripcion as DescripcionM, c.Id as IdCategoria, c.Descripcion as DescripcionC, i.Id as IdImagen, i.ImagenUrl as Imagen 
    FROM ARTICULOS a LEFT JOIN CATEGORIAS c ON c.Id = a.IdCategoria LEFT JOIN MARCAS m ON m.Id = a.IdMarca LEFT JOIN IMAGENES i ON i.IdArticulo = a.Id 
--exec storedListar