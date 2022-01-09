-- Creo la base de datos -----------------------------------------------------------------------------------------------
USE master
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



-- creo tablas ----------------------------------------------------------------------------------------------------------
USE Ventas
go

CREATE TABLE Familias(
	CodFam int NOT NULL PRIMARY KEY,
	NomFam varchar(20) NOT NULL,
	DescFam varchar(30)
) 
go


CREATE TABLE Articulos(
	CodArt int NOT NULL PRIMARY KEY ,
	NomArt varchar(20) NOT NULL,
	PreArt Money,
	CodFam int Foreign Key References Familias(CodFam)
) 
go


-- Ingreso de Datos manuales -------------------------------------------------------------------------------------------------------
Insert Familias (CodFam, NomFam, DescFam) Values (1, 'Comestibles', 'Productos que se pueden Comer')
Insert Familias (CodFam, NomFam, DescFam) Values (2, 'Limpieza', 'Productos para limpiar')
Insert Familias (CodFam, NomFam, DescFam) Values (3, 'Electrodomesticos', 'Productos muy utiles')
go

--ingreso datos de prueba familia
Insert Articulos (CodARt, NomArt, PreArt,CodFam) Values ('1', 'Pizza', 150, 1)
Insert Articulos (CodARt, NomArt, PreArt,CodFam) Values ('2', 'Nevex 5kg', 250, 2)
Insert Articulos (CodARt, NomArt, PreArt,CodFam) Values ('3', 'Ventilador de techo', 10, 3)
go