use CaloriesCalculate;
go
create trigger Users_Created
on Users
after insert
as
insert into Users_Setting values ((select id from inserted), null, null, null, null)

go
create trigger Users_DishesAdd
on Users_Dishes
after insert
as
	Declare @proteins int, @fats int, @carbohydrates int, @calories int;
	set @proteins = (select proteins from Dishes where id=(select id_dish from inserted))
	set @fats = (select fats from Dishes where id=(select id_dish from inserted))
	set @carbohydrates = (select carbohydrates from Dishes where id=(select id_dish from inserted))
	set @calories = (select calories from Dishes where id=(select id_dish from inserted))
if (SELECT COUNT(id) FROM Dayily_Stats WHERE id_user = (select id_user from inserted) and [date] = (select [date] from inserted)) > 0
begin
	Print 'tut'
	Update Dayily_Stats 
	set proteins += @proteins,
	fats += @fats,
	carbohydrates += @carbohydrates,
	calories += @calories
	where id_user = (select id_user from inserted)
	return
end
else
insert into Dayily_Stats values ((select id_user from inserted), (select [date] from inserted), 0, @proteins, @fats, @carbohydrates, @calories)

go 

create trigger IngredientsAddInDishes
on Dishes_Ingredients
after insert
as
Declare @proteins int, @fats int, @carbohydrates int, @calories int;
set @proteins = (select proteins from Ingredients where id=(select id_ingredient from inserted))
set @fats = (select fats from Ingredients where id=(select id_ingredient from inserted))
set @carbohydrates = (select carbohydrates from Ingredients where id=(select id_ingredient from inserted))
set @calories = (select calories from Ingredients where id=(select id_ingredient from inserted))
Update Dishes 
set proteins += @proteins,
fats += @fats,
carbohydrates += @carbohydrates,
calories += @calories
where id = (select id_dish from inserted)

go

create trigger IngredientsDeleteInDishes
on Dishes_Ingredients
after delete
as
Declare @proteins int, @fats int, @carbohydrates int, @calories int;
set @proteins = (select proteins from Ingredients where id=(select id_ingredient from deleted))
set @fats = (select fats from Ingredients where id=(select id_ingredient from deleted))
set @carbohydrates = (select carbohydrates from Ingredients where id=(select id_ingredient from deleted))
set @calories = (select calories from Ingredients where id=(select id_ingredient from deleted))
Update Dishes 
set proteins = proteins - @proteins,
fats = fats - @fats,
carbohydrates = carbohydrates - @carbohydrates,
calories = calories - @calories
where id = (select id_dish from deleted)