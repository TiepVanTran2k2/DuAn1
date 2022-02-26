-- Delete Ingredient
if OBJECT_ID ('sp_IngredientDelete') is not null 
drop proc sp_IngredientDelete
go 
create PROCEDURE sp_IngredientDelete(@Id_ingredient int)
AS
	BEGIN
		if not exists(select Id_Ingredient from InputBillsDetaill where Id_Ingredient = @Id_ingredient)
		delete Ingredients
		where Id_ingredient = @Id_ingredient
	END
-- exec sp_IngredientDelete 1
-----------------------------
-- Delete Type of Ingredient
if OBJECT_ID ('sp_TypeOfIngredientDelete') is not null 
drop proc sp_TypeOfIngredientDelete
go 
create PROCEDURE sp_TypeOfIngredientDelete(@Id_type int)
AS
	BEGIN
		if not exists(select Id_type from Ingredients where Id_type = @Id_type)
		begin
			delete TypesOfIngredient
		where Id_type = @Id_type
		end
	END
-- exec sp_TypeOfIngredientDelete 1
-----------------------------
-- Delete Supplier
if OBJECT_ID ('sp_SupplierDelete') is not null 
drop proc sp_SupplierDelete
go 
create PROCEDURE sp_SupplierDelete(@Id_supplier int)
AS
	BEGIN
		if not exists(select Id_supplier from Ingredients where Id_supplier = @Id_supplier)
		begin
			delete Suppliers
			where Id_supplier = @Id_supplier
		end
	END
-- exec sp_SupplierDelete 1