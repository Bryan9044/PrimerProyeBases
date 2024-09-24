CREATE DATABASE ERP
GO
USE ERP
GO

CREATE TABLE Departamento (
	CodigoDepartamento VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	PRIMARY KEY(CodigoDepartamento)
)

CREATE TABLE Planilla (
	CodigoPlanilla VARCHAR(15) NOT NULL,
	HorasMensuales INT NOT NULL,
	HorasLaboradas INT,
	Salario FLOAT NOT NULL,
	HorasExtra INT,
	PRIMARY KEY(CodigoPlanilla)
)

CREATE TABLE Empleado (
	Cedula VARCHAR(9) NOT NULL,
	CodigoDepartamento VARCHAR(15) NOT NULL,
	CodigoPlanilla VARCHAR(15) NOT NULL,
	FechaIngreso DATE NOT NULL,
	Genero TINYINT NOT NULL,
	Edad SMALLINT NOT NULL,
	Puesto VARCHAR(20) NOT NULL,
	PRIMARY KEY(Cedula),
	FOREIGN KEY (CodigoDepartamento) REFERENCES Departamento(CodigoDepartamento),
	FOREIGN KEY (CodigoPlanilla) REFERENCES Planilla(CodigoPlanilla)
)

CREATE TABLE Historicos (
	CodigoDepartamento VARCHAR(15) NOT NULL,
	Cedula VARCHAR(9) NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFinal DATE NOT NULL,
	Monto FLOAT NOT NULL,
	PRIMARY KEY (CodigoDepartamento, Cedula),
	FOREIGN KEY (CodigoDepartamento) REFERENCES Departamento(CodigoDepartamento),
	FOREIGN KEY (Cedula) REFERENCES Empleado(Cedula)
)

CREATE TABLE Bodega (
	CodigoBodega VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Ubicacion VARCHAR(20) NOT NULL,
	EspacioCubico SMALLINT NOT NULL,
	CapacidadTon SMALLINT NOT NULL,
	PRIMARY KEY (CodigoBodega)
)

CREATE TABLE Familia (
	CodigoFamilia VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Descripcion VARCHAR(200),
	Activo TINYINT NOT NULL,
	PRIMARY KEY(CodigoFamilia)
)

CREATE TABLE FamiliaBodega (
	CodigoBodega VARCHAR(15) NOT NULL,
	CodigoFamilia VARCHAR(15) NOT NULL,
	PRIMARY KEY (CodigoBodega,CodigoFamilia)
)

CREATE TABLE Articulo (
	CodigoFamilia VARCHAR(15) NOT NULL,
	CodigoArticulo VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Peso FLOAT NOT NULL,
	Descripcion VARCHAR(200),
	Activo TINYINT NOT NULL,
	PRIMARY KEY (CodigoFamilia,CodigoArticulo)
)

CREATE TABLE Zona (
	Nombre VARCHAR(20) UNIQUE NOT NULL,
	Origen VARCHAR(15) NOT NULL,
	Descripcion VARCHAR(200),
	PRIMARY KEY (Nombre)
)

CREATE TABLE Sector (
	Nombre VARCHAR(20) UNIQUE NOT NULL,
	Origen VARCHAR(15) NOT NULL,
	Descripcion VARCHAR(200),
	PRIMARY KEY (Nombre)
)

CREATE TABLE Cliente (
    Cedula VARCHAR(9) NOT NULL,
    Zona VARCHAR(20) UNIQUE NOT NULL,
    Sector VARCHAR(20) UNIQUE NOT NULL,
    Telefono VARCHAR(8) NOT NULL,
    Genero TINYINT NOT NULL,
    Nombre VARCHAR(20) NOT NULL,
    CorreoElectronico VARCHAR(20) NOT NULL,
    Fax VARCHAR(20),
	PRIMARY KEY (Cedula),
	FOREIGN KEY (Zona) REFERENCES Zona(Nombre),
	FOREIGN KEY (Sector) REFERENCES Sector(Nombre)
)

CREATE TABLE Cotizacion (
	Codigo VARCHAR(15) UNIQUE NOT NULL,
	CedulaCliente VARCHAR(9) NOT NULL,
	CedulaEmpleado VARCHAR(9) NOT NULL,
	OrdenDeCompra VARCHAR(20) NOT NULL,
	FechaCotizacion DATE NOT NULL,
	MesProyectadoCierre DATE NOT NULL,
	CierreFinal DATE NOT NULL,
	TipoCotizacion VARCHAR(20) NOT NULL,
	Estado VARCHAR(20) NOT NULL,
	Probabilidad FLOAT,
	PRIMARY KEY(CedulaCliente,CedulaEmpleado),
	FOREIGN KEY (CedulaCliente) REFERENCES Cliente(Cedula),
	FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula)
)

CREATE TABLE ZonaCliente (
	NombreZona VARCHAR(20) NOT NULL,
	CedulaCliente VARCHAR(9) NOT NULL,
	PRIMARY KEY (NombreZona,CedulaCliente),
	FOREIGN KEY (NombreZona) REFERENCES Zona(Nombre),
	FOREIGN KEY (CedulaCliente) REFERENCES Cliente(Cedula)
)

CREATE TABLE ZonaCotizacion (
	NombreZona VARCHAR(20) NOT NULL,
	CodigoCotizacion VARCHAR(15) NOT NULL,
	PRIMARY KEY (NombreZona,CodigoCotizacion),
	FOREIGN KEY (NombreZona) REFERENCES Zona(Nombre),
	FOREIGN KEY (CodigoCotizacion) REFERENCES Cotizacion(Codigo)
)

CREATE TABLE SectorCliente (
	NombreZona VARCHAR(20) NOT NULL,
	CedulaCliente VARCHAR(9) NOT NULL,
	PRIMARY KEY (NombreZona,CedulaCliente),
	FOREIGN KEY (NombreZona) REFERENCES Sector(Nombre),
	FOREIGN KEY (CedulaCliente) REFERENCES Cliente(Cedula)
)

CREATE TABLE SectorCotizacion (
	NombreSector VARCHAR(20) NOT NULL,
	CodigoCotizacion VARCHAR(15) NOT NULL,
	PRIMARY KEY (NombreSector,CodigoCotizacion),
	FOREIGN KEY (NombreSector) REFERENCES Sector(Nombre),
	FOREIGN KEY (CodigoCotizacion) REFERENCES Cotizacion(Codigo)
)

CREATE TABLE Factura (
    CodigoFactura VARCHAR(15) UNIQUE NOT NULL,
	CodigoCotizacion VARCHAR(15),
    CodigoCliente VARCHAR(9) NOT NULL,
    CodigoEmpleado VARCHAR(9) NOT NULL,
    CedulaJuridica VARCHAR(9) NOT NULL,
    TelefonoLocal VARCHAR(8) NOT NULL,
    NombreLocal VARCHAR(20) NOT NULL,
    FechaFactura DATE,
	PRIMARY KEY (CodigoCliente,CodigoEmpleado,CodigoCotizacion),
    FOREIGN KEY (CodigoCliente) REFERENCES Cliente(Cedula),
    FOREIGN KEY (CodigoEmpleado) REFERENCES Empleado(Cedula),
	FOREIGN KEY (CodigoCotizacion) REFERENCES Cotizacion(Codigo),
)

CREATE TABLE Caso (
    CodigoCaso VARCHAR(15) NOT NULL,
    CodigoPropietario VARCHAR(9) UNIQUE NOT NULL,
    NombreCuenta VARCHAR(20) NOT NULL,
    TipoCaso VARCHAR(20) NOT NULL,
    Asunto VARCHAR(200) NOT NULL,
    NombreContacto VARCHAR(20) NOT NULL,
    Descripcion VARCHAR(200),
    Ubicacion VARCHAR(200) NOT NULL,
    Prioridad TINYINT NOT NULL,
	PRIMARY KEY (CodigoCaso,CodigoPropietario),
    FOREIGN KEY (CodigoPropietario) REFERENCES Empleado(Cedula)
)

CREATE TABLE Tarea (
    CodigoTarea VARCHAR(15) NOT NULL,
    CodigoEmpleado VARCHAR(9) NOT NULL,
    Fecha DATE NOT NULL,
    Descripcion VARCHAR(200) NOT NULL,
    Estado VARCHAR(20) NOT NULL,
	PRIMARY KEY (CodigoTarea,CodigoEmpleado),
    FOREIGN KEY (CodigoEmpleado) REFERENCES Empleado(Cedula)
)

CREATE TABLE Movimiento (
    CodigoFactura VARCHAR(15),
    CodigoCliente VARCHAR(9),
    BodegaOrigen VARCHAR(15),
    BodegaDestino VARCHAR(15),
    CantidadArticulo INT,
    FechaHora DATE,
    TipoMovimiento VARCHAR(20),
	PRIMARY KEY (CodigoFactura,CodigoCliente,BodegaOrigen,BodegaDestino),
    FOREIGN KEY (CodigoFactura) REFERENCES Factura(CodigoFactura),
    FOREIGN KEY (CodigoCliente) REFERENCES Cliente(Cedula),
    FOREIGN KEY (BodegaOrigen) REFERENCES Bodega(CodigoBodega),
	FOREIGN KEY (BodegaDestino) REFERENCES Bodega(CodigoBodega)
)

CREATE TABLE TelefonosLocal (
    CodigoSector VARCHAR(20),
    NumTelefono VARCHAR(8),
    PRIMARY KEY (CodigoSector, NumTelefono)
)