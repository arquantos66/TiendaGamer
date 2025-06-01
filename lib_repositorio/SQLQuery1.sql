CREATE DATABASE TiendaGamer
GO
USE TiendaGamer
GO
CREATE TABLE Vendedores (
    ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nombre NVARCHAR (50) NOT NULL,
    Apellido NVARCHAR (50) NOT NULL,
    Cedula NVARCHAR (25) UNIQUE NOT NULL,
    Edad INT NOT NULL
);

CREATE TABLE Tecnicos (
    ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nombre NVARCHAR (50) NOT NULL,
    Apellido NVARCHAR (50) NOT NULL,
    Cedula NVARCHAR (25) UNIQUE NOT NULL,
    Edad INT NOT NULL

);

CREATE TABLE Clientes  (
	ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Codigo NVARCHAR (20) UNIQUE NOT NULL,
	Nombre NVARCHAR (50) NULL,
	Apellido NVARCHAR (50) NULL,
	Direccion NVARCHAR (100) NOT NULL,
	email NVARCHAR (100)
);

CREATE TABLE Servicios (
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nombre NVARCHAR (50) NOT NULL

);
CREATE TABLE Marcas (
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Nombre NVARCHAR (50) NOT NULL

);

CREATE TABLE Productos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Codigo NVARCHAR(20) NOT NULL UNIQUE,
    Nombre NVARCHAR(50) NOT NULL,
    IVA DECIMAL(7,2) NULL,
    Garantia NVARCHAR(20) NULL
);

CREATE TABLE VendedoresProductos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Vendedor INT NOT NULL,
    Producto INT NOT NULL,
    FOREIGN KEY (Vendedor) REFERENCES Vendedores(ID),
    FOREIGN KEY (Producto) REFERENCES Productos(ID)
);

CREATE TABLE TecnicosProductos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Tecnico INT NOT NULL,
    Producto INT NOT NULL,
    FOREIGN KEY (Tecnico) REFERENCES Tecnicos(ID),
    FOREIGN KEY (Producto) REFERENCES Productos(ID)
);

CREATE TABLE ClientesProductos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Cliente INT NOT NULL,
    Producto INT NOT NULL,
    FOREIGN KEY (Cliente) REFERENCES Clientes(ID),
    FOREIGN KEY (Producto) REFERENCES Productos(ID)
);

CREATE TABLE ProductosMarcas (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Producto INT NOT NULL,
    Marca INT NOT NULL,
    FOREIGN KEY (Producto) REFERENCES Productos(ID),
    FOREIGN KEY (Marca) REFERENCES Marcas(ID)
);

CREATE TABLE ServiciosProductos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Servicio INT NOT NULL,
    Producto INT NOT NULL,
    FOREIGN KEY (Servicio) REFERENCES Servicios(ID),
    FOREIGN KEY (Producto) REFERENCES Productos(ID)
);

INSERT INTO Vendedores(Nombre, Apellido, Cedula, Edad)
VALUES
('Emmanuel','Castaño','1453789014',30),
('Luis','Hernandez','1453781028',30),
('Mateo','Gonzalez','1453789728',30);


INSERT INTO Tecnicos(Nombre, Apellido, Cedula, Edad)
VALUES 
('Jaime','Bedoya','1453789014',25),
('Ismael','Ruiz','1183789014',29),
('Mauricio','Jimenez','1474189014',35);

INSERT INTO Clientes(Codigo,Nombre,Apellido,Direccion,email)
VALUES
('AA1','','','callefalsa123','noreplay@hotmail.com'),
('AA2','','','callefalsa457','genesisminingg@hotmail.com'),
('AA3','','','callefalsa147','pepito@itm.edu.co');

INSERT INTO Servicios(Nombre)
VALUES
('Venta'),
('Mantenimiento'),
('Ensamble');


INSERT INTO Marcas(Nombre)
VALUES
('Samsung'),
('LG'),
('Asus'),
('Lenovo'),
('Logitech'),
('Razer'),
('VSG'),
('Redragon'),
('AMD RYZEN'),
('Intel	'),
('MSI'),
('EVGA'),
('Zotac'),
('XPG'),
('Corsair'),
('Adata'),
('HP'),
('Apple'),
('Toshiba');

INSERT INTO Productos(Codigo,Nombre,IVA,Garantia)
VALUES 
('F001','Monitor',NULL,''),
('F002','Teclado',NULL,''),
('F003','Mouse',NULL,''),
('F004','CPU',NULL,''),
('F005','GPU',NULL,''),
('F006','Memoria RAM',NULL,''),
('F007','PC ensamblado',NULL,''),
('F008','PC portatiles',NULL,'');

INSERT INTO VendedoresProductos(Producto,Vendedor)
VALUES
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(2,3),
(3,1),
(3,2),
(3,3),
(4,1),
(4,2),
(4,3),
(5,1),
(5,2),
(5,3),
(6,1),
(6,2),
(6,3),
(7,1),
(7,2),
(7,3),
(8,1),
(8,2),
(8,3);

INSERT INTO TecnicosProductos(Producto,Tecnico)
VALUES
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(2,3),
(3,1),
(3,2),
(3,3),
(4,1),
(4,2),
(4,3),
(5,1),
(5,2),
(5,3),
(6,1),
(6,2),
(6,3),
(7,1),
(7,2),
(7,3),
(8,1),
(8,2),
(8,3);

INSERT INTO ClientesProductos(Producto,Cliente)
VALUES
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(2,3),
(3,1),
(3,2),
(3,3),
(4,1),
(4,2),
(4,3),
(5,1),
(5,2),
(5,3),
(6,1),
(6,2),
(6,3),
(7,1),
(7,2),
(7,3),
(8,1),
(8,2),
(8,3);

INSERT INTO ProductosMarcas(Producto,Marca)
VALUES 
(1,1),
(1,2),
(1,3),
(1,4),
(2,5),
(2,6),
(2,7),
(2,8),
(3,5),
(3,6),
(3,7),
(3,8),
(4,9),
(4,10),
(5,11),
(5,12),
(5,13),
(6,14),
(6,15),
(6,16),
(7,4),
(7,17),
(8,4),
(8,18),
(8,19);

INSERT INTO ServiciosProductos(Producto,Servicio)
VALUES
(1,1),
(1,2),
(2,1),
(2,2),
(3,1),
(3,2),
(4,1),
(4,2),
(4,3),
(5,1),
(5,2),
(5,3),
(6,1),
(6,2),
(6,3),
(7,1),
(7,2),
(7,3),
(8,1),
(8,2);

SELECT * FROM Vendedores;

SELECT * FROM Tecnicos;

SELECT * FROM Clientes;

SELECT * FROM Servicios;

SELECT * FROM Marcas;

SELECT * FROM Productos;

SELECT * FROM VendedoresProductos;

SELECT * FROM TecnicosProductos;

SELECT * FROM ClientesProductos;

SELECT * FROM ProductosMarcas;

SELECT * FROM ServiciosProductos;