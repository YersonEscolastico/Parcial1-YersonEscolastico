/*Create database ParcialunoDb;

go

use ParcialunoDb

Create table Productos(
 
productoId int primary key identity,
 descripcion varchar(30),
Existencia float,
 costo float,
 valorInventario float
)


Create table Inventario(
 
Id int primary key identity,
Total float
)
--delete from Inventarios where id=1
select * from Productos
--select * from Inventarios

SET IDENTITY_INSERT Inventarios ON
insert into Inventarios (Id, Total) values ('1','0');

SET IDENTITY_INSERT Ubicacions ON
*/
SET IDENTITY_INSERT Inventarios ON
insert into Inventarios(Id, Total) values ('1','0');




