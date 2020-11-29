
-- Creacion de Base de Datos --
-- Vercion1 --
drop database el_unico;

create database if not exists El_Unico;
use El_Unico;

-- Tabla Usuarios --
create table if not exists Tab_Usuario(
Id_Usuario int auto_increment not null primary key,
Nombre_Usuario varchar(50),
Contrasena_Usuario varchar(50),
Tipo_Usuario varchar(50)
)Engine InnoDB;

-- insertar --
insert into Tab_Usuario(Nombre_Usuario,Contrasena_Usuario,Tipo_Usuario) values('juan','juan2020','Empleado'),('Carlos','carlos2020','Empleado'),('liseth','liseth2020','Empleado'),('maria','maria2020','Empleado'),('amilcar','amilcar2020','Empleado'),('pedro','pedro2020','Administrador'),('maycol','maycol2020','Administrador'),('rene','rene2020','Administrador'),('oscar','oscar2020','Administrador'),('jhonatan','jhonatan2020','Administrador');

-- Mostar --
select * from Tab_Usuario;

-- Tabla Clientes --
-- Modifique el campo usuario los clientes no tienen usuario --

Create table if not exists Tab_Cliente(
Id_Cliente int not null auto_increment primary key,
Nombre_Cliente varchar(50),
Apellido_Cliente varchar(50),
Dui_Cliente varchar(10),
Direccion_Cliente varchar(100),
Telefono_CLiente varchar(9),
Correo_Cliente varchar(50)
)Engine InnoDB;

 -- insertar --
insert into Tab_Cliente(Nombre_Cliente,Apellido_Cliente,Dui_Cliente,Direccion_Cliente,Telefono_CLiente,Correo_Cliente) value('Maycol Natael', 'Duque Figueroa','12345678-9','col.cuscatlan calle a canton jiñuco 1/2 contiguo a linea ferrea','1234-5678','DF16003@ues.edu.sv'),
('José Luis', 'Peréz Peréz','02345678-1','col.San antonio calle a canton los Naranjos 1/2 contiguo a Ferreteria el triunfo','1233-5672','lp12005@ues.edu.sv'),
('Maira Raquel', 'Lopéz Hernandéz','19345878-2','col.Monte Carmelo calle abarrio  españa contiguo a Comedor El gusto','1434-5778','ml0012@ues.edu.sv'),
('Roberto Neftali ', 'Campos Belloso','12145671-3','col.cuscatlan calle a canton Monte San Juan 1/2 contiguo a Alcaldia Municipal','9034-5667','rc23456@ues.edu.sv'),
('Miguel Angel', 'Zalazar Vermudéz','12124678-4','col.Flor Blanca calle a barrio los Cedros 1/2 contiguo a Pizza Planeta','1234-3412','mz452318@ues.edu.sv'),
('Rosa Liseth', 'Rosales Figueroa','12309678-9','col.Lousdez calle a barrio Colón contiguo a la cancha ','0987-5678','rr5612@ues.edu.sv'),
('Mario josué', 'thilo Deininger','1234500-9','col.zamora calle a canton Reyes 1/2 contiguo a linea ferrea','1834-5678','mt3344@ues.edu.sv'),
('Roxana Meliza', 'hernandéz Rodas','12300678-9','col.cruz calle a barrio El progreso contiguo a panaderia Rosario','1234-1122','rh1212@ues.edu.sv'),
('Cristian Alexiander', 'Heroa Velasques','12345645-0','col.los naranjos calle a barrio Libertad 1/2 contiguo a linea ferrea','1234-1234','ch1289@ues.edu.sv'),
('Marino José', 'Valles Bosquet','12340008-9','col.las llanuras calle a caserio los nenes contiguo a Motel LOVE','1236-6678','cv1111@ues.edu.sv');
-- Mostrar --
 SELECT * FROM Tab_Cliente ;

-- Tabla Proveedor --
-- quite el campo de usuario para proveedor --
Create table if not exists Tab_Proveedor(
Id_Proveedor int auto_increment not null primary key,
Nombre_Proveedor varchar(50),
Telefono_Proveedor varchar(9),
Direccion_Proveedor varchar(100)
)Engine InnoDB;

-- insertar --
insert into Tab_Proveedor(nombre_Proveedor,Telefono_Proveedor,Direccion_Proveedor) values('Juan Pablo','1234-6578','col.San antonio calle a canton los Naranjos 1/2 contiguo a Ferreteria el triunfo'),
('Julio Lourdez','1234-6589','calle Norte loxal #5 San Salvador'),
('Ivania Vasques','1234-9876',' 7 avenidanorte local #12 San Vicente'),
('Karina Zaldaña','5555-6578','Ex clinica de Radiologia carretera Panamericana san Miguel'),
('Diana Maricela','4321-6578','Calle Riquelmi avenida los Rosales Santa Ana'),
('Maria Lopéz','1234-1234','Barrio jiboa la libertad '),
('julian Flores ','1234-6003','Barrio los herues avenida Vernart Sonsonate'),
('Loida turcoz','1224-6511','Excuartel San Salvador local #9'),
('Ruth Quintanilla','1288-1178','Colonia los Rosarios local12 San pedro sula'),
('Luis Palao','2234-6098','Carretera Panamericana San Bartolo San Salvador');


-- Mostrar --
  SELECT * FROM Tab_Proveedor ;

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
insert into Tab_Producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) values('Mz001','Manzana',0.20,1),
('Ng001','Naranja',0.05,2),
('Sd002','sandia',1.00,3),
('Dn003','Durasno',0.30,4),
('Pn004','Pepino',0.05,5),
('Gn001','Guineo',0.05,6),
('pñ001','Piña',1.00,7),
('Uv001','Uvas',1.25,8),
('Cc001','Coco',0.50,9),
('Mg001','Mango',0.05,10);

-- Mostrar --
select pr.Codigo_Producto, pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor from Tab_Producto pr
Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto;

 
 
-- Tabla Pedido --
Create table if not exists Tab_Pedido(
Id_Pedido int primary key not null auto_increment,
Cantidad_Pedido int,
Fecha_Pedido varchar(50),
PrecioUnitario_Pedido decimal(7,2),
FK_Proveedor_Pedido int,
FK_Producto_Pedido int,
CostoTotal_Pedido decimal(7,2),
Descripcion_Pedido varchar(100),
constraint fk_Id_Proveedor_Pedido foreign key (FK_Proveedor_Pedido) references Tab_Proveedor(Id_Proveedor) on update cascade on delete cascade,
constraint fk_Id_Producto_Pedido foreign key (FK_Producto_Pedido) references Tab_Producto(Id_Producto) on update cascade on delete cascade 
)Engine InnoDB;
 


-- Mostrar --
Select pd.Fecha_Pedido, pd.Cantidad_Pedido, pr.Codigo_Producto, pr.Nombre_Producto, pr.CostoUnitario_Producto, p.Nombre_Proveedor,P.Telefono_Proveedor,p.Direccion_Proveedor
 from Tab_Pedido pd
Inner join Tab_Producto pr on pr.Id_Producto = pd.FK_Producto_Pedido
Inner join Tab_Proveedor p on p.Id_Proveedor = pd.FK_Proveedor_Pedido;

select * from tab_pedido;

-- Tabla Inventario --
create table if not exists Tab_Inventario(
Id_Inventario int not null primary key auto_increment,
FechaIngreso_Inventario varchar(25),
Cantidad_inventario int,
Descripcion_Inventario varchar(100),
PrecioVentaUnitario_Inventario decimal(7,2),
FK_Producto_Inventario int,
FK_proveedor_Inventario int,
constraint fk_Producto_Inventario foreign key (FK_Producto_Inventario) references Tab_Producto(Id_Producto) on update cascade on delete cascade,
constraint fk_Proveedor_Inventario foreign key (FK_Proveedor_Inventario) references Tab_Proveedor(Id_Proveedor) on update cascade on delete cascade
)Engine InnoDB;

-- trigger ingreso a inveentario --

create trigger trInsertar_Inventario after insert on Tab_Pedido
for each row
insert into Tab_Inventario(FechaIngreso_Inventario,Cantidad_inventario,Descripcion_Inventario,PrecioVentaUnitario_Inventario,FK_Producto_Inventario,FK_proveedor_Inventario)
values (new.Fecha_Pedido,new.Cantidad_Pedido,new.Descripcion_Pedido,new.PrecioUnitario_Pedido +(new.PrecioUnitario_Pedido* 0.30),new.FK_Producto_Pedido,new.FK_Proveedor_Pedido);



 -- drop trigger trInsertar_Inventario; --
-- insertar --
select * from tab_Inventario;
select iv.FechaIngreso_Inventario,iv.Cantidad_inventario,iv.Descripcion_Inventario,iv.PrecioVentaUnitario_Inventario,pr.Nombre_Producto,p.Nombre_Proveedor from tab_Inventario iv
Inner join Tab_Producto pr on pr.Id_Producto = iv.FK_Producto_Inventario
Inner join Tab_Proveedor p on p.Id_Proveedor = iv.FK_Proveedor_Inventario;

-- insertar inventario --


-- Tabla Existencias --
Create table if not exists Tab_Existencia(
Id_Existencia int not null auto_increment primary key,
Cantidad_Existencia int,
Fecha_Existencia varchar(25),
PrecioUnitario_Existencia decimal(7,2),
FK_Producto_Existencia int,
constraint fk_Id_Producto_Existencia foreign key (FK_Producto_Existencia) references Tab_Producto(Id_Producto) on update cascade on delete cascade
)Engine InnoDB;

-- mostrar --
Select ex.Fecha_Existencia,ex.Cantidad_Existencia,ex.PrecioUnitario_Existencia,pr.Nombre_Producto from Tab_Existencia as ex inner join Tab_Producto as pr on pr.Id_Producto = ex.FK_Producto_Existencia;

-- trigger ingreso a Existencias --

create trigger trInsertar_existencias after insert on Tab_Inventario
for each row
insert into Tab_Existencia(Cantidad_Existencia,PrecioUnitario_Existencia,Fecha_Existencia,FK_Producto_Existencia) values(new.Cantidad_inventario,new.PrecioVentaUnitario_Inventario,new.FechaIngreso_Inventario,new.FK_Producto_Inventario);

-- insertar Pedido --
insert into Tab_Pedido(Cantidad_Pedido,Fecha_Pedido,PrecioUnitario_Pedido,FK_Proveedor_Pedido,FK_Producto_Pedido,CostoTotal_Pedido,Descripcion_Pedido) values(100,curdate(),0.25,1,1,25.00,'Manzanas Rojas Calidas A'),
(200,curdate(),0.05,2,2,20.00,'Naranja Sin Semilla Calidas A'),
(50,curdate(),1.00,3,3,55.00,'Sandia jumbo Calidas B'),
(100,curdate(),0.30,4,4,35.00,'Durasno Calidas C'),
(100,curdate(),0.05,5,5,10.00,'Pepino Calidas D'),
(200,curdate(),0.05,6,6,20.00,'Guineos Calidas A'),
(50,curdate(),1.00,7,7,55.00,'Piña Calidas A'),
(50,curdate(),1.25,8,8,67.50,'Uvas Calidas A'),
(50,curdate(),0.50,9,9,27.50,'Coco Calidas A'),
(100,curdate(),0.05,10,10,10.00,'Mango Indio Calidas A');

select * from Tab_Existencia;

-- mostrar --
select ex.Fecha_Existencia,ex.Cantidad_Existencia,ex.PrecioUnitario_Existencia,pr.Nombre_Producto  from Tab_Existencia ex
inner join Tab_Producto pr on pr.Id_Producto = ex.FK_Producto_Existencia
;


-- Tabla Ventas --
create table if not exists Tab_Venta(
Id_Venta int not null auto_increment primary key,
Fecha_Venta varchar(25),
Cantidad_Venta int,
Total_Venta decimal (7,2),
FK_Producto_Venta int,
constraint fk_Id_Producto_Venta foreign key (FK_Producto_Venta) references Tab_Producto(Id_Producto) on update cascade on delete cascade
)Engine InnoDB;


-- trigger disminucion a Existencias --

create trigger trUpDate_existencias after insert on Tab_Venta
for each row
update Tab_Existencia as ex set ex.Fecha_Existencia = new.Fecha_venta, ex.Cantidad_Existencia =(Cantidad_Existencia - new.Cantidad_Venta)   where ex.FK_Producto_Existencia = new.FK_Producto_Venta;

select * from tab_Venta;
select v.Fecha_Venta,v.Cantidad_Venta,v.Total_Venta,Nombre_Producto from tab_Venta as v
inner join tab_Producto as pr on pr.Id_producto = v.FK_Producto_Venta;


-- Tabla Factura --
Create table if not exists Tab_Factura(
Id_Factura int not null auto_increment primary key,
Numero_Factura int,
Cantidad_Factura int,
total_Factura decimal(7,2),
Fecha_Factura varchar(25),
Fk_Cliente_Factura int,
FK_Producto_Factura int,
FK_Existencia_Factura int,
constraint fk_Id_Cliente_Factura foreign key (Fk_Cliente_Factura) references Tab_Cliente(Id_Cliente) on update cascade on delete cascade,
constraint fk_Id_Producto_Factura foreign key (Fk_Producto_Factura) references Tab_Producto(Id_Producto) on update cascade on delete cascade,
constraint fk_Id_Existencia_Factura foreign key (FK_Existencia_Factura) references Tab_Existencia(Id_Existencia) on update cascade on delete cascade
)Engine InnoDB;

-- trigger ingreso a Venta --

create trigger trInsertar_venta after insert on Tab_factura
for each row
insert into Tab_Venta(Fecha_Venta,Cantidad_Venta,Total_Venta,FK_Producto_Venta) values(new.Fecha_Factura,new.Cantidad_Factura,new.total_Factura,new.FK_Producto_Factura);



-- insertar --
insert into tab_Factura(Numero_Factura,Cantidad_Factura,total_Factura,Fecha_Factura,Fk_Cliente_Factura,FK_Producto_Factura,FK_Existencia_Factura) value(001,10,3.30,curdate(),1,1,1),(002,10,0.70,curdate(),2,2,2),
(003,10,13.00,curdate(),3,3,3),(004,10,3.90,curdate(),4,4,4),(005,10,0.70,curdate(),5,5,5),(006,10,0.70,curdate(),6,6,6),
(007,10,13.00,curdate(),7,7,7),(008,10,16.30,curdate(),8,8,8),(009,10,6.50,curdate(),9,9,9),(010,10,0.70,curdate(),10,10,10);

-- Mostrar --
Select f.Numero_Factura,Fecha_Factura,c.Nombre_Cliente,f.Cantidad_Factura,p.Nombre_Producto,ex.PrecioUnitario_Existencia,f.total_Factura from tab_Factura as f
inner join tab_Cliente as c on c.Id_Cliente = f.Fk_Cliente_Factura
inner join tab_Producto as p on p.Id_Producto = f.FK_Producto_Factura
inner join tab_Existencia as ex on ex.Id_Existencia = f.FK_Existencia_Factura;
 

-- Si le modificamos estoy a sus ordenes --