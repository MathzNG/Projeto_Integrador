-- apagar o banco de dados
drop database dblojadebolos;

-- criando banco de dados
create database dblojadebolos;

--acessar banco de dados
use dblojadebolos;

-- criando as tabelas do banco de dados
create table tbprodutos(
idProduto int not null auto_increment,
nome varchar(50),
valor decimal(9,2),
categoria varchar(50),
primary key(idProduto));
--
create table tbAgendamento(
idPedido int not null auto_increment,
nome varchar(100) not null,
endereco varchar(100) not null,
complemento varchar(100),
prazo date,
telCel char (10),
descricao varchar(100),
idProduto int not null,
primary key(idPedido),
foreign key(idProduto)references tbprodutos(idProduto)
);
--
create table tbStatuspedido(
idstatus int not null auto_increment,
idPedido int not null,
primary key(idstatus),
foreign key(idPedido)references tbAgendamento(idPedido));

--visualizando a estrutur da tabela
desc tbAgendamento;
desc tbprodutos;
desc tbStatuspedido;
--fim

