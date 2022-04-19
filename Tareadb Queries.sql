use Tareasdb;
go

create table Estado(
id int identity (1,1),
nombre varchar (50) not null
);
go

alter table Estado add constraint PK_Estado primary key (id);


create table Tarea(
id int identity (1,1),
nombre varchar(50) not null,
descipcion text not null,
estadoF int default 'Registrada' 
);
go

alter table Tarea add constraint PK_Tarea primary key (id);
alter table Tarea add constraint FK_TareaEstado foreign key (estadoF) references Estado(id);

alter table Tarea alter column estadoF int;

/******************************************************/

create table Usuario(
id int identity(1,1),
nombre varchar(70) not null,
apellido varchar(60) not null,
usuarioN varchar(30) not null,
contrasena varchar(20) not null
);

go

alter table Usuario add constraint PK_Usuario primary key (id);


/*************************************************/
create table Asignaciones(
id int identity(1,1),
usuarioF int,
tareaF int,
fecha date default getdate(),
hora time default convert (time,GETDATE())
);

drop table Asignaciones;

insert into Asignaciones(usuarioF, tareaF) values (2,2);

select * From Asignaciones;
select * From Usuario;
select * From Tarea;

select  u.nombre as Usuario, t.nombre As Nombre, a.fecha, a.hora, e.nombre as Estado   from Asignaciones a join Tarea t on (a.tareaF = t.id) join Estado e on (t.estadoF = e.id) join Usuario u on (a.usuarioF = u.id);

update Asginaciones set usuarioF = "dato", tareaF=Dato Where id +

select t.id as Id, t.nombre as Nombre, t.descripcion as Descripcion, e.nombre as Estado from Tarea t join Estado e on (t.estadoF = e.id);

select getdate();

select convert (time,GETDATE())

select CURRENT_TIMESTAMP;

alter table Asignaciones add constraint PK_Asignaciones primary key(id);
alter table Asignacionse drop constraint PK_Asignaciones;

alter table Asignaciones add constraint Fk_AsginacionUsuario foreign key (usuarioF) references Usuario(id);
alter table Asignaciones add constraint FK_AsignacionTare foreign key (tareaF) references Tarea(id);

/*********************************/
/*primeros Inserts*/
insert into Estado (nombre) values ('Registrada');
insert into Estado (nombre) values ('Asginada');
insert into Estado (nombre) values ('En Proceso');
insert into Estado (nombre) values ('Finalizada');
insert into Estado (nombre) values ('Cancelada');

insert into Tarea (nombre,descipcion, estadoF) values('Cargar Facturas','Cargar las facturas del mes de febrero al sistemas DAC', 1);

select * from Tarea;

exec sp_rename 'dbo.Tarea.descipcion','descripcion';

update Estado set nombre = 'Actualizado' where id = 6;

delete Estado where id = 10;

use Tareasdb;
truncate table Estado;

select t.id as Id, t.nombre as Nombre, t.descripcion as Descripcion, e.nombre as Estado from Tarea t join Estado e on (t.estadoF = e.id);

update Tarea set nombre = 'Descargar Datos', estadoF = 2 where id = 1;

delete Tarea where id = 7;
use Tareasdb;

 

insert into Usuario (nombre, apellido, usuarioN, contrasena) values ('Marcos', 'Alcantara', 'MarAlc', 123);

update Usuario set nombre = 'nombre', apellido = 'apellido', usuarioN = 'Usuario', contrasena = 'Pass' where id = 1;

select * from Tarea;

delete usuario where id = 1;

select * from asignaciones;

