CREATE PROCEDURE spCheckLessonExists
	@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select COUNT(*) FROM dbo.Lessons
	WHERE Name = @Name; 
END
GO
