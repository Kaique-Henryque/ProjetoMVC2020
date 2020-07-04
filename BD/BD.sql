create database ProjetoMVCD26;

use ProjetoMVCD26;

create table dt_clienteD26(
	id_cliente int(11) not null,
    nome_cliente varchar(45) not null,
    sobrenome_cliente varchar(45) not null,
	email_cliente varchar(50) not null,
    senha_cliente varchar(45) not null,
    cpf_cliente varchar(11) not null,
    nome_mae varchar(50)not null,
    tp_cliente int(1) not null
);

drop table dt_clienteD26;

drop database ProjetoMVCD26;

insert into dt_clienteD26() values(1,'a','a','a','a','1','a',1);

select * from dt_clienteD26 where nome_cliente = 'Kaique' && sobrenome_cliente = 'Henryque';

select * from dt_clienteD26 where cpf_cliente = '012' && nome_cliente = 'kaique' && nome_mae = 'Glaucilene';
