CREATE PROCEDURE dbo.spCheckUserByName 
		@Name nvarchar(20)	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	Select COUNT(Name) FROM Users
	WHERE Name = @Name; 
END
GO
