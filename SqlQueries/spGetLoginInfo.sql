CREATE PROCEDURE spGetLoginInfo 
	@Login nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT Login,Password as CryptedPassword, Salt 
	FROM dbo.LoginData 
	WHERE Login=@Login; 
	
END
GO
