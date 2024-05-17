CREATE DATABASE LOS_PATITOS;
GO;

USE LOS_PATITOS;

CREATE TABLE Roles
	(idRol			VARCHAR(10)		NOT NULL	PRIMARY KEY,
	nombre			VARCHAR(100)	NOT NULL);

CREATE TABLE Personal
	(idTrabajador	INT PRIMARY KEY	NOT NULL,
	fechaNacim		DATE			NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	apellidoPat		VARCHAR(150)	NOT NULL,
	apellidoMat		VARCHAR(150)	NOT NULL,
	direccion		VARCHAR(250)	NOT NULL,
	email			VARCHAR(150)	NOT NULL,
	contrasenia		VARCHAR(250)	NOT NULL,
	numTel			INT				NOT NULL,
	genero			VARCHAR(2)		NOT NULL,
	idRol			VARCHAR(10)		NOT NULL	FOREIGN KEY REFERENCES Roles(idRol),
	estado			BIT				NOT NULL);

CREATE TABLE Bitacora
	(idTrabajador	INT			NOT NULL	FOREIGN KEY REFERENCES	Personal(idTrabajador),
	fechaHora		DATETIME	NOT NULL
	CONSTRAINT		PK_BITACORA	PRIMARY KEY (idTrabajador,fechaHora));

CREATE TABLE Clientes
	(idCliente		INT PRIMARY KEY	NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	apellidoPat		VARCHAR(150)	NOT NULL,
	apellidoMat		VARCHAR(150)	NOT NULL);

CREATE TABLE Productos
	(codigoProd		INT	PRIMARY KEY	NOT NULL,
	categoria		VARCHAR(150)	NOT NULL,
	descripcion		VARCHAR(150)	NOT NULL,
	tipoMedida		VARCHAR(150)	NOT NULL,
	cantidad		INT				NOT NULL,
	precioUnit		DECIMAL(38,2)	NOT NULL,
	fechaCaducidad	DATE			NOT NULL);

CREATE TABLE Consecutivos
	(tipo			INT		NOT NULL	PRIMARY KEY,
	consecutivo		INT		NOT NULL);

CREATE TABLE Documentos
	(idDocumento	INT		NOT NULL	PRIMARY KEY,
	tipo			INT		NOT NULL	FOREIGN KEY REFERENCES Consecutivos(tipo),
	fechaCreacion	DATE	NOT NULL,
	consecutivo		INT		NOT NULL,
	idCliente		INT		NOT NULL	FOREIGN KEY REFERENCES Clientes(idCliente),
	idTrabajador	INT		NOT NULL	FOREIGN KEY REFERENCES Personal(idTrabajador),
	totalImpuestos	INT		NOT NULL,
	subtotal		INT		NOT NULL);

CREATE TABLE Lineas
	(cantidad		INT		NOT NULL,
	codigoProd		INT		NOT NULL	FOREIGN KEY REFERENCES	Productos(codigoProd),
	subtotal		INT		NOT NULL,
	impuesto		INT		NOT NULL,
	idDocumento		INT		NOT NULL	FOREIGN KEY REFERENCES	Documentos(idDocumento));


INSERT INTO Roles
VALUES	(1,'Administrador'),
		(2,'Cajero'),
		(3,'Administrador de Inventario'),
		(4, 'Contador');

CREATE PROC VerificarCredenciales
    @correo VARCHAR(150),
    @contrasenia VARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @existe INT;

    -- Verificar si las credenciales existen en la tabla Personal
    SELECT @existe = COUNT(*) 
    FROM Personal 
    WHERE email = @correo AND contrasenia = @contrasenia;

    -- Retornar true si existe, false si no existe
    IF @existe > 0
        SELECT 'true' AS Existe;
    ELSE
        SELECT 'false' AS Existe;
END

EXEC VerificarCredenciales @correo = 'jozperez@gmail.com', @contrasenia = '1234';

CREATE PROCEDURE EliminarPersonal
    @idTrabajador INT -- Cambiarlo luego por cedula?
AS
BEGIN
    DELETE FROM Personal WHERE idTrabajador = @idTrabajador;
END


SELECT * FROM Personal







-- AJUSTES

DROP TABLE Productos
DROP TABLE Lineas
DROP TABLE Documentos
DROP TABLE Bitacora
DROP TABLE Personal
DROP TABLE Clientes

CREATE TABLE Personal
	(idTrabajador	INT PRIMARY KEY	NOT NULL,
	fechaNacim		DATE			NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	apellidoPat		VARCHAR(150)	NOT NULL,
	apellidoMat		VARCHAR(150)	NOT NULL,
	direccion		VARCHAR(250)	NOT NULL,
	email			VARCHAR(150)	NOT NULL,
	contrasenia		VARCHAR(250)	NOT NULL,
	numTel			INT				NOT NULL,
	genero			VARCHAR(2)		NOT NULL,
	idRol			VARCHAR(10)		NOT NULL	FOREIGN KEY REFERENCES Roles(idRol),
	estado			BIT				NOT NULL);


CREATE TABLE Bitacora
	(idTrabajador	INT			NOT NULL	FOREIGN KEY REFERENCES	Personal(idTrabajador),
	fechaHora		DATETIME	NOT NULL
	CONSTRAINT		PK_BITACORA	PRIMARY KEY (idTrabajador,fechaHora));

CREATE TABLE Documentos
	(idDocumento	INT		NOT NULL	PRIMARY KEY,
	tipo			INT		NOT NULL	FOREIGN KEY REFERENCES Consecutivos(tipo),
	fechaCreacion	DATE	NOT NULL,
	consecutivo		INT		NOT NULL,
	idCliente		INT,
	idTrabajador	INT		NOT NULL	FOREIGN KEY REFERENCES Personal(idTrabajador),
	totalImpuestos	INT		NOT NULL,
	subtotal		INT		NOT NULL);

CREATE TABLE Productos
	(codigoProd		INT	PRIMARY KEY	NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	categoria		VARCHAR(150)	NOT NULL,
	tipoMedida		VARCHAR(150)	NOT NULL,
	cantidadInv		INT				NOT NULL,
	precioUnit		DECIMAL(38,2)	NOT NULL)

CREATE TABLE Lineas
	(cantidad		INT		NOT NULL,
	codigoProd		INT		NOT NULL	FOREIGN KEY REFERENCES	Productos(codigoProd),
	subtotal		INT		NOT NULL,
	impuesto		INT		NOT NULL,
	idDocumento		INT		NOT NULL	FOREIGN KEY REFERENCES	Documentos(idDocumento));

ALTER TABLE Lineas
ADD CONSTRAINT PK_Lineas PRIMARY KEY (codigoProd,idDocumento);

ALTER TABLE Personal
ALTER COLUMN genero VARCHAR(20);

INSERT INTO Personal 
VALUES 
    (1, '1990-05-15', 'Juan', 'P�rez', 'Gonz�lez', 'Calle Principal 123', '1', '1', 123456789, 'M', 1, 1),
    (2, '1990-05-15', 'Juan', 'P�rez', 'Gonz�lez', 'Calle Principal 123', 'jozperez@gmail.com', '1234', 123456789, 'M', 1, 1),
    (3, '1995-08-20', 'Mar�a', 'L�pez', 'Garc�a', 'Avenida Central 456', 'maria.lopez@email.com', '1234', 987654321, 'F', 2, 1),
    (4, '1988-12-10', 'Pedro', 'Mart�nez', 'Hern�ndez', 'Calle Secundaria 789', 'jozafatperezfer@gmail.com', '1234', 555555555, 'M', 3, 1),
    (5, '1987-04-25', 'Ana', 'G�mez', 'Fern�ndez', 'Paseo Peatonal 234', 'ana.gomez@email.com', '1234', 111111111, 'F', 4, 1);

INSERT INTO Personal 
VALUES 
(6, '1990-05-15', 'Juan', 'P�rez', 'Gonz�lez', 'Calle Principal 123', '1', '1', 123456789, 'Masculino', 1, 1);

INSERT INTO Productos (codigoProd, nombre, categoria, tipoMedida, cantidadInv, precioUnit) VALUES
(1, 'Leche Entera', 'L�cteos', 'Litros', 50, 1.50),
(2, 'Pan Integral', 'Panader�a', 'Unidades', 100, 0.80),
(3, 'Jugo de Naranja', 'Bebidas', 'Litros', 75, 2.00),
(4, 'Arroz Blanco', 'Granos', 'Kilos', 200, 1.20),
(5, 'Manzanas', 'Frutas', 'Kilos', 150, 1.75),
(6, 'Pollo Entero', 'Carnes', 'Kilos', 30, 5.00),
(7, 'Detergente L�quido', 'Limpieza', 'Litros', 60, 3.50);

INSERT INTO Productos (codigoProd, nombre, categoria, tipoMedida, cantidadInv, precioUnit)
VALUES (30, 'Leche de Avena', 'L�cteos', 'Unidad', 100, 2.99),
       (31, 'Avena', 'Cereales', 'Paquete', 50, 4.99),
       (32, 'Galleta Avena y fresa', 'Snacks', 'Paquete', 80, 3.49),
       (33, 'Helado de Avena y miel', 'Helados', 'Unidad', 120, 1.99);