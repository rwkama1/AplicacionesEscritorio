-- Creo Base de datos
use master;
go
--creo la base de datos de ventas
if exists(Select * FROM SysDataBases WHERE name='Biblioteca')
BEGIN
	DROP DATABASE Biblioteca
END
go

CREATE DATABASE Biblioteca
ON(
	NAME=Biblioteca,
	FILENAME='C:\Biblioteca.mdf'
)
go



--Creo esquema ------------------------------------------------------------------------------------------
USE Biblioteca
go

CREATE TABLE Autor(
	CodAut int NOT NULL PRIMARY KEY identity(1,1),
	NomAut varchar(20) NOT NULL Unique,
	NacAut varchar(20)
) 

CREATE TABLE TipoLibro(
	CodTip int NOT NULL PRIMARY KEY identity(1,1),
	NomTip varchar(20) NOT NULL Unique,
	EstanteriaTip int NOT NULL
) 

CREATE TABLE Libro(
	ISBNLib int NOT NULL PRIMARY KEY ,
	NomLib varchar(20) NOT NULL,
	ReseñaLib varchar (100),
	CodAut int Foreign Key References Autor(CodAut),
	CodTip int Foreign Key References TipoLibro(CodTip)
) 
go

CREATE TABLE Usuario(
	NomUsu varchar(10) NOT NULL PRIMARY KEY ,
	PassUsu varchar(10) NOT NULL
) 
go
--------------
Create Procedure AltaAutor  @NomAut varchar(20),@NacAut varchar(20) AS
Begin
	if exists(select * from Autor where NomAut=@NomAut)
	begin
			return -1
		end
			begin
				Insert Autor(NomAut,NacAut) Values ( @NomAut, @NacAut)
				if @@ERROR = 0
					return 1
				else
					return 0
			end
		
	
end
go

Create Procedure BajaAutor @codaut int AS
Begin
	if (not exists(select * from Autor where CodAut = @codaut))
		return -1
	else
	begin
		Delete From Autor where CodAut= @codaut
		if @@ERROR = 0
			return 1
		else
			return 0
	end
end
go


---------
Create Procedure ModificarAutor @codaut int, @NomAut varchar(20),@NacAut varchar(20) AS
Begin

		if (Not (exists(select * from Autor where CodAut = @codAut)))
		begin
			return -2
			end
			if exists(select * from Autor where NomAut=@NomAut)
			begin
				return -1
			end
		else
			begin
			Update Autor Set NomAut=@NomAut, NacAut=@NacAut Where codaut = @codaut
			if @@ERROR = 0
				return 1
			else
				return 0
			end
		
	
end
go 
--declare @s int 
--exec @s=ModificarAutor 1,'asd',3
--select @s 
--go
select * from autor

---------------------------------------------SP ALTAS-----------------------------------------------------------------
Create Procedure AltaLibro @isbn int, @nom varchar(20), @reseña varchar(100),  @codAut int, @codTip int AS
Begin
	if (exists (select * from Libro where IsbnLib = @isbn))
		return -1
	else
	begin
		if (Not (exists(select * from Autor where CodAut = @codAut)))
			return -2
		else
		begin
			if (Not (exists(select * from TipoLibro where CodTip = @codTip)))
				return -3
			else
			begin
				Insert Libro(IsbnLib, NomLib, ReseñaLib, CodAut, CodTip) Values (@isbn, @nom, @reseña, @codAut, @codTip)
				if @@ERROR = 0
					return 1
				else
					return 0
			end
		end
	end
end
go

---------------------------------------------SP BAJAS-----------------------------------------------------------------
Create Procedure BajaLibro @isbn int AS
Begin
	if (not exists(select * from Libro where isbnLib = @isbn))
		return -1
	else
	begin
		Delete From Libro where isbnLib = @isbn
		if @@ERROR = 0
			return 1
		else
			return 0
	end
end
go

---------------------------------------------SP MODIFICACIONES-------------------------------------------------------
Create Procedure ModificarLibro @isbn int, @nom varchar(20), @reseña varchar(100),  @codAut int, @codTip int AS
Begin
	if (Not exists (select * from Libro where IsbnLib = @isbn))
		return -1
	else
	begin
		if (Not (exists(select * from Autor where CodAut = @codAut)))
			return -2
		else
		begin
			if (Not (exists(select * from TipoLibro where CodTip = @codTip)))
				return -3
			else
			begin
			Update Libro Set NomLib=@nom, ReseñaLib=@reseña, codAut=@codAut, codTip=@codTip Where isbnLib = @isbn
			if @@ERROR = 0
				return 1
			else
				return 0
			end
		end
	end
end
go

---------------------------------------------SP BUSQUEDAS INDIVIDUALES-----------------------------------------------
Create Procedure BuscoAutor @cod int AS
Begin
	Select *
	From Autor
	where codAut = @cod
end
go

Create Procedure BuscoTipoLibro @cod int AS
Begin
	Select *
	From TipoLibro
	where codTip = @cod
end
go

Create Procedure BuscoLibro @isbn int AS
Begin
	Select *
	From Libro
	where IsbNLib = @isbn
end
go

Create Procedure BuscoUsuario @nom varchar(10) AS
Begin
	Select *
	From Usuario
	where NomUsu = @nom
end
go


---------------------------------------------SP LISTADOS COMUNES-----------------------------------------------------
Create Procedure ListoAutor AS
Begin
	Select *
	From Autor
end
go

Create Procedure ListoTipoLibro AS
Begin
	Select *
	From TipoLibro
end
go

Create Procedure ListoLibro AS
Begin
	Select *
	From Libro
end
go

--- Alta de Datos Manuales
Insert Usuario(NomUsu, PassUsu) Values ('USUARIO1','usu1')
Insert Usuario(NomUsu, PassUsu) Values ('USUARIO2','usu2')
go

Insert Autor(NomAut, NacAut) Values ('Shakespeare','Ingles')
Insert Autor(NomAut, NacAut) Values ('J.E. Rodo','Uruguayo')
Insert Autor(NomAut, NacAut) Values ('Garcia Marques','Colombiano')
go

Insert TipoLibro(NomTip, EstanteriaTip) Values ('Drama','20')
Insert TipoLibro(NomTip, EstanteriaTip) Values ('Cuento','50')
Insert TipoLibro(NomTip, EstanteriaTip) Values ('Filosofia','3')
