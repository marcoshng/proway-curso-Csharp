CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	quantidade INT,
	preco_unitario DECIMAL(13, 2)
);


SELECT * FROM produtos;

CREATE TABLE clientes (
id int primary key identity(1,1),
nome varchar (100) not null,
cpf varchar(14) not null,

estado CHAR(2) not null,
cidade varchar(100) not null,
bairro varchar(40) not null,
logradouro varchar(50) not null,
numero varchar(10) not null,
complemento text
);

alter table clientes add data_nascimento datetime2 not null; 
alter table clientes add cep char(9) not null;