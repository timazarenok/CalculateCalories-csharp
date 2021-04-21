create database CaloriesCalculate;
use CaloriesCalculate;

create table Users (
id int Identity(1,1) primary key,
[login] varchar(30),
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
proteins int default 0,
fats int default 0,
carbohydrates int default 0,
calories int default 0
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
proteins int,
fats int,
carbohydrates int,
calories int
)