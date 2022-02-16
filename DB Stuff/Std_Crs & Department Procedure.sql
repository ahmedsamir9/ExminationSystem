----------------------------------------------------Std_Crs Table------------------------------------------------------
-- Std_Crs Table Procs

-- INSERT 
CREATE PROC insert_Std_Crs @StudentID int, @CourseID int, @grade float
AS
	BEGIN TRY
		INSERT INTO Std_Crs(std_ID, crs_ID, grade)
		VALUES (@StudentID, @CourseID, @grade)
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Insert!'
	END CATCH


-- UPDATE
CREATE PROC update_Std_Crs @StudentID int, @CourseID int, @grade float
AS
	BEGIN TRY
		UPDATE Std_Crs 
		SET grade = @grade
		WHERE std_ID = @StudentID AND crs_ID = @CourseID
	END TRY
	BEGIN CATCH
		SELECT 'Failed To Update!'
	END CATCH
--

-- DELETE
CREATE PROC delete_Std_Crs @StudentID int, @CourseID int
AS
	BEGIN TRY
		DELETE FROM Std_Crs 
		WHERE std_ID = @StudentID AND crs_ID = @CourseID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH
--

-- GET
CREATE PROC select_Std_Crs @StudentID int, @CourseID int
AS
	BEGIN TRY
		SELECT * 
		FROM Std_Crs
		WHERE std_ID = @StudentID AND crs_ID = @CourseID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To Get!'
	END CATCH
--
------------------------------------------------------------------------------------------------------------------------


----------------------------------------------------Department Table------------------------------------------------------
-- Department Table Procs

-- INSERT 
CREATE PROC insert_Department @DeptID int, @DeptName nvarchar(20), @DeptDesc nvarchar(50), @InstructorID int
AS
	BEGIN TRY
		INSERT INTO Department(depID, depName, depDescription, ins_ID)
		VALUES (@DeptID, @DeptName, @DeptDesc, @InstructorID)
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Insert!'
	END CATCH


-- UPDATE
CREATE PROC update_Department @DeptID int, @DeptName nvarchar(20), @DeptDesc nvarchar(50), @InstructorID int
AS
	BEGIN TRY
		UPDATE Department 
		SET depName = @DeptName,
			depDescription = @DeptDesc,
			ins_ID = @InstructorID
		WHERE depID = @DeptID
	END TRY
	BEGIN CATCH
		SELECT 'Failed To Update!'
	END CATCH
--

-- DELETE
CREATE PROC delete_Department @DeptID int
AS
	BEGIN TRY
		DELETE FROM Department 
		WHERE depID = @DeptID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH
--

-- GET
CREATE PROC select_Department @DeptID int
AS
	BEGIN TRY
		SELECT * 
		FROM Department
		WHERE depID = @DeptID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To Get!'
	END CATCH
--
------------------------------------------------------------------------------------------------------------------------

