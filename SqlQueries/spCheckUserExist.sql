CREATE PROCEDURE spCheckUserExist
	@Login nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(*) FROM dbo.LoginData
	WHERE Login=@Login; 
END
GO
