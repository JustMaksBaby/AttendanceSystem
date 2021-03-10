
CREATE PROCEDURE  spAddAttendanceInfo
	 @Date date, 
	 @StudentId int, 
	 @Lesson nvarchar(50), 
	 @Status nvarchar(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Attendance_Information(Date,StudentId, Lesson, Status)
	VALUES(@Date, @StudentId, @Lesson, @Status); 
END
GO
