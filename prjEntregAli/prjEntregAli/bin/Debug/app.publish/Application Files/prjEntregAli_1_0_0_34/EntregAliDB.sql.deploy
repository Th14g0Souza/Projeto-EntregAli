use EntregAliDB2

--DROP DATABASE IF EXISTS EntregAliDB2

--CREATE DATABASE EntregAliDB2

set dateformat dmy

use EntregAliDB2
SET NOCOUNT Off

create table tblCliente (
id_cli int primary key identity(1,1),
nome varchar(50) not null,
CPF varchar(20) not null,
RG varchar(20) not null,
telefone varchar(20),
celular varchar(20) not null,
datanasc date,
email varchar(30),
endereco varchar(200) not null,
bairro varchar(40) not null,
cidade varchar (40) not null,
)

create table tblPermissao(
id_permissao int not null primary key,
descr varchar(60)
)

create table tblFuncionario (
id_func int not null primary key identity(1,1),
nome varchar(50) not null,
CPF varchar (20) not null,
RG varchar (20) not null,
endereco varchar(200) not null,
bairro varchar (200) not null,
cidade varchar(200) not null,
telefone varchar(20),
celular varchar(20) not null,
datanasc date not null,
email varchar(30) not null,
cargo varchar(30) not null,
--salario decimal(10,2), 
usuario varchar(20) not null,
senha varchar(20) not null,
id_permissao int foreign key references tblPermissao(id_permissao) 
)

create table tblEstoque (
	idEstoque int not null primary key identity(1,1),
	nome_estoque varchar(50) not null,
	cidade varchar(20) not null,
	estado varchar(20) not null,
	pais varchar(20) not null,
	bairro varchar(20) not null,
	endereco varchar (200) not null,
	CEP varchar(10) not null,
	telefone varchar(20) not null,
	quant_total decimal(5,0) not null
)

create table tblCategoria (
	id_categoria int not null primary key identity(1,1),
	descr_material varchar(50) not null
)

create table tblMaterial (
	idMaterial int not null primary key identity(1,1),
	nome_material varchar(50) not null,
	quantidade decimal(4,0) not null,
	id_categoria int foreign key references tblCategoria(id_categoria),
	idEstoque int foreign key references tblEstoque(idEstoque)
	--id_forn int foreign key references tblFornecedor(id_forn)
)

create table tblPedido (
	id_ped int not null primary key identity(1,1),
	id_cli int foreign key references tblCliente(id_cli),
	id_func int foreign key references tblFuncionario(id_func),
	ped_status varchar(20) not null,
	dataped date not null,
	dataentrega date not null
)

create table tblDetalhePed (
	id_ped int not null foreign key references tblPedido(id_ped),
	idMaterial int foreign key references tblMaterial(idMaterial),
	qtde int not null
)

insert into tblEstoque values
('Estoque X','Campinas','SP','Brasil','Vila X','Rua X, 80','05040-122','19 1111-2222',0),
('Estoque Y','Rio de Janeiro','RJ','Brasil','Jardim Y','Rua Y, 150','06040-122','21 2222-3333',0),
('Estoque Z','São Paulo','SP','Brasil','Cidade Z','Rua Z, 400','07040-122','11 3333-4444',0)

insert into tblPermissao values
('1','Gerente'),
('2','Colaborador'),
('3','Funcionario')

insert into tblCategoria values
('Eletrônica'),
('Mecânica')

insert into tblMaterial values
('CABO MICRO USB',	10,	1, 1),
('CABO USB-C',	1,	1, 1),
('CABO USB M/M',	2,	1, 1),
('CARTÃO MICRO SD',	14,	1, 1),
('CHIP ARQIA DISPONÍVEL',	2, 1, 	1),
('CHIP ARQIA RESERVA',	3,	1, 1),
('CHIP VIVO EMPRESA',	2,	1, 1),
('CONECTOR USB',	21,	1, 1),
('CONECTOR WAGO',	19,	1, 1),
('COOLER',	10,	1, 1),
('DS3231',	7,	1, 1),
('FECHADURA',	173,	1, 1),
('FILTRO DE LINHA',	7,	1, 1),
('FONTE 12V COLMEIA',	13,	1, 1),
('FONTE 12V P4',	2,	1, 1),
('FONTE 5V',	8,	1, 1),
('PCA9685',	12,	1, 1),
('PCF8574',	11,	1, 1),
('PLUGUE DE TOMADA 2P F',	6,	1, 1),
('PLUGUE DE TOMADA 2P M',	12,	1, 1),
('PLUGUE DE TOMADA 3P F',	13,	1, 1),
('PLUGUE DE TOMADA 3P M',	21,	1, 1),
('RASPBERRY',	10,	1, 1),
('RELÊ 1X',	24,	1, 1),
('RELÊ 8X',	27,	1, 1),
('BANDEJA ELETRÔNICA',	10,	2, 1),
('BASE BANDEJA',	8,	2, 1),
('BASE FECHADURA G3',	4,	2, 1),
('BASE FECHADURA G5',	3,	2, 1),
('BASE FECHADURA GG',	5,	2, 1),
('BASE FECHADURA M',	5,	2, 1),
('BASE FECHADURA P',	24,	2, 1),
('CHAPINHA TETO',	10,	2, 1),
('FECHADURA PAPAIZ 131224',	35,	2, 1),
('FECHADURA PAPAIZ',	17,	2, 1),
('FRENTE TABLET',	6,	2, 1),
('GABINETE S/ PORTAS',	0,	2, 1),
('LINGUETA FECHADURA',	13,	2, 1),
('PÉS',	4,	2, 1),
('PORTA G3',	4,	2, 1),
('PORTA G5',	5,	2, 1),
('PORTA M',	4,	2, 1),
('PORTA P',	21,	2, 1),
('PRATELEIRA',	25,	2, 1),
('SUPORTE FIXADOR CABOS',	24,	2, 1),
('SUPORTE USB',	9,	2, 1),
('TAMPA FECHADURA G3',	4,	2, 1),
('TAMPA FECHADURA G5',	4,	2, 1),
('TAMPA FECHADURA GG',	5,	2, 1),
('TAMPA FECHADURA M',	1,	2, 1),
('TAMPA FECHADURA P',	23,	2, 1),
('TAMPÃO FUNDO',	4,	2, 1),
('TAMPÃO PISO',	3,	2, 1),
('TRANCA FECHADURA',	4,	2, 1)

insert into tblCliente values
('José Pereira','000.000.000-00','00.000.000-0','00000000','000000000','08/06/2000','josepereira@gmail.com','Rua A, 00','Bom Retiro','São Paulo'),
('Thiago Souza','111.111.111-11','11.111.111-1','11111111','111111111','23/09/2001','thiagosouza@gmail.com','Rua B, 11','Bom Retiro','São Paulo')

insert into tblFuncionario values
('Denilson Ferreira','333.333.333-33','33.333.333-3','Rua D, 33','Bom Retiro','São Paulo','333333333','333333333','01/01/1991','denilsonferreira@gmail.com','Gerente','DenilsonFerreira','333',1),
('Gilberto de Oliveira','444.4444.444-44','44.444.444-4','Rua E, 44','Bom Retiro','São Paulo','44444444','444444444','01/01/1991','gilbertodeoliveira@gmail.com','Colaborador','GilbertoOliveira','444',2),
('Lucas de Freitas','555.555.555-55','55.555.555-5','Rua F, 55','Bom Retiro','São Paulo','555555555','555555555','01/01/1991','lucasdefreitas@gmail.com','Atendente','LucasFreitas','555',3)

Select * from tblCliente

Select * from tblCategoria

Select * from tblPermissao

Select * from tblDetalhePed

Select * from tblPedido

delete from tblPedido

Select * from tblEstoque

Select * from tblFuncionario

Select * from tblMaterial

