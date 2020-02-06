--drop database Finanzas
--create database Finanzas

use Finanzas

Create table Usuario
(
	IdUsuario int primary key identity(1,1),
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

Create procedure Validar_Acceso
	@usuario varchar(50),
	@contraseña varchar(100),
	@rol varchar(50)
as
	select IdUsuario from Usuario where Nombre_Usuario = @usuario and Contraseña = @contraseña and Rol = @rol
go


Insert into Usuario values ('gabx01','1234','Jefe')

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

/* pasivos a corto plazo */
insert into Cuenta values(6,'Proveedores')
insert into Cuenta values(6,'Acreedores')
insert into Cuenta values(6,'Cuentas por pagar')
insert into Cuenta values(6,'Intereses por pagar')
insert into Cuenta values(6,'Dividendos por pagar')
insert into Cuenta values(6,'IR por pagar')

/* pasivos a largo plazo */
insert into Cuenta values(7,'Cuenta por pagar banco')
insert into Cuenta values(7,'Prestamos por pagar largo plazo')

/* Capital  */
insert into Cuenta values(9,'Reserva legal')
insert into Cuenta values(9,'Utilidad neta del ejercicio')
insert into Cuenta values(9,'Utilidades retenidas')
insert into Cuenta values(9,'Capital social')
go

/* Ingresos */
insert into Cuenta values(10,'Ventas')
insert into Cuenta values(10,'Devoluciones sobre venta')
insert into Cuenta values(10,'Descuento sobre venta')
insert into Cuenta values(10,'Ventas netas al credito')
insert into Cuenta values(10,'Otros ingresos')

/* Costos */
insert into Cuenta values(12,'Costo de ventas')

/*  Gastos de admon */
insert into Cuenta values(13,'Sueldo Gerente')
insert into Cuenta values(13,'Publicidad')
insert into Cuenta values(13,'Consumo de luz')

/* Gastos de venta*/
insert into Cuenta values(15,'Sueldo empleado')
insert into Cuenta values(15,'Papelería y utiles')
insert into Cuenta values(15,'Impuesto sobre ventas')

/* Gastos financieros */
insert into Cuenta values(14,'Intereses pagados')
insert into Cuenta values(14,'Producto Financiero')

/* Gastos operativos */
insert into Cuenta values(16,'Operación de la empresa')

/* Otros gastos */
insert into Cuenta values(17,'Perdida en venta de activo fijo')
insert into Cuenta values(17,'Rentas pagadas')
insert into Cuenta values(17,'Dividendos Pagados')

insert into Cuenta values(17,'Gastos de depreciación de oficina')
insert into Cuenta values(17,'Gastos de depreciación de vehículo')
insert into Cuenta values(17,'Amortización')

--ISR
insert into Cuenta values(17,'Impuesto sobre renta')


--Activos corrientes

insert into Transacción values (1,44171,getdate(),'D')
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


/*  ER   */

--ventas
insert into transacción values(29,280000,GETDATE(),'H')
insert into transacción values(30,-4000,GETDATE(),'H')
insert into transacción values(31,-1500,GETDATE(),'H')
insert into transacción values(32, 0.00, GETDATE(),'H')
insert into transacción values(33,0.00,GETDATE(),'H')

--costo de venta
insert into transacción values(34,82800,GETDATE(),'D')


--gastos de admon
insert into transacción values(35,24000,GETDATE(),'H')
insert into transacción values(36,12000,GETDATE(),'H')
insert into transacción values(37,34400,GETDATE(),'H')


--gastos de venta

insert into transacción values(38,20000,GETDATE(),'H')
insert into transacción values(39,10000,GETDATE(),'H')
insert into transacción values(40,3000,GETDATE(),'H')

--gastos financieros

insert into transacción values(41,2000,GETDATE(),'H')
insert into transacción values(42,1000,GETDATE(),'H')

/*gastos operativos*/
insert into transacción values (43,103400.00,GETDATE(),'H')

/* Otros gastos*/
insert into transacción values (44,0.00,GETDATE(),'H')
insert into transacción values (45,0.00,GETDATE(),'H')
insert into transacción values (46,0.00,GETDATE(),'H')
insert into transacción values (47,0.00,GETDATE(),'H')
insert into transacción values (48,0.00,GETDATE(),'H')
insert into transacción values (49,0.00,GETDATE(),'H')
insert into transacción values (50,25445.00,GETDATE(),'H')

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

Create procedure MostrarBalanceGeneral
	@fecha int,
	@tipo varchar(10)
as
	select
		c.NombreCuenta,
		t.Monto
	from transacción t
	inner join Cuenta c on c.IdCuenta = t.IdCuenta
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where Year(t.fecha) = @fecha and cc.Nombre = @tipo
go

create procedure Mostrar_EstadoResultado
as
	select
		c.NombreCuenta from Cuenta c 
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on sc.IdCategoríaCuenta = cc.IdCategoríaCuenta
	where cc.Nombre in('INGRESOS','COSTOS','GASTOS')
go

Create procedure Catalogo_Cuentas
	@tipo varchar(10)
as
	select
		c.NombreCuenta
	from Cuenta c 
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join CategoríaCuenta cc on cc.IdCategoríaCuenta = sc.IdCategoríaCuenta
	where cc.Nombre = @tipo
go

/*  Muestra las utilidades  */

CREATE FUNCTION Mostrar_Utilidad_Bruta(@año int)
	RETURNS money
	WITH EXECUTE AS CALLER
	AS
	BEGIN
	declare @Ventas money = (select sum(t.Monto) from transacción t 
							 inner join Cuenta c on t.IdCuenta = c.IdCuenta 
							 where c.IdCuenta in(29,30,31) and year(t.fecha) = @año)

	declare @costo money = (select sum(t.Monto) from transacción t 
							inner join Cuenta c on t.IdCuenta = c.IdCuenta 
							where c.IdCuenta = 34 and year(t.fecha) = @año)

	declare @Utilidad money = @Ventas - @costo
	return @Utilidad
	END
	GO

Create Function Mostrar_UtilidadOperativa(@año int)
returns money
with execute as caller
as
begin
	declare @utilidad money = dbo.Mostrar_Utilidad_Bruta(@año)

	declare @operacion money = (select t.Monto from transacción t 
								inner join Cuenta c on t.IdCuenta = c.IdCuenta
								where c.NombreCuenta= 'Operación de la empresa' and year(t.fecha) = @año)

	declare @utilidad_operacion money = @utilidad - @operacion
	return @utilidad_operacion 
end
go


CREATE FUNCTION Mostrar_UtilidadADI(@año int)
	RETURNS money
	WITH EXECUTE AS CALLER
	AS
	BEGIN
	

	declare @Utilidad_operativa money =dbo.Mostrar_UtilidadOperativa(@año)

	declare @gastos_finan money =  ( select sum(t.Monto) from transacción t 
									 inner join Cuenta c on t.IdCuenta = c.IdCuenta
									 where c.NombreCuenta in('Intereses pagados', 'Producto Financiero')  and year(t.fecha) = @año)

	declare @Utilidad money = @Utilidad_operativa -  @gastos_finan
	return @Utilidad
	END
	go

go

Create function Mostrar_UtilidadNeta(@año int)
    returns money
	with execute as caller
	as
	begin
	declare @UAII money = dbo.Mostrar_UtilidadADI(@año)

	declare @impuesto money = ( select sum(t.Monto) from transacción t 
								inner join Cuenta c on t.IdCuenta = c.IdCuenta
								where c.NombreCuenta = 'Impuesto sobre renta'  and year(t.fecha) = @año)

	declare @UNE money = @UAII - @impuesto

	return @UNE
	end
	go

/* =============================== Razones financieras  ================================*/

/*         Capital de neto de trabajo           */

create procedure Capital_Trabajo
@año int
	as
declare @Activo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Activo Circulante'))
declare @Pasivo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Pasivo CP'))

select (@Activo_Circulante - @Pasivo_Circulante) as Capital_Trabajo
go


/**                    Indice de solvencia                   */
Create procedure Indice_solvencia
	@año int
as
	declare @Activo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Activo Circulante'))
	declare @Pasivo_Circulante money = (select ''+dbo.Suma_Cuenta(@año, 'Pasivo CP'))

	select (@Activo_Circulante / @Pasivo_Circulante) as Indice_solvencia
go

/*         Razón de prueba ácida          **/
Create procedure Razon_ácida
	@año int
as
	declare @Activo_Circulante money = (select dbo.Suma_Cuenta(@año, 'Activo Circulante'))
	
	declare @Inventario money = (
							select t.Monto 
							from transacción t 
							inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							where Year(t.fecha) = @año and c.NombreCuenta = 'Inventario')
|
	declare @Pasivo_Circulante money = (select dbo.Suma_Cuenta(@año, 'Pasivo CP'))

	select ((@Activo_Circulante - @Inventario) / @Pasivo_Circulante ) as Razon_ácida
go

/*--------------------------Razones de actividad ------------------------------------------------------*/

/*  Rotacion de Inventario   */
go
create procedure Rotación_Inventario
@año int
	as
declare @CostoVenta money = (select t.Monto 
							 from transacción t 
							 inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							 where Year(t.fecha) = @año and c.NombreCuenta = 'Costo de ventas')

declare @Inventario money = (select t.Monto 
							from transacción t 
							inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							where Year(t.fecha) = @año and c.NombreCuenta = 'Inventario')

select ''+(@CostoVenta/@Inventario) as Rotación_Inventario
go


/*   Rotacion */

create procedure Rotacion_Interes
@año int
as

		declare @UAII money = dbo.Mostrar_UtilidadOperativa(@año)

		declare @interes money = (select t.Monto 
								  from transacción t 
							      inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							      where Year(t.fecha) = @año and c.NombreCuenta = 'Intereses pagados')

select ''+(@UAII / @interes) as Rotacion_Interes
go

/*   Rotación cuentas por cobrar   */
create procedure Rotación_Cuentas_por_cobrar
@año int
	as
declare @ventas_credito money = (select t.Monto 
							 from transacción t 
							 inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							 where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas netas al credito')

declare @cuentas money = (select t.Monto 
							from transacción t 
							inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							where Year(t.fecha) = @año and c.NombreCuenta = 'Cuentas por cobrar')

select ''+(@ventas_credito/@cuentas) as Rotación_Cuentas_por_cobrar
go

/*        Rotacion proveedores      */

go
Alter procedure Rotación_proveedores
@año int
	as
declare @Inventario_inicial money = 0
declare @CostoVenta money = (select t.Monto 
							 from transacción t 
							 inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							 where Year(t.fecha) = @año and c.NombreCuenta = 'Costo de ventas')
declare @cuentas money = (select t.Monto 
							from transacción t 
							inner join Cuenta c on c.IdCuenta = t.IdCuenta 
							where Year(t.fecha) = @año and c.NombreCuenta = 'Cuentas por pagar')

if exists (select t.Monto from transacción t inner join Cuenta c on c.IdCuenta = t.IdCuenta 
			where Year(t.fecha) - 1 = @año and c.NombreCuenta = 'Inventario')
begin
	 set @Inventario_inicial = (select t.Monto 
								from transacción t 
								inner join Cuenta c on c.IdCuenta = t.IdCuenta 
								where Year(t.fecha) - 1 = @año and c.NombreCuenta = 'Inventario')
end
else
begin
	set @Inventario_inicial = 0
end

declare @Inventario_final money = (select t.Monto 
									from transacción t 
									inner join Cuenta c on c.IdCuenta = t.IdCuenta 
									where Year(t.fecha) = @año and c.NombreCuenta = 'Inventario')

declare @compras money = @CostoVenta + @Inventario_final - @Inventario_inicial
select ''+(@compras/@cuentas) as Rotación_proveedores
go



/*    Razon de deuda   */
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

/*  Razón pasivo capital  */

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


/*   Rotacion activo fijo    */
create procedure Rotación_ActivoFijo
@año int
	as
	declare @activo_fijo money = (dbo.Suma_Cuenta(@año,'Activo Fijo '))
	declare @ventas money = (select t.Monto
							 from Cuenta c 
						   	 inner join transacción t on t.IdCuenta = c.IdCuenta 
							 where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas')
	select (@ventas / @activo_fijo) as Rotación_ActivoFijo
go

create procedure Rotación_ActivoTotal
@año int
as
	declare @activo_total money = (select sum(t.Monto)
								  from Cuenta c 
						   		  inner join transacción t on t.IdCuenta = c.IdCuenta 
								  where Year(t.fecha) = @año and c.IdCuenta between 1 and 16)
	declare @ventas money = (select t.Monto
							 from Cuenta c 
						   	 inner join transacción t on t.IdCuenta = c.IdCuenta 
							 where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas')

	select (@ventas / @activo_total) as Rotación_ActivoTotal
go

/*  M utilidad bruta  */

create procedure MUB
@año int
as

	declare @ventas money = (select t.Monto
								   from Cuenta c 
						   		   inner join transacción t on t.IdCuenta = c.IdCuenta 
								   where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas')

	declare @UB money = dbo.Mostrar_Utilidad_Bruta(@año)

	select (@UB / @ventas) as MUB
go

/*  M utilidad operativa  */

create procedure MUO
@año int
as

	declare @ventas money = (select t.Monto
								   from Cuenta c 
						   		   inner join transacción t on t.IdCuenta = c.IdCuenta 
								   where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas')

	declare @UO money = dbo.Mostrar_UtilidadOperativa(@año)

	select (@UO / @ventas) as MUO
go

/*  M utilidad neta   */

create procedure MUN
@año int
as

	declare @ventas money = (select t.Monto
								   from Cuenta c 
						   		   inner join transacción t on t.IdCuenta = c.IdCuenta 
								   where Year(t.fecha) = @año and c.NombreCuenta = 'Ventas')

	declare @UN money = dbo.Mostrar_UtilidadNeta(@año)

	select (@UN / @ventas) as MUN
go

/*  Catalogo de cuentas del estado de reultados */
Create procedure Insertar_monto
@IdCuenta int,
@Monto money,
@Fecha date,
@Concepto varchar(5)
	as
Insert into transacción values(@IdCuenta,@Monto,@Fecha,@Concepto)
go

Create procedure Mostrar_Todo
@año int
as
	select 
		c.IdCuenta,
		sc.SubNombre,
		c.NombreCuenta,
		t.Monto
		from Cuenta c
	inner join SubCategoríaCuenta sc on c.IdSubCategoríaCuenta = sc.IdSubCategoríaCuenta
	inner join transacción t on t.IdCuenta = c.IdCuenta
where year(t.fecha) = @año
go

Mostrar_Todo 2020

/*  EFE   */



select t.Monto from transacción t where year(t.fecha) = 2020



create procedure Actividades_Operación
@fecha1 int,
@fecha2 int

as

declare Iterator_table cursor scroll 
for select VM.IdCuenta, VM.SubNombre, VM.NombreCuenta, VM.Monto, VM.fecha from VMostrar_todo VM
open Iterator_table
	
	create table #Actividad_Operación
	(
		IdCuenta int primary key,
		NombreCuenta varchar(50),
		Monto money,
		tipo varchar(10)
	)

go

