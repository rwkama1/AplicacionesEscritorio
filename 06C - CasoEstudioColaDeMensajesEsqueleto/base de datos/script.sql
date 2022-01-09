-- Creo la base de datos -----------------------------------------------------------------------------
use master
go

if exists(Select * FROM SysDataBases WHERE name='Ventas')
BEGIN
	DROP DATABASE Ventas
END
go

CREATE DATABASE Ventas
ON(
	NAME=Ventas,
	FILENAME='C:\Ventas.mdf'
)
go

-- Creo la estructura de la bd ----------------------------------------------------------------------
USE Ventas
go

CREATE TABLE Articulos
(
	CodArt int NOT NULL PRIMARY KEY ,
	NomArt varchar(20) NOT NULL,
	PreArt Money
) 
go

Create Table Pedidos
(
	NumPed int not null Primary Key Identity,
	NomCliPed varchar(20) not null,
	DirPed varchar(20),
	CodArt int not null Foreign Key References Articulos(CodArt)
)
go

--creo SP para manejo Articulos ------------------------------------------------------------------------------
Create Procedure AltaArticulo @cod int, @nom varchar(20), @pre money AS
Begin
	if (exists(select * from Articulos where codArt = @cod))
		return -1
	else
	begin
		Insert Articulos(CodARt, NomArt, PreArt) Values (@cod, @nom, @pre)
		return 1
	end
end
go

Create Procedure BajaArticulo @cod int AS
Begin
	if (not exists(select * from Articulos where codArt = @cod))
		return -1
	else
	begin
		Delete From Articulos where codArt = @cod
		return 1
	end
end
go

Create Procedure ModArticulo @cod int, @nom varchar(20), @pre money AS
Begin
	if (not exists(select * from Articulos where codArt = @cod))
		return -1
	else
	begin
		Update Articulos Set NomArt=@nom, PreArt=@pre where codArt = @cod
		return 1
	end
end
go

Create Procedure BuscoArticulo @cod int AS
Begin
	Select *
	From Articulos
	where codArt = @cod
end
go

Create Procedure ListoArticulo AS
Begin
	Select *
	From Articulos
end
go


-- creo SP para manejo de Pedidos
Create Procedure AltaPedido @nom varchar(20), @dir varchar(20), @art int AS
Begin
	if (Not exists(select * from Articulos where codArt = @art))
		return -1
	else
	begin
		Insert Pedidos(NomCliPed, DirPed, CodArt) Values (@nom, @dir, @art)
		return 1
	end
End
go

Create Procedure ListoPedido AS
Begin
	Select *
	From Pedidos
end
go

--ingreso datos de prueba---------------------------------------------------------------------
Exec AltaArticulo 23, "Licuadora", 2500
go

Exec AltaArticulo 48, "Maquina de Coser", 6700
go

Exec AltaArticulo 514, "Ventilador de Techo Vertical", 250
go


--creacion de usuario IIS para que el webservice pueda acceder a la bd------------------------
USE master
GO

CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS WITH DEFAULT_DATABASE = master
GO

USE Ventas
GO


CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO

GRANT execute to [IIS APPPOOL\DefaultAppPool]
GO