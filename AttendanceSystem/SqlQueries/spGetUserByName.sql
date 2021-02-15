USE [AttendanceDb]
GO
/****** Object:  StoredProcedure [dbo].[spGetUserByName]    Script Date: 15.02.2021 18:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spGetUserByName]
	@Name nvarchar(20)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT Password as HashedPassword, Salt FROM UsersPasswords 
	WHERE Name=@Name; 

END
