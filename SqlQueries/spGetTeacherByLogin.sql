CREATE PROCEDURE spGetTeacherByLogin
	@Login nvarchar(50) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select Teachers.Id, Teachers.FirstName, Teachers.LastName, Teachers.Patronymic
	FROM Teachers  
	JOIN LoginData ON LoginData.UserId = Teachers.Id AND Login=@Login;

END
GO
