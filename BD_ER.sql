
drop database Finanzas
create database Finanzas

use Finanzas

create table Categoría
(
	IdCategoría int primary key identity(1,1),
	Nombre varchar(50),
	Descripción text
)

create table Empleado
(
	IdEmpleado int primary key identity(1,1),
	Nombres varchar(50),
	Apellidos varchar(50),
	Dirección varchar(100),
	Teléfono varchar(12),
	Ciudad varchar(50),
	Jefe int foreign key references Empleado(IdEmpleado)
)

create table Proveedor
(
	IdProveedor int primary key identity(1,1),
	Nombre varchar(50),
	Dirección varchar(100),
	Ciudad varchar(50),
	Teléfono varchar(12),
	Correo varchar(50)
)

create table Producto
(
	IdProducto int primary key identity(1,1),
	Nombre varchar(50),
	IdCategoría int foreign key references Categoría(IdCategoría),
	Precio_unitario money,
	Stock int,
	Descontinuado int
)

create table Compra
(
	IdCompra int primary key identity(1,1),
	IdProducto int foreign key references Producto(IdProducto),
	IdProveedor int foreign key references Proveedor(IdProveedor),
	IdEmpleado int foreign key references Empleado(IdEmpleado),
	Fecha date
)

create table Detalle_Compra
(
	IdDetalleCompra int primary key identity(1,1),
	IdCompra int foreign key  references Compra(IdCompra),	
	Precio money,
	cantidad int,
	Forma_pago varchar(50),
	Moneda varchar(50),
	Descripción text
)

create table Cliente
(
	IdCliente int primary key identity(1,1),
	Nombres varchar(50),
	Apellidos varchar(50),
	Teléfono varchar(12),
	Dirección varchar(100),
	Ciudad varchar(50)
)

create table Venta
(
	IdVenta int primary key identity(1,1),
	IdCliente int foreign key references Cliente(IdCliente),
	IdEmpleado int foreign key references Empleado(IdEmpleado),
	Fecha_Orden date,
	Fecha_Llegada date,
	Ciudad varchar(50)
)

create table Detalle_venta
(
	IdDetalleVenta int primary key identity(1,1),
	IdProducto int foreign key references Producto(IdProducto),
	IdVenta int foreign  key references Venta(IdVenta),
	PrecioUnitario money,
	Cantidad int,
	Descuento float,
	Descripción text,
	Moneda varchar(50)
)
go


Create table Usuario
(
	IdUsuario int primary key identity(1,1),
	IdEmpleado int foreign key references Empleado(IdEmpleado) null,
	Nombre_Usuario varchar(50),
	Contraseña varchar(100),
	Rol varchar(50)
)
go

--Creacion de los estados financieros

create table CategoríaCuenta
(
	IdCategoríaCuenta int primary key identity(1,1),
	Nombre varchar(20)
)

create table SubCategoríaCuenta
(
	IdSubCategoríaCuenta int primary key identity(1,1),
	IdCategoríaCuenta int foreign key references CategoríaCuenta(IdCategoríaCuenta),
	SubNombre varchar(20) 
)

Create table Cuenta
(
	IdCuenta int primary key identity(1,1),
	IdSubCategoríaCuenta int foreign key references SubCategoríaCuenta(IdSubCategoríaCuenta),
	NombreCuenta varchar(100)
)

create table transacción
(
	IdTransacción int primary key identity(1,1),
	IdCuenta int foreign key references Cuenta(IdCuenta),
	Monto money,
	fecha date,
	Concepto varchar(5)
)
go

/* ---------------------------------------------------------------------------  */

/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"cATEGORIA"
*/

create procedure Insertar_Categoría
	@Nombre varchar(50),
	@Descripción text
as
insert into Categoría values(@Nombre, @Descripción)
go
	

Create procedure Mostrar_Categoría
as
select * from Categoría
go

/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"Proveedor"
*/


Create procedure Insertar_Proveedor
	@Nombre varchar(50),
	@Dirección varchar(100),
	@Ciudad varchar(50),
	@Teléfono varchar(12),
	@Correo varchar(50)
as
Insert into Proveedor values (@Nombre,@Dirección, @Ciudad, @Teléfono,@Correo)
go

Create procedure Mostar_Proveedor
as
select * from Proveedor
go

/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"CLIENTE"
*/

Create procedure Insertar_Cliente
	@Nombres varchar(50),
	@Apellidos varchar(50),
	@Teléfono varchar(12),
	@Dirección varchar(100),
	@Ciudad varchar(50)
as
Insert into Cliente values(@Nombres, @Apellidos, @Teléfono, @Dirección, @Ciudad)
go

Create procedure Mostrar_Cliente
as
select * from Cliente
go

/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"EMPLEADO"
*/

create procedure Insertar_Empleado
	@Nombres varchar(50),
	@Apellidos varchar(50),
	@Dirección varchar(100),
	@Teléfono varchar(12),
	@Ciudad varchar(50),
	@Jefe int
as
insert into Empleado values(@Nombres, @Apellidos, @Dirección, @Teléfono, @Ciudad, @Jefe)
go


create procedure Mostrar_Empleado
as
select * from Empleado
go


/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"Venta"
*/

create procedure Insertar_Venta
	@IdCliente int,
	@IdEmpleado int,
	@Fecha_Llegada date,
	@Ciudad varchar(50)
as

Insert into Venta values (@IdCliente, @IdEmpleado, GETDATE(), @Fecha_Llegada, @Ciudad)
go

/*
	IdProducto int foreign key references Producto(IdProducto),
	IdVenta int foreign  key references Venta(IdVenta),
	PrecioUnitario money,
	Cantidad int,
	Descuento float,
	Descripción text,
	Moneda varchar(50)
*/

Create procedure Insertar_DetalleVenta
	@IdProducto int,
	@IdVenta int,
	@PrecioUnitario money,
	@Cantidad int,
	@Descuento float,
	@Descripción text,
	@Moneda varchar(50)
as
Insert into Detalle_venta values(@IdProducto, @IdVenta, @PrecioUnitario, @Cantidad, @Descuento, @Descripción, @Moneda)
go


/*
	Creacion de procedimiento almacenados (Insertar, Actualizar, Mostrar, Borrar)
	"Venta"
*/

Create procedure Insertar_Compra
	@IdProducto int,
	@IdProveedor int,
	@IdEmpleado int,
	@Fecha date
as
Insert into Compra values(@IdProducto, @IdProveedor, @IdEmpleado, @Fecha)
go

Create procedure Insertar_DetalleCompra
	@IdCompra int,
	@Precio money,
	@cantidad int,
	@Forma_pago varchar(50),
	@Moneda varchar(50),
	@Descripción text
as
Insert into Detalle_Compra values(@IdCompra, @Precio, @cantidad, @Forma_pago, @Moneda, @Descripción)
go


execute Insertar_Categoría 'Construcción','Es una categoría que es para la construcción'
execute Insertar_Categoría 'Herramientas','Es una categoría que son herramientas de construcción'
execute Insertar_Categoría 'Decoración','Es una categoría que son herramienats de decoración'
execute Insertar_Categoría 'Reparación','Es una categoría que son herramientas de reparación'


Execute insertar_Empleado 'Luis Gabriel', 'González López', 'De la rocargo 5 al lago cuadra 1/2 arriba','75591715', 'Managua',null

Insert into Usuario values (1,'gabx01','1234','Jefe')
go


Create procedure Validar_Acceso
	@usuario varchar(50),
	@contraseña varchar(100),
	@rol varchar(50)
as
	select IdUsuario from Usuario where Nombre_Usuario = @usuario and Contraseña = @contraseña and Rol = @rol
go

--Execute Validar_Acceso 'gabx01', '1234', 'Jefe'

----------------------------------------

insert into CategoríaCuenta values('ACTIVO')
insert into CategoríaCuenta values('PASIVO')
insert into CategoríaCuenta values('CAPITAL')
insert into CategoríaCuenta values('INGRESOS')
insert into CategoríaCuenta values('COSTOS')
insert into CategoríaCuenta values('GASTOS')

insert into SubCategoríaCuenta values (1,'Activo Circulante')
insert into SubCategoríaCuenta values (1,'Activo Fijo ')
insert into SubCategoríaCuenta values (1,'Activo NoCirculante')
insert into SubCategoríaCuenta values (1,'Activo Diferido')
insert into SubCategoríaCuenta values (1,'Otros Activos')
insert into SubCategoríaCuenta values (2,'Pasivo CP')
insert into SubCategoríaCuenta values (2,'Pasivo LP')
insert into SubCategoríaCuenta values (2,'Otros Pasivos')

insert into SubCategoríaCuenta values (3,'Capital')
insert into SubCategoríaCuenta values (4,'Ventas')
insert into SubCategoríaCuenta values (4,'Otros Ingresos')

insert into SubCategoríaCuenta values (5,'Costos')


insert into SubCategoríaCuenta values (6,'Gastos Admon')
insert into SubCategoríaCuenta values (6,'Gastos Financieros')
insert into SubCategoríaCuenta values (6,'Gastos Venta')
insert into SubCategoríaCuenta values (6,'Gastos Operativos')
insert into SubCategoríaCuenta values (6,'Otros Gastos')

select * from SubCategoríaCuenta
/*---------------------------------------------------------------------------------*/

/*  activo circulante  */
insert into Cuenta values(1,'Caja') 
insert into Cuenta values(1,'Banco')
insert into Cuenta values(1,'Cuentas por cobrar')
insert into Cuenta values(1,'Inventario')
insert into Cuenta values(1,'Clientes')
insert into Cuenta values(1,'Publicidad')


/*activo fijo*/
insert into Cuenta values(2,'Equipo de oficina')
insert into Cuenta values(2,'Mobiliario')
insert into Cuenta values(2,'Equipo de computo')
insert into Cuenta values(2,'Vehículo')
insert into Cuenta values(2,'Terreno')
insert into Cuenta values(2,'Papelería y útiles de oficina')
insert into Cuenta values(2,'Depreciación de equipo de oficina')
insert into Cuenta values(2,'Depreciación de vehículo')

/*No circulante*/
insert into Cuenta values(3,'Bodega')

/* otros activos */
insert into Cuenta values(5,'Pago Anticipado')

/**/
insert into Cuenta values(6,'Proveedores')
insert into Cuenta values(6,'Acreedores')
insert into Cuenta values(6,'Cuentas por pagar')
insert into Cuenta values(6,'Intereses por pagar')
insert into Cuenta values(6,'Dividendos por pagar')
insert into Cuenta values(6,'IR por pagar')

insert into Cuenta values(7,'Cuenta por pagar banco')
insert into Cuenta values(7,'Prestamos por pagar largo plazo')

insert into Cuenta values(9,'Reserva legal')
insert into Cuenta values(9,'Utilidad neta del ejercicio')
insert into Cuenta values(9,'Utilidades retenidas')
insert into Cuenta values(9,'Capital social')

insert into Cuenta values(10,'Ventas')
insert into Cuenta values(10,'Devoluciones sobre venta')
insert into Cuenta values(10,'Descuento sobre venta')
insert into Cuenta values(10,'Venta de activo fijo')
insert into Cuenta values(10,'Ventas al credito')
insert into Cuenta values(10,'Ventas Netas')

insert into Cuenta values(12,'Costo de ventas')
insert into Cuenta values(12,'Compras')
insert into Cuenta values(12,'Devoluciones sobre Compras')
insert into Cuenta values(12,'Rebaja sobre compras')

insert into Cuenta values(13,'Sueldo Gerente')
insert into Cuenta values(13,'Publicidad')
insert into Cuenta values(13,'Consumo de luz')

insert into Cuenta values(14,'Intereses pagados')
insert into Cuenta values(14,'Producto Financiero')

insert into Cuenta values(15,'Sueldo empleado')
insert into Cuenta values(15,'Papelería y utiles')
insert into Cuenta values(15,'Impuesto sobre ventas')

insert into Cuenta values(16,'Operación de la empresa')

insert into Cuenta values(17,'Perdida en venta de activo fijo')
insert into Cuenta values(17,'Rentas pagadas')
insert into Cuenta values(17,'Dividendos Pagados')

--Activos corrientes

insert into Transacción values (1,44171,getdate(),'D ')
insert into Transacción values (2,44171,GETDATE(),'D')
insert into Transacción values (3,21383,GETDATE(),'D')
insert into Transacción values (4,87400,GETDATE(),'D')
insert into Transacción values (5,98350,GETDATE(),'D')
insert into Transacción values (6,20400,GETDATE(),'D')

--Activos fijos
insert into Transacción values (7,33600,GETDATE(),'D')
insert into Transacción values (8,84000,GETDATE(),'D')
insert into Transacción values (9,25200,GETDATE(),'D')
insert into Transacción values (10,126000,GETDATE(),'D')
insert into Transacción values (11,210000,GETDATE(),'D')
insert into Transacción values (12,25200,GETDATE(),'D')
insert into Transacción values (13,-1400,GETDATE(),'D')
insert into Transacción values (14,-7000,GETDATE(),'D')

--Activos no circ
insert into Transacción values (15,30000,GETDATE(),'D')

--Otros activos
insert into Transacción values (16,30000,GETDATE(),'D')

--Pasivos Corrientes

insert into Transacción values(17,58198,GETDATE(),'H')
insert into Transacción values(18,13230,GETDATE(),'H')
insert into Transacción values(19,24942,GETDATE(),'H')
insert into Transacción values(20,41175,GETDATE(),'H')
insert into Transacción values(21,5670,GETDATE(),'H')
insert into Transacción values(22,25445,GETDATE(),'H')

--Pasivos no circ

insert into Transacción values(23,69000,GETDATE(),'H')
insert into Transacción values(24,46000,GETDATE(),'H')

--Capital

insert into Transacción values(25,250000,GETDATE(),'H')
insert into Transacción values(26,61470.5,GETDATE(),'H')
insert into Transacción values(27,26344.5,GETDATE(),'H')
insert into Transacción values(28,250000,GETDATE(),'H')





go
/*  Funcion para obtener las sumas de alguna categoría de cuenta */

	CREATE FUNCTION Suma_Cuenta(@año int, @cuenta varchar(50))
	RETURNS money
	WITH EXECUTE AS CALLER
	AS
	BEGIN

	declare @suma money = 
		(select sum(t.Monto)
		from transacción t 
		inner join Cuenta c on t.IdCuenta = c.IdCuenta
		inner join SubCategoríaCuenta cs on cs.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
		where Year(t.fecha) = @año and cs.SubNombre = @cuenta)
	return @suma    
	END
	GO

/*===============================================================================================*/


/*  Procedimientos para manejo de los estados financieros */
MostrarBalanceGeneral 2020,'ACTIVO'
GO
MostrarBalanceGeneral 2020,'PASIVO'
GO
MostrarBalanceGeneral 2020,'CAPITAL'
GO



Create procedure MostrarBalanceGeneral
	@fecha int,
	@tipo varchar(10)
as
	select 
		c.IdCuenta, 
		c.NombreCuenta,
		t.Monto
	from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where Year(t.fecha) = @fecha and cc.Nombre = @tipo
go

Create procedure Total_Activo
@año int
as
select Convert(int,sum(t.Monto)) as Total_Activo  from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on sc.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where year(t.fecha) = @año and cc.Nombre = 'ACTIVO'
go

create procedure Catalogo_Cuentas
	@tipo varchar(10)
as
	select
		c.NombreCuenta
	from Cuenta c 
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where cc.Nombre = @tipo
go


/* =============================== Razones financieras  ================================*/

Create procedure Indice_solvencia
	@año int
as
	declare @Activo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Activo Circulante'))
	declare @Pasivo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Pasivo CP'))

	select (@Activo_Circulante / @Pasivo_Circulante) as Indice_solvencia
go


/*-------------------------------------------------------------------------------------*/
Create Procedure Razón_deuda
	@año int
as
	declare @activo money = (select sum(t.Monto) from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on sc.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where year(t.fecha) = @año and cc.Nombre = 'ACTIVO')

	declare @pasivo money = (select sum(t.Monto) from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on sc.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where year(t.fecha) = @año and cc.Nombre = 'PASIVO')

	select Convert(int,(@pasivo / @activo) * 100)   as Razón_deuda
go

/*  Razón pasivo vcapital  */

Create procedure Razon_PasivoCapital
	@año int
as
	declare @pasivos_totales money = (dbo.Suma_Cuenta(@año,'Pasivo LP'))
	declare @Capital_social money = (
								select t.Monto
								from Cuenta c 
								inner join transacción t on t.IdCuenta = c.IdCuenta 
								where Year(t.fecha) = @año and c.NombreCuenta = 'Capital social')
	select (@pasivos_totales / @Capital_social) as Razon_PasivoCapital
go 

Create procedure Rotación_Inventario
	@año int
as
	declare @Activo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Activo Circulante'))
	
	declare @Inventario money = (
							select t.Monto 
							from transacción t 
							inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							where Year(t.fecha) = @año and c.NombreCuenta = 'Inventario')

	declare @Pasivo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Pasivo CP'))

	select ((@Activo_Circulante - @Inventario) / @Pasivo_Circulante ) as Rotación_Inventario
go

create procedure MostrarUtilidades
@fecha int
	as
	declare @monto money = (select t.Monto from transacción t inner join Cuenta c on c.IdCuenta = t.IdCuenta where year(t.fecha) = @fecha and c.IdCuenta = 36)
	select 
		((select t.Monto from transacción t inner join Cuenta c on c.IdCuenta = t.IdCuenta where year(t.fecha) = @fecha and c.IdCuenta = 36) -
		 (select t.Monto from transacción t inner join Cuenta c on c.IdCuenta = t.IdCuenta where year(t.fecha) = @fecha and c.IdCuenta = 37)) as Utilidad_Bruta
	from transacción t 
	inner join Cuenta c on c.IdCuenta = t.IdCuenta 
	where year(t.fecha) = @fecha
go

select distinct year(fecha) as fecha from transacción

--Procedimiento almacenado con salto de fe y mas allá Analisis Horizontal
AV 2020, 'ACTIVO'
go
AV 2020, 'PASIVO'
go
AV 2020, 'CAPITAL'
go
alter procedure AV
@año int,
@tipo varchar(10)
	as
	declare @cambio int =
	(select Convert(int,sum(t.Monto)) as Total_Activo  from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on sc.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where year(t.fecha) = @año and cc.Nombre = @tipo)

	select c.NombreCuenta, t.Monto, (t.Monto/@cambio)*100 as 'VARIACIÓN %' from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on sc.IdSubCategoríaCuenta = c.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where year(t.fecha) = @año and cc.Nombre = @tipo
go

AnalisisHorizontal 2020,2019,'ACTIVO'
GO
AnalisisHorizontal 2020,2019,'PASIVO'
GO
AnalisisHorizontal 2020,2019,'CAPITAL'
GO

alter procedure AnalisisHorizontal
	@fechaA int,
	@fechaB int,
	@tipo varchar(10)
as
	declare @BalanceA table(
	IdCuenta int,
	NombreCuenta varchar(100),
	Monto money
	)
	insert into @BalanceA 
	select
		c.IdCuenta, 
		c.NombreCuenta,
		t.Monto
	from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where Year(t.fecha) = @fechaA and cc.Nombre = @tipo

	declare @BalanceB table(
	IdCuenta int,
	NombreCuenta varchar(100),
	Monto money
	)
	insert into @BalanceB 
	select
		c.IdCuenta, 
		c.NombreCuenta,
		t.Monto
	from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where Year(t.fecha) = @fechaB and cc.Nombre = @tipo

	select distinct a.IdCuenta, a.NombreCuenta, a.Monto as [Año Análisis], b.Monto as [Año Base], a.Monto-b.Monto as [Variacion Absoluta],
	((a.Monto-b.Monto)/b.Monto)*100 as [Variacion Relativa]
	 from @BalanceA a, @BalanceB b
	 where a.IdCuenta = b.IdCuenta
go

/*create procedure OrigenAplicacion
@añoA int,
@añoB int,
@tipo varchar(10)
	as
	declare @variaciones table(
		IdCuenta int,
		NombreCuenta varchar(100),
		Monto money
	)
	insert into @variaciones 
	select AnalisisHorizontal @añoA, @añoB, @tipo
	
	declare @origen table(IdCuenta int, Monto money,tipoC varchar(15)) go
	insert into @origen select c.IdCuenta, ABS(c.Monto), 'Origen' from @variaciones c where Monto<
	declare @aplicacion table(IdCuenta int, Monto money) 
go*/