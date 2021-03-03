CREATE PROCEDURE  spAddLesson
@Name nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO dbo.Lessons VALUES(@Name); 
END
GO
