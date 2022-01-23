---------------------------------------------Course Table-------------------------------------------
--Insert
create proc insertCourse @courseName nvarchar(20), @courseDuration int
as
	begin try 
		insert into Course(cName,duration)
		values (@courseName, @courseDuration)
	end try 
	begin catch 
		select 'Failed to Insert!'
	end catch 

----------------------------------------------------------------------------------------------------------
--UPDATE
Go
create proc updateCourse @courseID int, @courseName nvarchar(20), @courseDuration int
as
	begin try
		update Course 
		set cName = @courseName, duration = @courseDuration
		where cID = @courseID
	end try
	begin catch
		select 'Failed To Update!'
	end catch
----------------------------------------------------------------------------------------------------------
--DELETE
Go
create proc deleteCourse @courseID int
as
	begin try
		delete from Course 
		where cID = @courseID
	end try 
	begin catch
		select 'Falied To delete!'
	end catch

---------------------------------------------Topic Table--------------------------------------------------
--Insert
Go
create proc insertTopic @topicName nvarchar(20), @courseID int
as
	begin try 
		insert into Topic (topicName,crs_ID)
		values (@topicName, @courseID)
	end try 
	begin catch 
		select 'Failed to Insert!'
	end catch 

----------------------------------------------------------------------------------------------------------
--UPDATE
Go
create proc updateTopic @topic_ID int, @topic_Name nvarchar(20), @courseID int
as
	begin try
		update Topic 
		set topicName = @topic_Name, crs_ID = @courseID
		where topicID = @topic_ID
	end try
	begin catch
		select 'Failed To Update!'
	end catch
----------------------------------------------------------------------------------------------------------
--DELETE
Go
create proc deleteTopic @topic_ID int
as
	begin try
		delete from Topic 
		where topicID = @topic_ID
	end try 
	begin catch
		select 'Falied To delete!'
	end catch
