1.
create table students
(
    id int primary key not null,
    name text not null,
    gender text not null,
    age int not null
);    

2.
insert into students(id,name,gender,age) values(0908016101,'����','��',22);
insert into students(id,name,gender,age) values(0908016110,'������','Ů',20);
insert into students(id,name,gender,age) values(0908016111,'����','Ů',21);

3
select name from students
where gender = 'Ů';
4 
update students
set age = 18
where gender = 'Ů';

5 
delete from students 
where gender = '��';