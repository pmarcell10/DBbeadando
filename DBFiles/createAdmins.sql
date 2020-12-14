drop table admins;
create table admins
(
    id int not null,
    username varchar2(255) not null,
    password varchar2(255) not null,
    
    constraint pk_admins primary key(id)
);
    