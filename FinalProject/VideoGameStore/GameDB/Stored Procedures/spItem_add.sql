CREATE PROCEDURE [dbo].[spItem_add]
		@Code nvarchar(20),
	@Name nvarchar(50),
	@Brand nvarchar(20),
	@UnitPrice nvarchar(20),
	@dateOrdered datetime2
AS
begin
	INSERT INTO dbo.Item
	(Code, Name, Brand, UnitPrice, DateOrdered)
	VALUES
	(@Code, @Name, @Brand, @UnitPrice, @dateOrdered)

end

