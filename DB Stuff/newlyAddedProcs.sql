USE [ExaminationSytem]
GO
/****** Object:  StoredProcedure [dbo].[getGradesWithID]    Script Date: 2/21/2022 9:51:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or alter proc [dbo].[getGradesWithID] @std_id int
as
begin
	select cName, grade from Std_Crs st
	inner join Course crs 
	on st.crs_ID = crs.cID and st.std_ID = @std_id
end
GO
/****** Object:  StoredProcedure [dbo].[GETStudentGrades]    Script Date: 2/21/2022 9:51:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or alter  PROCEDURE [dbo].[GETStudentGrades] @stuID INT
As
        BEGIN
			select c.cName ,CONCAT(sc.grade*10,'%') AS Grade from  Student s
			inner join Std_Crs sc on sc.std_ID = s.stuID and s.stuID =@stuID
			inner join Course c on sc.crs_ID = c.cID
		End
GO
/****** Object:  StoredProcedure [dbo].[GETStudentInDep]    Script Date: 2/21/2022 9:51:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE or alter  PROCEDURE [dbo].[GETStudentInDep] @depID INT
As
        BEGIN
			select u.firstName,u.lastName,u.email,u.sex from Userr u where u.depID=@depID and u.userType = 's';
		End
GO
