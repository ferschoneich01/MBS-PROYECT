CREATE DATABASE MBS_DATA

use MBS_DATA
go

CREATE TABLE CIUDAD(
	Cod_Ciudad int primary key not null Identity,
	Nombre_Ciudad varchar(20) not null
);

CREATE TABLE DESCUENTO(
	Cod_Descuento int primary key not null,
	Descuento float 
);

CREATE TABLE RECARGAS(
	Id_Recarga int primary key not null Identity,
	Num_Telefono varchar(8) not null,
	Monto float not null,
	Operadora varchar(20) not null
);

CREATE TABLE PERSONA(
	Cedula varchar(20) primary key not null,
	Nombre varchar(20),
	Apellido varchar(20),
	Fecha_nac Date,
	Direccion varchar(50),
	Telefono varchar(8), 
	Correo varchar(30),
	Cod_Ciudad int foreign key references CIUDAD(Cod_Ciudad) not null
);

CREATE TABLE PROVEEDORES(
	id_proveedor int primary key not null,
	nombre varchar(20) not null,
	telefono varchar(8) not null,
	direccion varchar(30) not null,
	Ciudad int 
);

CREATE TABLE PRODUCTO(
	Cod_Producto varchar(10) primary key not null,
	Precio float not null,
	Descripcion varchar(30) not null,
	stock int not null,
	Tipo varchar(10) not null,
	proveedor int foreign key references PROVEEDORES(id_proveedor) NOT NULL

);

CREATE TABLE VENTAS(
	Id_Ventas int primary key not null Identity,
	Cod_Producto varchar(10) foreign key references PRODUCTO(Cod_Producto) not null,
	Cant_Vendidas int,
	Cod_Descuento int foreign key references DESCUENTO(Cod_Descuento) not null,
	Id_Recarga int foreign key references RECARGAS(Id_Recarga) not null,
	fecha datetime not null


);

CREATE TABLE FACTURA( 
	Id_Factura int primary key not null Identity,
	Id_Ventas int foreign key references VENTAS(Id_Ventas) not null,
	Num_Cliente int 

);



CREATE TABLE TRANSACCION_BANC(
	Id_Trans int primary key not null Identity,
	Tipo varchar(20),
	Monto float not null,
	Referencia varchar(20),
	Cedula varchar(20) not null,
	Banco varchar(20) not null,
	Id_Factura int foreign key references FACTURA(Id_Factura) not null

);

CREATE TABLE USUARIO(
	id_user int primary key not null Identity,
	Nombre varchar(20) not null,
	contraseña varchar(20) not null,
	Rol varchar(20) not null,
	Cedula varchar(20) foreign key references PERSONA(Cedula)
);

INSERT INTO CIUDAD VALUES ('Managua');
INSERT INTO CIUDAD VALUES ('Chinandega');
INSERT INTO CIUDAD VALUES ('Masaya');
INSERT INTO CIUDAD VALUES ('Diriamba');
INSERT INTO CIUDAD VALUES ('Leon');
INSERT INTO CIUDAD VALUES ('Esteli');

INSERT INTO DESCUENTO VALUES (001,0.00);
INSERT INTO DESCUENTO VALUES (002,0.15);
INSERT INTO DESCUENTO VALUES (003,0.20);
INSERT INTO DESCUENTO VALUES (004,0.05);
INSERT INTO DESCUENTO VALUES (005,0.50);

INSERT INTO PERSONA VALUES ('001-090701-1010H','Mayner Fernando','Schoneich Romero','2001-07-09','Del arbolito 2 varas al lago','85866402','pepito01@gmail.com',1);

INSERT INTO USUARIO VALUES ('Admin','Admin123','admin','001-090701-1010H');

--PROCEDIMIENTO DE BUSQUEDA POR CODIGO DE PRODUCTO
create procedure Seleccionar
@Cod_Producto varchar(10)
as
begin
   SELECT * FROM PRODUCTO WHERE Cod_Producto like @Cod_Producto
	end


create procedure Registro_usuario
@Cedula varchar(10),
@Nombre varchar(20),
@Apellido varchar(20),
@Fecha_nac date,
@Direccion varchar(50),
@Telefono varchar(8),
@Correo varchar(30),
@Cod_Ciudad int,
@Usuario varchar(20),
@Contraseña varchar(20)
as
begin
   INSERT INTO PERSONA VALUES (@Cedula,@Nombre,@Apellido,@Fecha_nac,@Direccion,@Telefono,@Correo,@Cod_Ciudad);
   INSERT INTO USUARIO VALUES (@Usuario,@Contraseña,'Empleado',@Cedula);
	end



create proc EditarProductos
@Cod_Producto varchar (10),
@Desc varchar (30),
@Precio float,
@Stock int,
@Tipo varchar(20),
@proveedores int
as
update PRODUCTO set Cod_Producto = @Cod_Producto, Descripcion = @Desc, Precio = @Precio,
Stock = @Stock, Tipo = @Tipo, @proveedores = @proveedores
where Cod_Producto = @Cod_Producto
go

create proc EliminarProducto
@Cod_Producto varchar(10)
as
delete from PRODUCTO
where Cod_Producto = @Cod_Producto
go

create procedure Agregar_recarga
@Cod_Producto varchar(10),
@Cant_Vendidas int,
@Cod_Descuento int,
@fecha date,
@Id_Recarga int,
@Num_Telefono varchar(8),
@Monto float,
@Operadora varchar(20)
as
begin
	INSERT INTO RECARGAS VALUES(@Num_Telefono,@Monto,@Operadora)
	INSERT INTO VENTAS VALUES(@Cod_Producto,@Cant_Vendidas,@Cod_Descuento,@Id_Recarga,@fecha)
end


