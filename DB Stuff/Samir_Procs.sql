---------------------------------------------student-----------------------------------------------------------------------
----create student 
create proc insertStudent @fName nvarchar(20),@lfName nvarchar(20),@email nvarchar(15),@userName nvarchar(15)
,@password nvarchar(15), @sex nvarchar(1),@depId nvarchar(5),@gradeDate date
as   BEGIN TRY
		 INSERT INTO userr (firstName,lastName,email,userName,passKey,sex,userType
      ,depID)values (@fName,@lfName,@email,@userName,@password,@sex,'s',@depId)
	  insert into student values (IDENT_CURRENT ('userr') ,@gradeDate);
	END TRY
	BEGIN CATCH
		SELECT 'Falied To Insert'
	END CATCH

-- update student gradeDate 
create proc updateStudentGradeDate @email nvarchar(15),@newDate date
as   BEGIN TRY
		update Student set gradYear=@newDate from student s inner join userr u
		on s.stuID = u.id and u.email=@email
	END TRY
	BEGIN CATCH
		SELECT 'Falied To update'
	END CATCH

----------------------------------------------------------instructor-----------------------------------------------------------
------create 
create proc insertInstructor @fName nvarchar(20),@lfName nvarchar(20),@email nvarchar(15),@userName nvarchar(15)
,@password nvarchar(15), @sex nvarchar(1),@depId nvarchar(5),@sal money
as   BEGIN TRY
		 INSERT INTO userr (firstName,lastName,email,userName,passKey,sex,userType
      ,depID)values (@fName,@lfName,@email,@userName,@password,@sex,'i',@depId)
	  insert into instructor values (IDENT_CURRENT ('userr'),@sal);
	END TRY
	BEGIN CATCH
		SELECT 'Falied To Insert'
	END CATCH

-- update instructor salary
create proc updateinstructorSalary @email nvarchar(15),@sal money
as   BEGIN TRY
		update instructor set salary=@sal from instructor i inner join userr u
		on i.insID = u.id and u.email=@email
	END TRY
	BEGIN CATCH
		SELECT 'Falied To update'
	END CATCH
-----------------------generic--------------------------------------
create proc updateUserDepartment @email nvarchar(15),@newDepId nvarchar(5)
as   BEGIN TRY
		update userr set depID=@newDepId where email=@email
	END TRY
	BEGIN CATCH
		SELECT 'Falied To update'
	END CATCH
		------ delete
	create proc deleteUserByEmail @email nvarchar(15)
	as  BEGIN TRY
		delete from userr where email = @email 
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete'
	END CATCH
	create proc deleteUserByuserName @userName nvarchar(15)
	as  BEGIN TRY
		delete from userr where userName = @userName
	END TRY
	BEGIN CATCH
		SELECT 'Falied To delete'
	END CATCH

-------------------------------------------------
create proc insertIns_Crs @crs_ID int, @ins_ID int

as   BEGIN TRY
		 INSERT INTO Ins_Crs
   values (@ins_ID,@crs_ID)
	
	END TRY
	BEGIN CATCH
		SELECT 'Falied To Insert'
	END CATCH