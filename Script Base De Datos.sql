CREATE DATABASE ERP
GO
USE ERP
GO

CREATE TABLE Departamento (
	Codigo VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	PRIMARY KEY(Codigo)
)

CREATE TABLE Planilla (
	CodigoPlanilla VARCHAR(15) NOT NULL,
	HorasMensuales INT NOT NULL,
	HorasLaboradas INT,
	Salario FLOAT NOT NULL,
	HorasExtra INT,
	PRIMARY KEY(CodigoPlanilla)
)

CREATE TABLE Puesto (
	Nombre VARCHAR(20) NOT NULL,
	Salario FLOAT NOT NULL,
	TipoPuesto VARCHAR(20) NOT NULL,
	PRIMARY KEY (Nombre)
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
	FOREIGN KEY (CodigoDepartamento) REFERENCES Departamento(Codigo),
	FOREIGN KEY (CodigoPlanilla) REFERENCES Planilla(CodigoPlanilla),
	FOREIGN KEY (Puesto) REFERENCES Puesto(Nombre)
)

CREATE TABLE Historicos (
	CodigoDepartamento VARCHAR(15) NOT NULL,
	CedulaEmpleado VARCHAR(9) NOT NULL,
	FechaInicio DATE NOT NULL,
	FechaFinal DATE NOT NULL,
	Monto FLOAT NOT NULL,
	PRIMARY KEY (CodigoDepartamento, CedulaEmpleado),
	FOREIGN KEY (CodigoDepartamento) REFERENCES Departamento(Codigo),
	FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula)
)

CREATE TABLE Bodega (
	Codigo VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Ubicacion VARCHAR(20) NOT NULL,
	EspacioCubico SMALLINT NOT NULL,
	CapacidadTon SMALLINT NOT NULL,
	PRIMARY KEY (Codigo)
)

CREATE TABLE TelefonosLocal (
    CodigoBodega VARCHAR(15) NOT NULL,
    NumTelefono VARCHAR(8) NOT NULL,
    PRIMARY KEY (CodigoBodega, NumTelefono),
	FOREIGN KEY (CodigoBodega) REFERENCES Bodega(Codigo)
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
	CodigoFamilia VARCHAR(15) UNIQUE NOT NULL,
	Codigo VARCHAR(15) NOT NULL,
	Nombre VARCHAR(20) NOT NULL,
	Peso FLOAT NOT NULL,
	Descripcion VARCHAR(200),
	Activo TINYINT NOT NULL,
	PRIMARY KEY (Codigo)
)

CREATE TABLE Zona (
	Nombre VARCHAR(20) UNIQUE NOT NULL,
	TamanoKmCuadrado INT NOT NULL,
	Descripcion VARCHAR(200),
	PRIMARY KEY (Nombre)
)

CREATE TABLE Sector (
	Nombre VARCHAR(20) UNIQUE NOT NULL,
	Descripcion VARCHAR(200),
	ValorMercado FLOAT,
	IngresosAnuales FLOAT,
	PRIMARY KEY (Nombre)
)

CREATE TABLE Cliente (
    Cedula VARCHAR(9) NOT NULL,
    Telefono VARCHAR(8) NOT NULL,
    Genero TINYINT NOT NULL,
    Nombre VARCHAR(20) NOT NULL,
    CorreoElectronico VARCHAR(20) NOT NULL,
    Fax VARCHAR(20),
	Celular VARCHAR(8) NOT NULL,
	PRIMARY KEY (Cedula)
)

CREATE TABLE ListaArticulos (
	CodigoBodega VARCHAR(15) UNIQUE NOT NULL,
	Codigo VARCHAR(15),
	CodigoProducto VARCHAR(15) UNIQUE NOT NULL,
	CantidadProducto INT UNIQUE NOT NULL,
	PRIMARY KEY (Codigo),
	FOREIGN KEY (CodigoBodega) REFERENCES Bodega(Codigo),
	FOREIGN KEY (CodigoProducto) REFERENCES Articulo(Codigo),
)


CREATE TABLE Cotizacion (
	Codigo VARCHAR(15) NOT NULL,
	CedulaCliente VARCHAR(9) UNIQUE NOT NULL,
	CedulaEmpleado VARCHAR(9) UNIQUE NOT NULL,
	OrdenDeCompra VARCHAR(20) NOT NULL,
	FechaCotizacion DATE NOT NULL,
	MesProyectadoCierre DATE NOT NULL,
	CierreFinal DATE NOT NULL,
	TipoCotizacion VARCHAR(20) NOT NULL,
	Estado VARCHAR(20) NOT NULL,
	Probabilidad FLOAT,
	PRIMARY KEY(Codigo),
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
    Codigo VARCHAR(15) NOT NULL,
	CodigoCotizacion VARCHAR(15) UNIQUE NOT NULL,
    CedulaCliente VARCHAR(9) UNIQUE NOT NULL,
    CedulaEmpleado VARCHAR(9) UNIQUE NOT NULL,
    CedulaJuridica VARCHAR(9) NOT NULL,
    TelefonoLocal VARCHAR(8) NOT NULL,
    NombreLocal VARCHAR(20) NOT NULL,
    FechaFactura DATE,
	PRIMARY KEY (Codigo),
    FOREIGN KEY (CedulaCliente) REFERENCES Cliente(Cedula),
    FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula),
	FOREIGN KEY (CodigoCotizacion) REFERENCES Cotizacion(Codigo),
)

CREATE TABLE Caso (
    CodigoCaso VARCHAR(15) NOT NULL,
    CedulaPropietario VARCHAR(9) UNIQUE NOT NULL,
    NombreCuenta VARCHAR(20) NOT NULL,
    TipoCaso VARCHAR(20) NOT NULL,
    Asunto VARCHAR(200) NOT NULL,
    NombreContacto VARCHAR(20) NOT NULL,
    Descripcion VARCHAR(200),
    Ubicacion VARCHAR(200) NOT NULL,
    Prioridad TINYINT NOT NULL,
	PRIMARY KEY (CodigoCaso,CedulaPropietario),
    FOREIGN KEY (CedulaPropietario) REFERENCES Empleado(Cedula)
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
	Codigo VARCHAR(15) NOT NULL,
    CodigoFactura VARCHAR(15) UNIQUE NOT NULL,
    CedulaEmpleado VARCHAR(9) UNIQUE NOT NULL,
    BodegaOrigen VARCHAR(15) UNIQUE NOT NULL,
    BodegaDestino VARCHAR(15) UNIQUE NOT NULL,
    CantidadArticulo INT NOT NULL,
    FechaHora DATE NOT NULL,
    TipoMovimiento VARCHAR(20) NOT NULL,
	PRIMARY KEY (Codigo),
    FOREIGN KEY (CodigoFactura) REFERENCES Factura(Codigo),
    FOREIGN KEY (CedulaEmpleado) REFERENCES Empleado(Cedula),
    FOREIGN KEY (BodegaOrigen) REFERENCES Bodega(Codigo),
	FOREIGN KEY (BodegaDestino) REFERENCES Bodega(Codigo)
)

CREATE TABLE ListaMovimiento (
	CodigoLista VARCHAR(15) NOT NULL,
	CodigoMovimiento VARCHAR(15) NOT NULL,
	PRIMARY KEY (CodigoLista,CodigoMovimiento),
	FOREIGN KEY (CodigoLista) REFERENCES ListaArticulos(Codigo),
	FOREIGN KEY (CodigoMovimiento) REFERENCES Movimiento(Codigo),
)

CREATE TABLE ListaFactura (
	CodigoLista VARCHAR(15) NOT NULL,
	CodigoFactura VARCHAR(15) NOT NULL,
	PRIMARY KEY (CodigoLista,CodigoFactura),
	FOREIGN KEY (CodigoLista) REFERENCES ListaArticulos(Codigo),
	FOREIGN KEY (CodigoFactura) REFERENCES Factura(Codigo),
)

CREATE TABLE ListaCotizacion (
	CodigoLista VARCHAR(15) NOT NULL,
	CodigoCotizacion VARCHAR(15) NOT NULL,
	PRIMARY KEY (CodigoLista,CodigoCotizacion),
	FOREIGN KEY (CodigoLista) REFERENCES ListaArticulos(Codigo),
	FOREIGN KEY (CodigoCotizacion) REFERENCES Cotizacion(Codigo),
)

