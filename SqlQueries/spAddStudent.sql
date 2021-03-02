CREATE PROCEDURE spAddStudent
	@FirstName nvarchar(20), 
	@LastName nvarchar(20), 
	@Patronymic nvarchar(20), 
	@CardId int, 
	@GroupName nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NULLIF(@Patronymic,'') IS NULL 
		INSERT INTO dbo.Students(FirstName, LastName, StudentsCardId,GroupId) 
		VALUES(@FirstName, @LastName, @CardId, @GroupName);
	ELSE 
		INSERT INTO dbo.Students(FirstName, LastName, Patronymic, StudentsCardId,GroupId) 
		VALUES(@FirstName, @LastName, @Patronymic, @CardId, @GroupName);
END
GO
