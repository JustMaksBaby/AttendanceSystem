CREATE PROCEDURE dbo.spAddUser 
	@Name nvarchar(20),
	@Password nvarchar(40),
	@Salt nvarchar(10)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO dbo.UsersPasswords VALUES (@Name, @Password, @Salt); 
END
GO

