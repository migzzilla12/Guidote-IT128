CREATE PROCEDURE [dbo].[spItem_get]
	@id int
AS
begin
	set nocount on;
	SELECT [i].[OrderID], [i].[Code], [i].[Name] , [i].[Brand] , [i].[UnitPrice] , [i].[DateOrdered]
	from dbo.Item i
	where i.OrderID = @id;
end
