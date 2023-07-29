CREATE PROCEDURE [dbo].[spItem_update]
	@id int,
	@name NVARCHAR(20), 
	@code NVARCHAR(20), 
	@Brand NVARCHAR(20), 
	@unitPrice NVARCHAR (20)
AS
begin
	UPDATE Item
	SET Name = @name, Code = @code, Brand = @Brand, UnitPrice = @unitPrice
	WHERE OrderID = @id
end
