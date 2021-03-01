CREATE PROCEDURE spCheckGroupExists
	@Name nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT COUNT(*) FROM Groups
	WHERE Name=@Name; 
    
END
GO
