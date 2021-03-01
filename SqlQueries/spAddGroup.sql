
CREATE PROCEDURE dbo.spAddGroup
	@Name nvarchar(20), 
	@CuratorId int 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Groups VALUES(@Name, @CuratorId)

END

