create database ProjetoMVCD26;

use ProjetoMVCD26;

create table dt_clienteD26(
	id_cliente int(11) not null,
    nome_cliente varchar(45) not null,
    sobrenome_cliente varchar(45) not null,
	email_cliente varchar(50) not null,
    senha_cliente varchar(45) not null,
    cpf_cliente varchar(11) not null,
    nome_mae varchar(45)not null,
    tp_cliente int(1) not null
);

drop table dt_clienteD26;

insert into dt_clienteD26() values(1,'Kaique','Henryque','21800146@aluno.cotemig.com.br','123','012','Glaucilene',1);

select * from dt_clienteD26 where nome_cliente = 'Kaique' && sobrenome_cliente = 'Henryque';