CREATE DATABASE LOS_PATITOS;
GO;

USE LOS_PATITOS;

-- Tabla de roles de personal
CREATE TABLE Roles
	(idRol			VARCHAR(10)		NOT NULL	PRIMARY KEY,
	nombre			VARCHAR(100)	NOT NULL);

-- Tabla de registro de personal
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
	genero			VARCHAR(20)		NOT NULL,
	idRol			VARCHAR(10)		NOT NULL	FOREIGN KEY REFERENCES Roles(idRol),
	estado			BIT				NOT NULL);

-- Tabla de bitacora de creación de personal
CREATE TABLE Bitacora
	(idTrabajador	INT			NOT NULL	FOREIGN KEY REFERENCES	Personal(idTrabajador),
	fechaHora		DATETIME	NOT NULL
	CONSTRAINT		PK_BITACORA	PRIMARY KEY (idTrabajador,fechaHora));

-- Tabla de registro de clientes
CREATE TABLE Clientes
	(idCliente		INT PRIMARY KEY	NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	apellidoPat		VARCHAR(150)	NOT NULL,
	apellidoMat		VARCHAR(150)	NOT NULL);

-- Tabla de registro de productos
CREATE TABLE Productos
	(codigoProd		INT	PRIMARY KEY	NOT NULL,
	nombre			VARCHAR(150)	NOT NULL,
	categoria		VARCHAR(150)	NOT NULL,
	tipoMedida		VARCHAR(150)	NOT NULL,
	cantidadInv		INT				NOT NULL,
	precioUnit		DECIMAL(38,2)	NOT NULL);

CREATE TABLE BitacoraAjuste (
	IdAjuste		INT			PRIMARY KEY IDENTITY(1,1),
	idTrabajador	INT			NOT NULL	FOREIGN KEY REFERENCES	Personal(idTrabajador),
	fechaHora		DATETIME	NOT NULL,
	motivo			VARCHAR(255) NOT NULL
);

CREATE TABLE ProductosAjustados (
	IdAjuste	INT		NOT NULL	FOREIGN KEY REFERENCES	BitacoraAjuste(IdAjuste),
	codigoProd	INT		NOT NULL	FOREIGN KEY REFERENCES	Productos(codigoProd),
	cantidad	INT		NOT NULL
);

CREATE TABLE Consecutivos
	(tipo			INT		NOT NULL	PRIMARY KEY,
	consecutivo		INT		NOT NULL);

-- 
CREATE TABLE Documentos
	(idDocumento	INT		NOT NULL	PRIMARY KEY,
	tipo			INT		NOT NULL	FOREIGN KEY REFERENCES Consecutivos(tipo),
	fechaCreacion	DATE	NOT NULL,
	consecutivo		INT		NOT NULL,
	idCliente		INT,
	idTrabajador	INT		NOT NULL	FOREIGN KEY REFERENCES Personal(idTrabajador),
	totalImpuestos	DECIMAL(18, 2)		NOT NULL,
	subtotal		DECIMAL(18, 2)		NOT NULL,
    idNotaCredito   INT     NULL);


CREATE TABLE Lineas
	(cantidad		INT		NOT NULL,
	codigoProd		INT		NOT NULL	FOREIGN KEY REFERENCES	Productos(codigoProd),
	subtotal		DECIMAL(18, 2)		NOT NULL,
	impuesto		DECIMAL(18, 2)		NOT NULL,
	idDocumento		INT		NOT NULL	FOREIGN KEY REFERENCES	Documentos(idDocumento));

ALTER TABLE Lineas
ADD CONSTRAINT PK_Lineas PRIMARY KEY (codigoProd,idDocumento);

ALTER TABLE Documentos
ADD idNotaCredito INT NULL;

-- Inserts de información

INSERT INTO Roles
VALUES	(1,'Administrador'),
		(2,'Cajero'),
		(3,'Administrador de Inventario'),
		(4, 'Contador');

INSERT INTO Consecutivos
VALUES	(1, 0),
		(2, 0),
		(3,	0);


-- SP de usos
GO

CREATE PROCEDURE VerificarCredenciales
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

GO

CREATE PROCEDURE EliminarPersonal
    @idTrabajador INT -- Cambiarlo luego por cedula?
AS
BEGIN
    DELETE FROM Personal WHERE idTrabajador = @idTrabajador;
END











-- ELIMINAR ESTOS INSERTS AL FINAL

SELECT *
FROM Personal
INSERT INTO Personal 
VALUES 
    (1, '1990-05-15', 'Juan', 'Pérez', 'González', 'Calle Principal 123', '1', '1', 123456789, 'M', 1, 1),
    (2, '1990-05-15', 'Juan', 'Pérez', 'González', 'Calle Principal 123', 'jozperez@gmail.com', '1234', 123456789, 'M', 1, 1),
    (3, '1995-08-20', 'María', 'López', 'García', 'Avenida Central 456', 'maria.lopez@email.com', '1234', 987654321, 'F', 2, 1),
    (4, '1988-12-10', 'Pedro', 'Martínez', 'Hernández', 'Calle Secundaria 789', 'jozafatperezfer@gmail.com', '1234', 555555555, 'M', 3, 1),
    (5, '1987-04-25', 'Ana', 'Gómez', 'Fernández', 'Paseo Peatonal 234', 'ana.gomez@email.com', '1234', 111111111, 'F', 4, 1);

INSERT INTO Personal 
VALUES 
(6, '1990-05-15', 'Juan', 'Pérez', 'González', 'Calle Principal 123', '1', '1', 123456789, 'Masculino', 1, 1);

INSERT INTO Productos (codigoProd, nombre, categoria, tipoMedida, cantidadInv, precioUnit) VALUES
(1, 'Leche Entera', 'Lácteos', 'Litros', 50, 1.50),
(2, 'Pan Integral', 'Panadería', 'Unidades', 100, 0.80),
(3, 'Jugo de Naranja', 'Bebidas', 'Litros', 75, 2.00),
(4, 'Arroz Blanco', 'Granos', 'Kilos', 200, 1.20),
(5, 'Manzanas', 'Frutas', 'Kilos', 150, 1.75),
(6, 'Pollo Entero', 'Carnes', 'Kilos', 30, 5.00),
(7, 'Detergente Líquido', 'Limpieza', 'Litros', 60, 3.50),
(8, 'Leche de Avena', 'Lácteos', 'Unidad', 100, 2.99),
(31, 'Avena', 'Cereales', 'Paquete', 50, 4.99),
(32, 'Galleta Avena y fresa', 'Snacks', 'Paquete', 80, 3.49),
(33, 'Helado de Avena y miel', 'Helados', 'Unidad', 120, 1.99);


--#####################################################################


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


-- Crear las líneas de productos

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

GO

CREATE PROC Top_Producto
AS
BEGIN
	SELECT TOP 1  P.codigoProd 'Código', P.nombre Nombre, P.categoria 'Categoría', SUM(L.cantidad) 'Total Vendido'
	FROM Lineas L
	INNER JOIN Productos P on
	L.codigoProd = P.codigoProd
	GROUP BY P.codigoProd, P.nombre, P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

GO

CREATE PROC Prod_Vendidos_30_Dias
AS
BEGIN
	DECLARE @FechaActual DATE = GETDATE();
	DECLARE @FechaInicio DATE = DATEADD(DAY, -30, @FechaActual);

	SELECT P.codigoProd 'Código', P.nombre Nombre, P.categoria 'Categoría', SUM(L.cantidad) 'Total Vendido'
	FROM Documentos D
	INNER JOIN Lineas L ON
	D.idDocumento = L.idDocumento
	INNER JOIN Productos P ON
	P.codigoProd = L.codigoProd
	WHERE D.fechaCreacion >= @FechaInicio
	GROUP BY P.codigoProd, P.nombre, P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

GO

CREATE PROC Top_5_Clientes
AS
BEGIN
    SELECT TOP 5 D.idCliente 'Cédula', COUNT(D.idDocumento) 'Cantidad de Documentos'
    FROM Documentos D
    WHERE D.idCliente IS NOT NULL
    GROUP BY D.idCliente
    ORDER BY COUNT(D.idDocumento) DESC;
END;

GO

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
        D.idCliente		'Cédula del Cliente',
        D.idTrabajador	'Cédula del Trabajador',
        D.totalImpuestos 'Total Impuestos',
        D.subtotal		'SubTotal'
    FROM
        Documentos D
    WHERE
        D.fechaCreacion BETWEEN @fechaInicial AND @fechaFinal
    ORDER BY
        D.fechaCreacion;
END;

GO

CREATE PROC Top_Categorias_Vendidas
AS
BEGIN
	SELECT TOP 5 P.categoria 'Categoría', SUM(L.cantidad) 'Total Vendido'
	FROM Lineas L
	INNER JOIN Productos P ON
	L.codigoProd = P.codigoProd
	GROUP BY P.categoria
	ORDER BY SUM(L.cantidad) DESC;
END;

GO

CREATE PROC Cajeros_Mas_Ventas
AS
BEGIN
	SELECT TOP 5 P.idTrabajador 'Cédula', CONCAT(P.apellidoPat, ' ', P.apellidoPat, ' ', P.nombre) 'Nombre Completo', COUNT(D.idDocumento) 'Total Facturas'
	FROM Documentos D
	INNER JOIN Personal P ON
	D.idTrabajador = P.idTrabajador
	GROUP BY P.idTrabajador, P.apellidoPat, P.apellidoMat, P.nombre;
END;

GO

CREATE PROC Fechas_Mas_Compras
AS
BEGIN
	SET LANGUAGE Spanish;
	SELECT TOP 5 DATENAME(DW, D.fechaCreacion) 'Día', COUNT(D.idDocumento) 'Total Facturas'
	FROM Documentos D
	GROUP BY DATENAME(DW, D.fechaCreacion)
	ORDER BY COUNT(D.idDocumento) DESC;
	SET LANGUAGE English;
END;

GO

CREATE PROC Cajero_Del_Mes
AS
BEGIN
    DECLARE @FechaActual DATE = GETDATE();
    DECLARE @MesAnterior INT = MONTH(DATEADD(MONTH, -1, @FechaActual));
    DECLARE @AnioMesAnterior INT = YEAR(DATEADD(MONTH, -1, @FechaActual));

    SELECT TOP 1
        P.idTrabajador AS 'Cédula',
        CONCAT(P.apellidoPat, ' ', P.apellidoMat, ' ', P.nombre) AS 'Nombre Completo',
        COUNT(D.idDocumento) AS 'Total Facturas'
    FROM
        Documentos D
    INNER JOIN Personal P ON 
	D.idTrabajador = P.idTrabajador
    WHERE MONTH(D.fechaCreacion) = @MesAnterior AND YEAR(D.fechaCreacion) = @AnioMesAnterior
    GROUP BY P.idTrabajador, P.apellidoPat, P.apellidoMat, P.nombre
    ORDER BY COUNT(D.idDocumento) DESC;
END;

GO

CREATE PROC Buscar_Documento 
(@idDocumento INT)
AS
BEGIN
(SELECT idDocumento,
       tipo,
       fechaCreacion,
       consecutivo,
       idCliente,
       idTrabajador,
       totalImpuestos,
       subtotal
FROM Documentos D
WHERE D.idDocumento = @idDocumento);
END;

GO

CREATE PROC Buscar_Lineas_Documento
(@idDocumento INT)
AS
BEGIN
	SELECT cantidad,
		codigoProd,
		subtotal,
		impuesto
	FROM Lineas L
	WHERE L.idDocumento = @idDocumento;
END;

GO

CREATE PROC Buscar_Producto 
(@codigoProd INT)
AS
BEGIN
SELECT
	codigoProd,
	nombre,
	categoria,
	tipoMedida,
	cantidadInv
	precioUnit
FROM Productos
WHERE codigoProd = @codigoProd;
END;

GO

CREATE PROC Get_Nombre_Trabajador 
(@idTrabajador INT)
AS
BEGIN
SELECT
	CONCAT(nombre,' ', apellidoPat,' ', apellidoMat)
FROM Personal
WHERE idTrabajador = @idTrabajador;
END;

DROP PROC Fechas_Mas_Compras
DROP PROC Cajeros_Mas_Ventas
DROP PROC Top_Categorias_Vendidas
DROP PROC Facturas_Por_Rango_Fechas
DROP PROC Top_5_Clientes
DROP PROC Prod_Vendido_30_Dias
DROP PROC Top_Producto



EXEC Top_Producto
EXEC Prod_Vendidos_30_Dias
EXEC Top_5_Clientes
EXEC Facturas_Por_Rango_Fechas '2024-04-01', '2024-04-20';

EXEC Cajero_Del_Mes
EXEC Top_Categorias_Vendidas
EXEC Cajeros_Mas_Ventas
EXEC Fechas_Mas_Compras

--SP para Documentos

GO

CREATE PROCEDURE ObtenerConsecutivo
    @TipoDocumento INT,
    @Consecutivo INT OUTPUT
AS
BEGIN
    SELECT @Consecutivo = consecutivo FROM Consecutivos WHERE tipo = @TipoDocumento;
END

GO

CREATE PROCEDURE ActualizarConsecutivo
    @TipoDocumento INT
AS
BEGIN
    UPDATE Consecutivos SET consecutivo = consecutivo + 1 WHERE tipo = @TipoDocumento;
END

GO

CREATE PROCEDURE InsertarDocumento
    @TipoDocumento INT,
    @FechaCreacion DATETIME,
    @Consecutivo INT,
    @IdCliente NVARCHAR(50),
    @IdTrabajador INT,
    @TotalImpuestos DECIMAL(18, 2),
    @Subtotal DECIMAL(18, 2),
    @IdDocumento INT OUTPUT
AS
BEGIN
    INSERT INTO Documentos (tipo, fechaCreacion, consecutivo, idCliente, idTrabajador, totalImpuestos, subtotal)
    VALUES (@TipoDocumento, @FechaCreacion, @Consecutivo, @IdCliente, @IdTrabajador, @TotalImpuestos, @Subtotal);
    
    SET @IdDocumento = SCOPE_IDENTITY();
END

GO

CREATE PROCEDURE InsertarLinea
    @Cantidad INT,
    @CodigoProd INT,
    @Subtotal DECIMAL(18, 2),
    @Impuesto DECIMAL(18, 2),
    @IdDocumento INT
AS
BEGIN
    INSERT INTO Lineas (cantidad, codigoProd, subtotal, impuesto, idDocumento)
    VALUES (@Cantidad, @CodigoProd, @Subtotal, @Impuesto, @IdDocumento);
END

GO

CREATE PROCEDURE ActualizarCantidadProducto
    @Cantidad INT,
    @CodigoProd INT
AS
BEGIN
    UPDATE Productos SET cantidadInv = cantidadInv - @Cantidad WHERE codigoProd = @CodigoProd;
END

GO

CREATE PROCEDURE VerificarProducto
    @CodigoProd INT,
    @ProductoExiste INT OUTPUT
AS
BEGIN
    SELECT @ProductoExiste = COUNT(*) FROM Productos WHERE codigoProd = @CodigoProd;
END

GO

CREATE PROCEDURE ActualizarCantidadProductoAnulacion
    @Cantidad INT,
    @CodigoProd INT
AS
BEGIN
    UPDATE Productos SET cantidadInv = cantidadInv + @Cantidad WHERE codigoProd = @CodigoProd;
END