create database 3C1ARTHUR3;
use 3C1ARTHUR3;

create table tbl_usuarios(
	id int not null primary key auto_increment,
    email varchar(100) not null,
    senha varchar(100) not null
)ENGINE = InnoDB;
insert into tbl_usuarios (id, email, senha) values(null,'ar', '123');
create table tbl_Carrinho(
	id 	int not null primary key auto_increment,
    nome varchar(100) not null,
    quantidade  DOUBLE not null,
    preco DOUBLE not null
)ENGINE = InnoDB;
