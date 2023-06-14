Go
Create table Rol(

	IDRol int identity(1, 1) not null primary key,
	Nombre varchar(35) not null,
	Descripcion nvarchar(max) null

)

Go
Create table Usuario(

	IDUsuario int identity(1, 1) not null primary key,
	IDRol int not null foreign key references Rol(IDRol),
	PrimerNombre nvarchar(50) not null,
	PrimerApellido nvarchar(50) not null,
	NombreUsuario varchar(35) not null,
	Contraseña nvarchar(35) not null

)

Go
Create table Ventana(

	IDVentana int not null identity(1, 1) primary key,
	IDVentanaDependencia int null foreign key references Ventana(IDVentana),
	Nombre varchar(50) not null,
	Descripcion nvarchar(max) null

)

Go
Create table TipoPermiso(

	IDTipoPermiso int not null identity(1,1) primary key,
	Nombre varchar(35) not null

)

Go
Create table RolVentana(

	IDRol int not null foreign key references Rol(IDRol),
	IDVentana int not null foreign key references Ventana(IDVentana),
	IDTipoPermiso int not null foreign key references TipoPermiso(IDTipoPermiso),
	Descripcion nvarchar(max),

	Constraint FK_RolVentana primary key(IDRol, IDVentana, IDTipoPermiso)

)

Go
Create table Cliente(

	DNI varchar(50) not null primary key,
	PrimerNombre nvarchar(50) not null,
	PrimerApellido nvarchar(50) not null

)

Go
Create table Factura(

	[No.Factura] varchar(35) not null primary key,
	DNI varchar(50) not null foreign key references Cliente(DNI),
	Fecha date not null,
	Total numeric(11, 2) not null,
	IDUsuarioRegistro int not null foreign key references Usuario(IDUsuario)

)

Go
Create table EstanteFarmacia(

	IDEstanteFarmacia int not null primary key,
	Nombre varchar(35) not null,
	Descripcion nvarchar(max)

)

Go
Create table Proveedor(

	IDProveedor int not null identity(1, 1) primary key,
	Nombre varchar(35) not null

)

Go
Create table Producto(

	IDProducto int not null identity(1,1) primary key,
	Nombre varchar(50) not null,
	Descripcion varchar(max),
	CantidadEnEstante int not null,
	Precio numeric(11,2) not null,
	Foto image null,
	IDProveedor int not null foreign key references Proveedor(IDProveedor),
	IDEstanteFarmacia int not null foreign key references
		EstanteFarmacia(IDEstanteFarmacia),

	IDUsuarioRegistro int not null foreign key references Usuario(IDUsuario)

)

Go
Create table DetalleFactura(

	IDDetalleFactura int not null identity(1,1) primary key,
	[No.Factura] varchar(35) not null foreign key references
		Factura([No.Factura]),

	IDProducto int not null foreign key references Producto(IDProducto),
	Cantidad int not null,
	TotalItem numeric(11,2) not null

)

Go
Create table Bodega(

	IDBodega int not null identity(1, 1) primary key,
	Nombre varchar(50) not null,
	Ubicacion varchar(50) not null

)

Go
Create table Metodo(

	IDMetodo int not null identity(1, 1) primary key,
	Nombre varchar(50) not null,
	Descripcion nvarchar(max)

)

Go
Create table TipoMovimientoKardex(

	IDTipoMovimientoKardex int not null identity(1, 1) primary key,
	Nombre varchar(50) not null,
	Descripcion nvarchar(max)

)

Go
Create table Kardex(

	IDKardex int not null identity(1, 1) primary key,
	CantidadMax int not null,
	CantidadMin int not null,
	IDProducto int not null foreign key references Producto(
		IDProducto),

	IDBodega int not null foreign key references Bodega(
		IDBodega),

	IDMetodo int not null foreign key references Metodo(
		IDMetodo)

)

Go
Create table DetalleKardex(

	IDDetalleKardex int not null identity(1, 1) primary key,
	IDKardex int not null foreign key references Kardex(IDKardex),
	Fecha date not null,
	Concepto varchar(100),
	[No.Documento] varchar(35) not null

)

Go 
Create table MovimientoKardex(

	IDMovimientoKardex int not null identity(1, 1) primary key,
	IDDetalleKardex int not null foreign key references DetalleKardex(
		IDDetalleKardex),

	IDTipoMovimientoKardex int not null foreign key references
		TipoMovimientoKardex(IDTipoMovimientoKardex),

	Cantidad int not null,
	PrecioUnitario numeric(11, 2) not null,
	PrecioTotal numeric(11, 2) not null
	
)