----------------------------------------------------Question Table------------------------------------------------------
-- Question Table Procs
-- INSERT
CREATE PROC insertQuestion @questionText nvarchar(150), @answer nvarchar(1), @qType nvarchar(3)
AS
	BEGIN TRY
		INSERT INTO Question (questionText, answer, qType)
		VALUES (@questionText, @answer, @qType)
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Insert!'
	END CATCH
--
-- UPDATE
Alter PROC updateQuestion @questionID INT, @questionText nvarchar(150), @answer nvarchar(1), @qType nvarchar(3)
AS
	BEGIN TRY
		UPDATE Question 
		SET questionText = @questionText, answer = @answer, qType = @qType
		WHERE questionID = @questionID
	END TRY
	BEGIN CATCH
		SELECT 'Failed To Update!'
	END CATCH
--
-- DELETE
--
CREATE PROC deleteQuestion @questionID INT
AS
	BEGIN TRY
		DELETE FROM Question 
		WHERE questionID = @questionID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH

----------------------------------------------------Choices Table------------------------------------------------------
--INSERT
ALTER PROC InsertChoices @q_ID INT, @choice1 nvarchar(20), @choice2 nvarchar(20), @choice3 nvarchar(20), @choice4 nvarchar(20)
AS
	BEGIN TRY
		IF EXISTS (SELECT * FROM Question WHERE [questionID] = @q_ID)
			INSERT INTO Choices VALUES (@q_ID, @choice1, @choice2, @choice3, @choice4)
		ELSE
			SELECT 'Failed To Insert!'
	END TRY
	BEGIN CATCH
		SELECT 'Failed To Insert!'
	END CATCH

--UPDATE 
CREATE PROC updateChoices @q_ID INT, @choice1 nvarchar(20), @choice2 nvarchar(20), @choice3 nvarchar(20), @choice4 nvarchar(20)
AS
	BEGIN TRY
		UPDATE Choices 
		SET choice1  = @choice1, choice2  = @choice2, choice3  = @choice3, choice4  = @choice4
		WHERE q_ID  = @q_ID 
	END TRY
	BEGIN CATCH
		SELECT 'Failed To Update!'
	END CATCH

-- delete
CREATE PROC deleteChoices @questionID INT
AS
	BEGIN TRY
		EXECUTE deleteQuestion @questionID

		DELETE FROM Choices
		WHERE q_ID = @questionID
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH
----------------------------------------------------Exam Table------------------------------------------------------
-- Insert
CREATE PROC insertExam @Exam_Date DATE
AS
	BEGIN TRY
		INSERT INTO Exam (Exam_Date)
		VALUES (@Exam_Date)
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Insert!'
	END CATCH

-- Update
CREATE PROC updateExma @Exam_ID INT, @Exam_Date DATE
AS
	BEGIN TRY
		UPDATE Exam 
		SET Exam_Date = @Exam_Date
		WHERE Exam_ID = @Exam_ID
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Update'
	END CATCH

-- DELETE
CREATE PROC deleteExam @Exam_ID INT
AS
	BEGIN TRY
		DELETE FROM Exam
		WHERE Exam_ID = @Exam_ID 
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH

-------------------------------------------- St_Ex_Ch ----------------------------------------------------------------
-- Insert
CREATE PROC insertStdSolveRelation @Std_ID INT, @Exam_ID INT, @questionID INT, @St_Answer NVARCHAR(1)
AS
	BEGIN TRY
		INSERT INTO [dbo].[St_Ex_Ch]
		VALUES (@Std_ID, @Exam_ID, @questionID, @St_Answer)
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Insert!'
	END CATCH
--Update
CREATE PROC updateStdSolveRelation @Std_ID INT, @Exam_ID INT, @questionID INT, @St_Answer NVARCHAR(1)
AS
	BEGIN TRY
		UPDATE [dbo].[St_Ex_Ch]
		SET St_Answer = @St_Answer 
		WHERE @Std_ID = Std_ID AND @Exam_ID = Exam_ID AND @questionID = questionID
	END TRY
	BEGIN CATCH
		SELECT 'Failed to Update!'
	END CATCH
--DELETE
CREATE PROC StdSolveRelation @Std_ID INT, @Exam_ID INT, @questionID INT
AS
	BEGIN TRY
		DELETE FROM St_Ex_Ch
		WHERE @Std_ID = Std_ID AND @Exam_ID = Exam_ID AND @questionID = questionID 
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete!'
	END CATCH
