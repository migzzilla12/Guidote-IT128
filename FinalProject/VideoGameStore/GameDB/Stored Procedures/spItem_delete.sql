CREATE PROCEDURE [dbo].[spItem_delete]
	@id int
AS
begin
	DELETE FROM Item WHERE OrderID = @id;
end 
