CREATE PROCEDURE [dbo].[spUsers_register]
	@username nvarchar(20),
	@password nvarchar(20)
AS
begin
	INSERT INTO dbo.users
	(Username, Password)
	VALUES
	(@username, @password)
end