CREATE DATABASE PRED_EMPRESA

CREATE TABLE Persona (
    IdPersona INT IDENTITY (1,1) NOT NULL, 
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Estado VARCHAR(20) NOT NULL
	PRIMARY KEY (IdPersona)
);

CREATE TABLE Empleado (
    IdEmpleado INT IDENTITY (1,1) NOT NULL,
    IdPersona INT NOT NULL,
    Puesto VARCHAR(50) NOT NULL,
    Salario DECIMAL(21, 2) NOT NULL,
    FechaContratacion DATETIME NOT NULL,
	PRIMARY KEY (IdEmpleado),
    FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona),
);

insert into Persona values('Diego' ,'Sánchez' ,'Activo');
insert into Persona values('Eliana' ,'Martínez' ,'Activo');
insert into Persona values('Fabián' ,'Gómez' ,'Activo');
insert into Persona values('Gloria' ,'Díaz' ,'Inactivo');
insert into Persona values('Hugo' ,'Ruiz' ,'Activo');
insert into Persona values('Irene' ,'Torrez' ,'Inactivo');
insert into Persona values('Jorge' ,'Morales','Activo');
insert into Persona values('Karen' ,'Vargas' ,'Activo');
insert into Persona values('Fernando' ,'Fernandez','Activo');
insert into Persona values('Adrián' ,'Pérez' ,'Activo');
insert into Persona values('Belén','González','Activo');
insert into Persona values('Ana' ,'Rodríguez' ,'Inactivo');
insert into Persona values('Bruno' ,'López' ,'Activo');
insert into Persona values('Carla' ,'García' ,'Activo');

select * from Persona

insert into empleado values(1, 'Gerente', 5000.00, '2023-03-10 15:20:00');
insert into empleado values(2, 'Marketing', 3000.00, '2023-03-10 15:20:00');
insert into empleado values(3, 'Director Ejecutivo', 4500.00, '2023-03-10 15:20:00');
insert into empleado values(4, 'Asistente Administrativo', 3500.00, '2023-07-05 18:40:00');
insert into empleado values(5, 'Supervisor', 2500.00, '2023-07-05 18:40:00');
insert into empleado values(6, 'Operario', 2000.00, '2023-07-08 18:40:00');
insert into empleado values(7, 'Seguridad', 1500.00, '2023-07-05 18:40:00');

select * from Empleado


