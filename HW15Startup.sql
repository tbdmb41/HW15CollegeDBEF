IF EXISTS (SELECT * FROM sys.databases WHERE name = 'KeysDemoDB')
 DROP DATABASE KeysDemoDB
 GO
DROP DATABASE KeysDemoDB
GO
Use KeysDemoDB
Go
CREATE TABLE Parents(
ID int identity(1,1) Not Null CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED, 
ParentName varchar(30) Not Null
)
CREATE TABLE Children(
ID INT IDENTITY(1,1) Not null CONSTRAINT [PK_Children] PRIMARY KEY CLUSTERED, 
ChildName VARCHAR(30) Not Null,
ParentsID int Not Null CONSTRAINT FK_Children_Parents FOREIGN KEY (ParentsID)     
    REFERENCES dbo.Parents(ID)
)  
CREATE INDEX IX_Parents_ParentName ON dbo.Parents (ParentName);   

INSERT INTO Parents(ParentName) VALUES ('Jabril Dad'),('Homer Dad')

INSERT INTO Children(ChildName, ParentsID) 
WALUES ('The Dude', 1),
       ('Carter Beauford',  1),
	   ('Bennie Jetts', 2)

CREATE TABLE STUDENTS  (
ID int IDENTITY (1,1) NOT NULL,
Fname VARCHAR '30' NOT NULL,
Lname VARCHAR '30' NOT NULL,
SSN int NOT NULL,
Address VARCHAR '30' NOT NULL
City VARCHAR '30' NOT NULL
State VARCHAR '30' NOT NULL
Zip int NOT NULL
Phone int NOT NULL
);

CREATE TABLE Classes (
ID int IDENTITY (1,1) NOT NULL
CONSTRAINT [pk_Classes] PRIMARY KEY CLUSTERED,
StudentID int NOT NULL
FOREIGN KEY (StudentID) REFERENCES (StudentsID),
TITLE VARCHAR (50) NOT NULL
NUMBER int NOT NULL
DEPARTMENT VARCHAR '30' NOT NULL
);

DROP TABLE Scores

CREATE TABLE Scores (
ID int IDENTITY (1,1) NOT NULL
CONSTRAINT [pk_Scores] PRIMARY KEY CLUSTERED, 
ClassesID int NOT NULL
FOREIGN KEY (ClassesID) REFERENCES Classes(ID),
TYPE VARCHAR (15) NOT NULL
DESCRIPTION VARCHAR '65' NOT NULL,
[Date SUBMITTED] DATETIME NOT NULL,
[Date ASSIGNED] DATETIME NOT NULL,
[POINTS EARNED] DATETIME NOT NULL,
[POINTS POSSIBLE] int NOT NULL,
[DATE DUE] int NOT NULL
);

USE College
GO

DROP TABLE scores
CREATE TABLE scores

ID int IDENTITY (1,1) NOT NULL
CONSTRAINT [pk_scores] PRIMARY KEY CLUSTERED 
ClassesID int NOT NULL
FOREIGN KEY Classes Id REFERENCES Classes Id
TYPE VARCHAR '25' NOT NULL
DESCRIPTION VARCHAR '25' NOT NULL,

[Class Type] VARCHAR NOT NULL
[Points Earned] int NOT NULL
[Points Possible] int NOT NULL
[Date Due] DATETIME NOT NULL
);

USE COLLEGE 
GO
INSERT INTO Students(Fname, LName, [Address] Phone, City, [State], Zip, )
VALUES ('The', 'Dude', '32 The Dude Abides Lane', 215-844-	7777, Dudeville, )

INSERT INTO Students(Fname, LName, [Address] Phone, City, [State], Zip, )
VALUES ('Carter', 'Beauford', '8600 Pickle Thrower Way', 654-897-4125, Ginger,)
	
INSERT INTO Students(Fname, LName, [Address] Phone, City, [State], Zip,)
VALUES ('Bennie', 'Jetts', '25 Old Time Way"', 225-478-9654, Charlottesville,)

USE COLLEGE
GO
INSERT INTO [Scores], [Date Assigned], [Description], [Date Submitted], [Points Possiblle], [Points Earned},
VALUES ('12'), '4-6-2018', 'Test'  'Average', '2-1-2018', '18', '12',);

INSERT INTO [Scores], [Date Assigned], [Description], [Date Submitted], [Points Possiblle], [Points Earned},
VALUES ('20'), '8-19-2018', 'Quiz', 'Excellent', '8-17-2018', '20', '20',);

INSERT INTO [Scores], [Date Assigned], [Description], [Date Submitted], [Points Possible], [Points Earned]},
VALUES '41', '8-12-2013', 'Exam', 'Below Average', '2-14-2014', '41', '75',);


USE College 
GO
INSERT INTO Classes, StudentId, Title, Department, Number)
VALUES '16', 'Hold On Tight', '64', 'Bull Riding');

INSERT INTO Classes, StudentId, Title, Department, Number)
VALUES '65', 'Fighting a Tornado', '342', 'Weather 101');

INSERT INTO Classes, StudentId, Title, Department, Number)
VALUES '44', 'Bring a Change of Clothes', '112', 'Delivering Baby Skunks');

INSERT INTO Classes, StudentId, Title, Department, Number)
VALUES '22', 'FIGure It Out', 110, 'How to Grow Figs Properly');

SELECT * FROM Classes

USE College
GO

SELECT *
FROM Students 
INNER JOIN Classes ON Students.ID = Classes.StudentId
INNER JOIN Scores ON Scores.ClassesID = Classes.ID









































