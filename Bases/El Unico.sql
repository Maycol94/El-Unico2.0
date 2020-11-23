
-- Creacion de Base de Datos --
-- Vercion1 --

create database if not exists El_Unico;
use El_Unico;

-- Tabla Usuarios --
create table if not exists Tab_Usuario(
Id_Usuario int auto_increment not null primary key,
Nombre_Usuario varchar(50),
Tipo_Usuario varchar(50),
Contrasena_Usuario varchar(50)
)Engine InnoDB;

-- insertar --
insert into Tab_Usuario(Nombre_Usuario,Contrasena_Usuario) values('cliente','cliente2020'),('proveedor','proveedor2020'),('abmin','abmin123');

-- Mostar --
select * from Tab_Usuario;

-- Tabla Clientes --
Create table if not exists Tab_Cliente(
Id_Cliente int not null auto_increment primary key,
Nombre_Cliente varchar(50),
Apellido_Cliente varchar(50),
Dui_Cliente varchar(10),
Direccion_Cliente varchar(100),
Telefono_CLiente varchar(9),
Correo_Cliente varchar(50),
FK_Usuario_Cliente int,
constraint fk_Id_Usuario_Cliente foreign key(FK_Usuario_Cliente) references Tab_Usuario(Id_Usuario) on update cascade on delete cascade
)Engine InnoDB;

 -- insertar --
insert into Tab_Cliente(Nombre_Cliente,Apellido_Cliente,Dui_Cliente,Direccion_Cliente,Telefono_CLiente,Correo_Cliente,FK_Usuario_Cliente) value('Maycol Natael', 'Duque Figueroa','12345678-9','Por aqui algo legos de por alla pero cerca de ustedes jajajaja','1234-5678','DF16003@ues.edu.sv',1);

-- Mostrar --
 SELECT c.Nombre_Cliente, c.Apellido_Cliente, c.Dui_Cliente, c.Direccion_Cliente, c.Telefono_CLiente, u.Nombre_Usuario, u.Contrasena_Usuario FROM Tab_Cliente c
 inner join Tab_Usuario u  on u.Id_Usuario = c.FK_Usuario_Cliente;

-- Tabla Proveedor --
Create table if not exists Tab_Proveedor(
Id_Proveedor int auto_increment not null primary key,
Nombre_Proveedor varchar(50),
Telefono_Proveedor varchar(9),
Direccion_Proveedor varchar(100),
FK_Usuario_Proveedor int,
constraint fk_Id_Usuario_Proveedor foreign key(FK_Usuario_Proveedor) references Tab_Usuario(Id_Usuario) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Proveedor(nombre_Proveedor,Telefono_Proveedor,Direccion_Proveedor,FK_Usuario_Proveedor) values('Juan Pablo','1234-6578','Hola al igual estoy para servirle',2);

-- Mostrar --
  SELECT p.Nombre_Proveedor, p.Telefono_Proveedor,p.Direccion_Proveedor, u.Nombre_Usuario, u.Contrasena_Usuario FROM Tab_Proveedor p 
 inner join Tab_Usuario u on u.Id_Usuario  = p.FK_Usuario_Proveedor ;

-- Tabla Producto --
create table if not exists Tab_Producto(
Id_Producto int not null auto_increment primary key,
Codigo_Producto varchar(25),
Nombre_Producto varchar(50),
CostoUnitario_Producto decimal(7,2),
FK_Proveedor_Producto int,
constraint fk_Id_Proveedor_Producto foreign key (FK_Proveedor_Producto) references Tab_Proveedor(Id_Proveedor) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) values('Mz001','Manzana',0.20,1);

-- Mostrar --
select pr.Codigo_Producto, pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor from Tab_Producto pr
Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto;
 
-- Tabla Pedido --
Create table if not exists Tab_Pedido(
Id_Pedido int primary key not null auto_increment,
Cantidad_Pedido int,
Fecha_Pedido varchar(50),
FK_Proveedor_Pedido int,
FK_Producto_Pedido int,
CostoTotal_Pedido decimal(7,2),
constraint fk_Id_Proveedor_Pedido foreign key (FK_Proveedor_Pedido) references Tab_Proveedor(Id_Proveedor) on update cascade on delete cascade,
constraint fk_Id_Producto_Pedido foreign key (FK_Producto_Pedido) references Tab_Producto(Id_Producto) on update cascade on delete cascade 
)Engine InnoDB;
 
-- insertar --
insert into Tab_Pedido(Cantidad_Pedido,Fecha_Pedido,CostoTotal_Pedido, FK_Producto_Pedido,FK_Proveedor_Pedido ) values(500,curdate(),200.00,1,1);

-- Mostrar --
Select pd.Fecha_Pedido, pd.Cantidad_Pedido, pr.Codigo_Producto, pr.Nombre_Producto, pr.CostoUnitario_Producto, p.Nombre_Proveedor,P.Telefono_Proveedor,p.Direccion_Proveedor
 from Tab_Pedido pd
Inner join Tab_Producto pr on pr.Id_Producto = pd.FK_Producto_Pedido
Inner join Tab_Proveedor p on p.Id_Proveedor = pd.FK_Producto_Pedido;

-- Tabla Inventario --
create table if not exists Tab_Inventario(
Id_Inventario int not null primary key auto_increment,
FechaIngreso_Inventario varchar(25),
Cantidad_Inventario int,
Descripcion_Inventario varchar(100),
PrecioVentaUnitario_Inventario decimal(7,2),
FK_Producto_Inventario int,
FK_proveedor_Inventario int,
constraint fk_Producto_Inventario foreign key (FK_Producto_Inventario) references Tab_Producto(Id_Producto) on update cascade on delete cascade,
constraint fk_Proveedor_Inventario foreign key (FK_Proveedor_Inventario) references Tab_Proveedor(Id_Proveedor) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Inventario(FechaIngreso_Inventario,Cantidad_Inventario,Descripcion_Inventario,PrecioVentaUnitario_Inventario,FK_Producto_Inventario,FK_proveedor_Inventario) values (Curdate(),25,'MAnzanas rojas del pedido pasado',0.50,1,1);

-- mostrar --  
select iv.FechaIngreso_Inventario, iv.Cantidad_Inventario, iv.Descripcion_Inventario, iv.PrecioVentaUnitario_Inventario,pr.Codigo_Producto,
 pr.Nombre_Producto, p.Nombre_proveedor, p.Telefono_Proveedor  from Tab_Inventario iv
Inner join Tab_Proveedor p on p.Id_Proveedor = iv.FK_proveedor_Inventario
Inner join Tab_Producto pr on pr.Id_Producto = iv.FK_Producto_Inventario;


-- Tabla Existencias --
Create table if not exists Tab_Existencia(
Id_Existencia int not null auto_increment primary key,
Cantidad_Existencia int,
Fecha_Existencia varchar(25),
FK_Inventario_Existencia int,
FK_Producto_Existencia int,
constraint fk_Id_Inventario_Existencia foreign key (FK_Inventario_Existencia) references Tab_Inventario(Id_Inventario) on update cascade on delete cascade,
constraint fk_Id_Producto_Existencia foreign key (FK_Producto_Existencia) references Tab_Producto(Id_Producto) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Existencia(Cantidad_Existencia,Fecha_Existencia,FK_Inventario_Existencia, FK_Producto_Existencia)values(25,curdate(),1,1);

-- mostrar --
select ex.Fecha_Existencia,ex.Cantidad_Existencia, iv.Cantidad_Inventario,pr.Nombre_Producto , iv.PrecioVentaUnitario_Inventario from Tab_Existencia ex
inner join Tab_Producto pr on pr.Id_Producto = ex.FK_Producto_Existencia
inner join Tab_Inventario iv on iv.Id_Inventario = ex.FK_Inventario_Existencia;

-- Tabla Ventas --
create table if not exists Tab_Venta(
Id_Venta int not null auto_increment primary key,
Fecha_Venta varchar(25),
Cantidad_Venta int,
Total_Venta decimal (7,2),
FK_Inventario_Venta int,
FK_Producto_Venta int,
FK_Existencia_Venta int,
constraint fk_Id_Existencia_Venta foreign key (FK_Existencia_Venta) references Tab_Existencia(Id_Existencia) on update cascade on delete cascade,
constraint fk_Id_Inventario_Venta foreign key (FK_Inventario_Venta) references Tab_Inventario(Id_Inventario) on update cascade on delete cascade,
constraint fk_Id_Producto_Venta foreign key (FK_Producto_Venta) references Tab_Producto(Id_Producto) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Venta(Fecha_Venta,Cantidad_Venta,Total_Venta,FK_Inventario_Venta,FK_Producto_Venta,FK_Existencia_Venta ) values(curdate(),5,2.50,1,1,1);

-- Mostrar --
select v.fecha_Venta,v.Cantidad_Venta, iv.PrecioVentaUnitario_Inventario,v.Total_Venta, pr.Nombre_Producto,ex.Cantidad_Existencia  from Tab_Venta v
inner join Tab_Inventario iv on iv.Id_Inventario = v.FK_Inventario_Venta
inner join Tab_Producto pr on pr.Id_Producto = v.FK_Producto_Venta
inner join Tab_Existencia ex on ex.Id_Existencia = v.FK_Existencia_Venta;


-- Tabla Factura --
Create table if not exists Tab_Factura(
Id_Factura int not null auto_increment primary key,
Numero_Factura int,
Fecha_Factura varchar(25),
Fk_Cliente_Factura int,
Fk_Venta_Factura int,
FK_Producto_Factura int,
FK_Inventario_Factura int,
constraint fk_Id_Cliente_Factura foreign key (Fk_Cliente_Factura) references Tab_Cliente(Id_Cliente) on update cascade on delete cascade,
constraint fk_Id_Venta_Factura foreign key (Fk_Venta_Factura) references Tab_Venta(Id_Venta) on update cascade on delete cascade,
constraint fk_Id_Producto_Factura foreign key (Fk_Producto_Factura) references Tab_Producto(Id_Producto) on update cascade on delete cascade,
constraint fk_Id_Inventario_Factura foreign key (Fk_Inventario_Factura) references Tab_Inventario(Id_Inventario) on update cascade on delete cascade
)Engine InnoDB;

-- insertar --
insert into Tab_Factura(Numero_Factura,Fecha_Factura,Fk_Cliente_Factura,Fk_Venta_Factura,FK_Producto_Factura,FK_Inventario_Factura ) values (0001,curdate(),1,1,1,1);

-- Mostrar --
Select f.Numero_Factura, f.Fecha_Factura, c.Nombre_Cliente, c.Apellido_CLiente, p.Nombre_Producto,iv.PrecioVentaUnitario_Inventario, v.Total_Venta from Tab_Factura f
inner join Tab_Cliente c on c.Id_Cliente = f.Fk_Cliente_Factura
inner join Tab_Venta v on v.Id_Venta = f.Fk_Venta_Factura
Inner join Tab_Producto p on p.Id_Producto = f.FK_Producto_Factura
inner join Tab_Inventario iv on iv.Id_Inventario = f.FK_Inventario_Factura;

-- Si le modificamos estoy a sus ordenes --