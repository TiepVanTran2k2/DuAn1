-- ****** SimpleForMe ******

-- INGREDIENT
-- Get Ingredient
if OBJECT_ID ('sp_GetIngredient') is not null 
drop proc sp_GetIngredient
go 
create proc sp_GetIngredient
as
begin
    SELECT Id_ingredient, Name, Id_supplier, Id_type, Price, mass, Id_unit
    FROM Ingredients
end
go

-- Insert Ingredient
if OBJECT_ID ('sp_IngredientInsert') is not null 
drop proc sp_IngredientInsert
go 
create PROCEDURE sp_IngredientInsert (@Name nvarchar(100),
									  @Id_supplier int,
									  @Id_type int,
								 	  @Price float,
									  @Mass real,
									  @Id_unit int)
										
AS
  BEGIN
		insert into Ingredients(Name,Id_supplier,Id_type,Price,mass, Id_unit)
		values(@Name,@Id_supplier,@Id_type,@Price,@Mass,@Id_unit)
	END


-- Update Ingredient
if OBJECT_ID ('sp_IngredientUpdate') is not null 
drop proc sp_IngredientUpdate
go 
create PROCEDURE sp_IngredientUpdate(@Name nvarchar(100),
									  @Id_supplier int,
									  @Id_type int,
								 	  @Price float,
									  @Mass real,
									  @Id_unit int,
									  @Id_ingredient int)
AS
  BEGIN
		update Ingredients
		set Name = @Name,
			Id_supplier = @Id_supplier,
			Id_type = @Id_type,
			Price = @Price,
			mass = @Mass,
			Id_unit = @Id_unit
		where Id_ingredient = @Id_ingredient
	END


