create database CaloriesCalculate;
go
use CaloriesCalculate;

create table Users (
id int Identity(1,1) primary key,
[login] varchar(30),
)

create table Categories (
id int Identity(1,1) primary key,
[name] varchar(50)
)

create table Statuses(
id int Identity(1,1) primary key,
[name] varchar(50),
[value] int
)

insert into Statuses values ('Похудеть', 1500),('Набрать вес', 2500)

create table Users_Setting (
id int Identity(1,1) primary key,
[user_id] int references Users(id),
[status_id] int references Statuses(id),
[weight] int,
[height] int,
[age] int
)
select * from Users_Setting join Statuses on Users_Setting.status_id = Statuses.id where user_id=1

create table Ingredients (
id int Identity(1,1) primary key,
[name] varchar(30),
[weight] int,
calories decimal(7,2),
proteins decimal(7,2),
fats decimal(7,2),
carbohydrates decimal(7,2)
)

create table Dishes (
id int Identity(1,1) primary key,
id_category int references Categories(id) on delete cascade,
[name] varchar(30),
proteins decimal(7,2) default 0,
fats decimal(7,2) default 0,
carbohydrates decimal(7,2) default 0,
calories decimal(7,2) default 0
)

create table Dishes_Ingredients (
id int Identity(1,1) primary key,
id_ingredient int references Ingredients(id) on delete cascade,
id_dish int references Dishes(id) on delete cascade
)

create table Users_Dishes (
id int Identity(1,1) primary key,
id_user int references Users(id) on delete cascade,
id_dish int references Dishes(id) on delete cascade,
[date] date
)

create table Dayily_Stats (
id int Identity(1,1) primary key,
id_user int references Users(id) on delete cascade,
[date] date,
water int,
proteins decimal(7,2),
fats decimal(7,2),
carbohydrates decimal(7,2),
calories decimal(7,2)
)