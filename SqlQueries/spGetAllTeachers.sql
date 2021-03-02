
CREATE PROCEDURE spGetAllTeachers

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON

	SELECT DISTINCT Id, FirstName, LastName, Patronymic, SystemStatus 
	FROM dbo.Teachers; 

END
GO
