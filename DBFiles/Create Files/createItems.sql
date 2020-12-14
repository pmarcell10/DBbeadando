drop table items;
create table items(
	id int not null,
	name varchar2(255) not null,
	quantity int not null,
	uqid varchar2(255) not null
	
	constraint pk_items primary key(id)
);