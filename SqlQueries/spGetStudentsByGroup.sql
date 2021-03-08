CREATE PROCEDURE spGetStudentsByGroup
	@GroupName nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SELECT FirstName + ' ' + LastName + COALESCE(Patronymic, ' ') as FullName
	FROM dbo.Students
	WHERE GroupId  = @GroupName; 
END
GO
