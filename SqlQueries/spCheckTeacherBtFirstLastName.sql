
CREATE PROCEDURE  spCheckTeacherByFirstLastName
	@FirstName nvarchar(20), 
	@LastName nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT Count(*) FROM Teachers
	WHERE FirstName=@FirstName AND LastName=@LastName
END
GO
