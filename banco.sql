create database academico;

use academico;

create table aluno
   (
   id           int          not null identity(1,1),
   matricula    varchar(15)  not null,
   dt_nascimento datetime    not null,
   nome         varchar(80)  not null,
   endereco     varchar(80)  not null,
   bairro       varchar(80)  not null,
   cidade       varchar(80)  not null,
   estado       varchar(2)  not null,
   senha        varchar(20)  not null,
   primary key  (id)
   );