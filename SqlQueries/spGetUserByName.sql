
CREATE PROCEDURE dbo.spGetUserByName
	@Name nvarchar(20)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT Name, Password as HashedPassword, Salt 
	FROM dbo.UsersPasswords
	WHERE Name=@Name;
	
END
GO
