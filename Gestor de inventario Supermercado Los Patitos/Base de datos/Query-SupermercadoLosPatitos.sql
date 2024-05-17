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


--Para Documentos

INSERT INTO Consecutivos
VALUES	(1, 0),
		(2, 0),
		(3,	0);


--CAMBIOS MYNELL

USE LOS_PATITOS;

ALTER TABLE Documentos
ALTER COLUMN totalImpuestos DECIMAL(18, 2);

ALTER TABLE Documentos
ALTER COLUMN subtotal DECIMAL(18, 2);

ALTER TABLE Lineas
ALTER COLUMN subtotal DECIMAL(18, 2);

ALTER TABLE Lineas
ALTER COLUMN impuesto DECIMAL(18, 2);



--#####################################################################

--INSERCI�N DE SP PARA Reporter�a



-- Crear las 20 facturas

INSERT INTO Documentos (idDocumento, tipo, fechaCreacion, consecutivo, idCliente, idTrabajador, totalImpuestos, subtotal)
VALUES
    (1, 1, '2024-05-01', 1, 703100722, 1, 500, 4500),
    (2, 2, '2024-05-02', 1, 703100722, 2, 600, 5400),
    (3, 1, '2024-05-03', 2, 3, 1, 550, 4950),
    (4, 2, '2024-05-04', 2, 703100722, 2, 620, 5580),
    (5, 1, '2024-05-05', 3, 5, 1, 580, 5220),
    (6, 1, '2024-05-06', 4, 1, 2, 630, 5670),
    (7, 1, '2024-05-07', 5, 703100722, 1, 600, 5400),
    (8, 1, '2024-05-08', 6, 3, 2, 650, 5850),
    (9, 1, '2024-05-09', 7, 4, 1, 620, 5580),
    (10, 2, '2024-05-10', 3, 703100722, 2, 670, 6030),
    (11, 1, '2024-05-11', 8, 703100722, 1, 640, 5760),
    (12, 2, '2024-05-12', 4, 703100722, 2, 690, 6210),
    (13, 1, '2024-04-13', 9, 703100722, 1, 660, 5940),
    (14, 1, '2024-04-14', 10, 4, 2, 710, 6390),
    (15, 1, '2024-04-15', 11, 5, 1, 680, 6120),
    (16, 1, '2024-04-16', 12, 703100722, 2, 730, 6570),
    (17, 1, '2024-04-17', 13, 703100722, 1, 700, 6300),
    (18, 1, '2024-04-18', 14, 703100722, 2, 750, 6750),
    (19, 1, '2024-04-19', 15, 4, 1, 720, 6480),
    (20, 1, '2024-04-20', 16, 5, 2, 770, 6930);


-- Crear las l�neas de productos

INSERT INTO Lineas (cantidad, codigoProd, subtotal, impuesto, idDocumento)
VALUES
    (10, 1, 15.00, 2, 1),
    (5, 2, 4.00, 1, 1),
    (20, 3, 40.00, 4, 2),
    (10, 4, 12.00, 2, 2),
    (15, 5, 26.25, 2, 3),
    (5, 6, 25.00, 5, 3),
    (8, 7, 28.00, 3, 4),
    (10, 30, 29.90, 3, 4),
    (7, 31, 34.93, 3, 5),
    (10, 32, 34.90, 3, 5),
    (12, 33, 23.88, 2, 6),
    (15, 1, 22.50, 3, 6),
    (20, 2, 16.00, 2, 7),
    (10, 3, 20.00, 2, 7),
    (25, 4, 30.00, 4, 8),
    (12, 5, 21.00, 2, 8),
    (6, 6, 30.00, 5, 9),
    (5, 7, 17.50, 2, 9),
    (8, 30, 23.92, 3, 10),
    (10, 31, 49.90, 4, 10),
    (7, 32, 24.43, 2, 11),
    (9, 33, 17.91, 2, 11),
    (10, 1, 15.00, 2, 12),
    (5, 2, 4.00, 1, 12),
    (20, 3, 40.00, 4, 13),
    (10, 4, 12.00, 2, 13),
    (15, 5, 26.25, 2, 14),
    (5, 6, 25.00, 5, 14),
    (8, 7, 28.00, 3, 15),
    (10, 30, 29.90, 3, 15),
    (7, 31, 34.93, 3, 16),
    (10, 32, 34.90, 3, 16),
    (12, 33, 23.88, 2, 17),
    (15, 1, 22.50, 3, 17),
    (20, 2, 16.00, 2, 18),
    (10, 3, 20.00, 2, 18),
    (25, 4, 30.00, 4, 19),
    (12, 5, 21.00, 2, 19),
    (6, 6, 30.00, 5, 20),
    (5, 7, 17.50, 2, 20);


SELECT * FROM Productos

CREATE PROC Top_Producto
AS
BEGIN
	SELECT TOP 1  P.codigoProd 'C�digo', P.nombre Nombre, P.categoria 'Categor�a', SUM(L.cantidad) 'Total Vendido'
	FROM Lineas L
	INNER JOIN Productos P on
	L.codigoProd = P.codigoProd
	GROUP BY P.codigoProd, P.nombre, P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

CREATE PROC Prod_Vendido_30_Dias
AS
BEGIN
	DECLARE @FechaActual DATE = GETDATE();
	DECLARE @FechaInicio DATE = DATEADD(DAY, -30, @FechaActual);

	SELECT TOP 1 P.codigoProd 'C�digo', P.nombre Nombre, P.categoria 'Categor�a', SUM(L.cantidad) 'Total Vendido'
	FROM Documentos D
	INNER JOIN Lineas L ON
	D.idDocumento = L.idDocumento
	INNER JOIN Productos P ON
	P.codigoProd = L.codigoProd
	WHERE D.fechaCreacion >= @FechaInicio
	GROUP BY P.codigoProd, P.nombre, P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

CREATE PROC Top_5_Clientes
AS
BEGIN
    SELECT TOP 5 D.idCliente 'C�dula', COUNT(D.idDocumento) 'Cantidad de Documentos'
    FROM Documentos D
    WHERE D.idCliente IS NOT NULL
    GROUP BY D.idCliente
    ORDER BY COUNT(D.idDocumento) DESC;
END;

CREATE PROC Facturas_Por_Rango_Fechas
	(@fechaInicial DATE,
    @fechaFinal   DATE)
AS
BEGIN
	SELECT
        D.idDocumento   'ID Documento',
        D.tipo			'Tipo',
        D.fechaCreacion	'Efectuado En',
        D.consecutivo	'Consecurivo',
        D.idCliente		'C�dula del Cliente',
        D.idTrabajador	'C�dula del Trabajador',
        D.totalImpuestos 'Total Impuestos',
        D.subtotal		'SubTotal'
    FROM
        Documentos D
    WHERE
        D.fechaCreacion BETWEEN @fechaInicial AND @fechaFinal
    ORDER BY
        D.fechaCreacion;
END;


CREATE PROC Top_Categorias_Vendidas
AS
BEGIN
	SELECT TOP 5 P.categoria 'Categor�a', SUM(L.cantidad) 'Total Vendido'
	FROM Lineas L
	INNER JOIN Productos P ON
	L.codigoProd = P.codigoProd
	GROUP BY P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

CREATE PROC Cajero_Del_Mes
AS
BEGIN
	SELECT TOP 1 P.idTrabajador 'C�dula', CONCAT(P.apellidoPat, ' ', P.apellidoPat, ' ', P.nombre) 'Nombre Completo'
	FROM Documentos D
	INNER JOIN Personal P ON
	D.idTrabajador = P.idTrabajador
	GROUP BY P.idTrabajador, P.apellidoPat, P.apellidoMat, P.nombre;
END;

CREATE PROC Fecha_Mas_Compras
AS
BEGIN
	SET LANGUAGE Spanish;
	SELECT TOP 1 DATENAME(DW, D.fechaCreacion) 'D�a', COUNT(D.idDocumento) 'Total Facturas'
	FROM Documentos D
	GROUP BY DATENAME(DW, D.fechaCreacion)
	ORDER BY COUNT(D.idDocumento) DESC;
	SET LANGUAGE English;
END;

DROP PROC Fecha_Mas_Compras
DROP PROC Cajero_Del_Mes
DROP PROC Top_Categorias_Vendidas
DROP PROC Facturas_Por_Rango_Fechas
DROP PROC Top_5_Clientes
DROP PROC Prod_Vendido_30_Dias
DROP PROC Top_Producto


EXEC Top_Producto
EXEC Prod_Vendido_30_Dias
EXEC Top_5_Clientes
EXEC Facturas_Por_Rango_Fechas '2024-04-01', '2024-04-20';
EXEC Top_Categorias_Vendidas
EXEC Cajero_Del_Mes
EXEC Fecha_Mas_Compras


--##############################################################