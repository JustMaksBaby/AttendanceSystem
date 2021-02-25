
CREATE PROCEDURE spAddLoginInfo
	@Login nvarchar(50), 
	@Password nvarchar(32),
	@Salt nchar(10), 
	@UserId int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	INSERT INTO LoginData VALUES(@Login, @Password, @Salt, @UserId); 

END
GO
