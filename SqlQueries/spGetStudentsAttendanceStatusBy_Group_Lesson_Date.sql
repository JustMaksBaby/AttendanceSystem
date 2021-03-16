
CREATE PROCEDURE spGetStudentsAttendanceStatusBy_Group_Lesson_Date
	@GroupName nvarchar(20),
	@LessonName nvarchar(50), 
	@Date date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT attendance.*, StudentFullName
	FROM (
			SELECT Id, Students.FirstName + ' ' + Students.LastName +
				 ' ' + COALESCE(Students.Patronymic, '') AS StudentFullName
			FROM Students
			WHERE Students.GroupId = @GroupName) as students
	JOIN (
			SELECT * 
			FROM Attendance_Information
			WHERE "Date" = @Date 
				  AND Lesson = @LessonName
	     ) as attendance
		 ON  students.id = attendance.StudentId;
    

	
END
GO
