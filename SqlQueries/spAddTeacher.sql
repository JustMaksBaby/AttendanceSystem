
CREATE PROCEDURE spAddTeacher
	@Id int out,
	@FirstName nvarchar(20), 
	@Lastname  nvarchar(20),
	@Patronymic nvarchar(20),
	@SystemStatus nvarchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NULLIF(@Patronymic, '') IS NULL
		INSERT INTO dbo.Teachers(FirstName, LastName, SystemStatus) 
		VALUES(@FirstName, @Lastname, @SystemStatus) 
	ELSE
		INSERT INTO dbo.Teachers(FirstName, LastName, Patronymic, SystemStatus) 
		VALUES(@FirstName, @Lastname, @Patronymic, @SystemStatus) 
	
	
	SET @Id = SCOPE_IDENTITY(); 
END
GO
