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
	nombre			VARCHAR(150)	NOT NULL,
	categoria		VARCHAR(150)	NOT NULL,
	nombreProveedor	VARCHAR(150)	NOT NULL,
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
VALUES	(1,
		'Administrador');

INSERT INTO Personal
VALUES	(1,
		'2004-09-09',
		'User',
		'User',
		'User',
		'Limón',
		'email',
		'1234',
		'88888888',
		'M',
		1,
		1);

SELECT * FROM Personal