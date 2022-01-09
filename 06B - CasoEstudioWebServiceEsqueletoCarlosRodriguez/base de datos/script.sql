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
	NAME=Venta,
	FILENAME='C:\Ventas.mdf'
)
go

-- Creo la estructura de la bd ----------------------------------------------------------------------
USE Ventas
go

CREATE TABLE Articulos(
	CodArt int NOT NULL PRIMARY KEY ,
	NomArt varchar(20) NOT NULL,
	PreArt Money
) 
go
create table Produccion 
(
	CodArt int Not Null Primary Key Foreign Key References Articulos(CodArt),
	FechaProduccion datetime Not Null,
)
go


--creo SP para manejo ------------------------------------------------------------------------------
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

Create Procedure AltaArticuloProduccion @cod int, @precio money,@nombre varchar(20),@fecha datetime As
Begin
	if (exists(select * from Articulos where codArt = @cod))
		return -1
		else
		begin
		Begin Transaction
	
		Insert Articulos (CodArt,NomArt,PreArt) Values (@cod,@nombre,@precio)
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -1
		End

		Insert Produccion (CodArt,FechaProduccion) Values(@cod,@fecha)
		if (@@ERROR<>0)
		Begin
			RollBack Transaction
			return -2
		End
	
		Commit Transaction
		return 1
		end
End
go
----
--BAJA ARTICULO PRODUCCION
Create Procedure BajaProduccion @cod int As
Begin
		if (not exists(select * from Articulos where codArt = @cod))
		begin
		return -1
		end
		
	
		else
		begin
		
		Begin Transaction

		Delete From Produccion Where codArt = @cod
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End

		Delete From Articulos Where codArt = @cod
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -4
		End

		Commit Transaction
		return 1
		end

End
go
--UPDATE 
Create Procedure ModificarProduccion @cod int,@nom varchar(20),@pre money,@fecha datetime As
Begin
		if (not exists(select * from Articulos where codArt = @cod))
		begin
		return -1
		end
		
	
		else
		begin
		
		Begin Transaction

		Update Produccion set FechaProduccion=@fecha where codArt = @cod
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -3
		End

		Update Articulos Set NomArt=@nom, PreArt=@pre where codArt = @cod
		if (@@ERROR <> 0)
		Begin
			RollBack Transaction
			return -4
		End

		Commit Transaction
		return 1
		end

End
go
--BUSCAR PRODUCCION
Create Procedure BuscarProduccion @cod int As
Begin
	Select * 
	From Articulos A Inner Join Produccion P on A.CodArt = P.CodArt 
	Where P.CodArt = @cod
End
go
--exec BuscarProduccion 1
--declare @s int
--exec @s=ModificarProduccion 1,'asd',200,'5/5/5'
--select @s
--declare @s int
--exec @s=AltaArticuloProduccion 1,200,'asd','2/2/2'
--select @s
----declare @s int
----exec @s=BajaProduccion 1
----select @s
--select * from Produccion
------select * from articulos

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

CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS
GO

USE Ventas
GO

CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO

GRANT execute to [IIS APPPOOL\DefaultAppPool]
GO