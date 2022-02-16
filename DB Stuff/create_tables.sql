create table Userr(
	id int primary key identity,
	firstName nvarchar(20),
	lastName nvarchar(20),
	email nvarchar(15) unique not null,
	userName nvarchar(15) unique not null,
	passKey nvarchar(15) not null,
	sex nvarchar(1),
	userType nvarchar(1),
	depID nvarchar(5)
	---ADD RELATION BETWEEN DEP AND USER USING WIZARD Y NAGM 
)
create table Student(
	stuID int primary key,
	gradYear date ,
	constraint c2 foreign key(stuID) references Userr(id)
)
create table Instructor(
	insID int primary key,
	salary money ,
	constraint c3 foreign key(insID) references Userr(id)
)

create table Course(
	cID int primary key identity, 
	cName nvarchar(20) unique not null,
	duration int
)

create table Topic(
topicID int primary key identity,
topicName nvarchar(20) not null,
crs_ID int foreign key references Course(cID)
)

create table Department(
	depID nvarchar(5) primary key,
	depName nvarchar(20) unique not null,
	depDescription nvarchar(50),
	ins_ID int,
	constraint c4 foreign key(ins_ID) 
	references Instructor(insID)
)
create table Ins_Crs(
	ins_ID int foreign key references Instructor(insID) ,
	crs_ID int foreign key references Course(cID),
	primary key(ins_ID,crs_ID)
)
create table Std_Crs(
  std_ID int foreign key references Student(stuID),
  crs_ID int foreign key references Course(cID),
  grade float ,
  primary key (std_ID,crs_ID)
)
--------------------------- exam , student exam
create table Question(
	questionID int primary key identity ,
	questionText nvarchar(30) not null,
	answer nvarchar(1) not null,
	qType nvarchar (3) not null--mcq ,T/F
)
create table Choices(
	q_ID int FOREIGN KEY REFERENCES Question(questionID),
	choice1 nvarchar(20) not null,
	choice2 nvarchar(20) not null,
	choice3 nvarchar(20) not null,
	choice4 nvarchar(20) not null,
	PRIMARY KEY (choice1, q_ID)
)
CREATE TABLE Exam(
	Exam_ID INT PRIMARY KEY IDENTITY,
	Exam_Date Date,
)
CREATE TABLE St_Ex_Ch(
	Std_ID INT FOREIGN KEY REFERENCES Student(stuID),
	Exam_ID INT FOREIGN KEY REFERENCES Exam(Exam_ID),
	questionID INT FOREIGN KEY REFERENCES Question(questionID),
	St_Answer nvarchar(1),
	PRIMARY KEY (Std_ID, Exam_ID, questionID)
)




