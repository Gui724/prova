create database sistemaweb;

use sistemaweb;

create table departamento(
	id_dep INT primary key auto_increment,
	nomeDepartamento varchar(60),
	cidade varchar(40),
	fg_ativo int
);

create table funcionario(
	id_funcionario int primary key auto_increment,
	id_gerente int,
	id_dep int,
	dt_nascimento DATE,
	salariofuncionario numeric,
	cargofuncionario varchar(60),
	fg_ativo int,
	constraint fk_departamento foreign key (id_dep) references departamento (id_dep)
);
