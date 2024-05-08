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

CREATE TABLE Documentos
	(tipo			INT		NOT NULL,
	fechaCreacion	DATE	NOT NULL,
	idCliente		INT		NOT NULL	FOREIGN KEY REFERENCES Clientes(idCliente),
	consecutivo		INT		NOT NULL,
	idTrabajador	INT		NOT NULL	FOREIGN KEY REFERENCES Personal(idTrabajador),
	totalImpuestos	INT		NOT NULL,
	subtotal		INT		NOT NULL
	CONSTRAINT		PK_DOCUMENTO	PRIMARY KEY (tipo,consecutivo));

CREATE TABLE Lineas
	(cantidad		INT		NOT NULL,
	codigoProd		INT		NOT NULL	FOREIGN KEY REFERENCES	Productos(codigoProd),
	subtotal		INT		NOT NULL,
	impuesto		INT		NOT NULL,
	tipo			INT		NOT NULL,
	consecutivo		INT		NOT NULL,
	CONSTRAINT		FK_DOCUMENTO	FOREIGN KEY (tipo,consecutivo) REFERENCES Documentos(tipo,consecutivo));
