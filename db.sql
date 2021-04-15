create database CaloriesCalculate;
use CaloriesCalculate;

create table Users (
id int Identity(1,1) primary key,
[login] varchar(15),
[password] varchar(20)
)

create table Categories (
id int Identity(1,1) primary key,
[name] varchar(50)
)

create table Ingredients (
id int Identity(1,1) primary key,
[name] varchar(30),
[weight] int,
calories int,
proteins int,
fats int,
carbohydrates int
)

create table Dishes (
id int Identity(1,1) primary key,
id_category int references Categories(id) on delete cascade,
[name] varchar(30),
calories int
)

create table Dishes_Ingredients (
id int Identity(1,1) primary key,
id_ingredient int references Ingredients(id) on delete cascade,
id_dish int references Dishes(id) on delete cascade
)

insert into Ingredients values('Картошка', 100, 50, 10, 20, 30), ('Лук', 100, 20, 20, 10, 5), 
('Помидор', 100, 150, 50, 30, 25), ('Оругцы', 100, 50, 10, 20, 30), ('Банана', 100, 20, 20, 10, 15), ('Апельсин', 100, 25, 10, 15, 10)
select * from Ingredients;
insert into Categories values ('Овощи'), ('Фрукты')