USE [09_07_As1_Q2]
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='Employee')
BEGIN
     drop table Employee
END
GO
--Create table Employee--
CREATE TABLE Employee(
	Employee_Number			int IDENTITY(1,1) PRIMARY KEY
,	Employee_Name			nvarchar(50) NOT NULL
,	Department_Number			int		NOT NULL
	FOREIGN KEY (Department_Number) REFERENCES Department (Department_Number)
	
)
GO

USE [09_07_As1_Q2]
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='Department')
BEGIN
     drop table Department
END
GO
--Create table Department--
CREATE TABLE Department(
	Department_Number		int IDENTITY(1,1) PRIMARY KEY
,	Department_Name			nvarchar(50) NOT NULL
	
)
GO




USE [09_07_As1_Q2]
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='Employee_Skill')
BEGIN
     drop table Employee_Skill
END
GO
--Create table Employee_Skill--
CREATE TABLE Employee_Skill(
	Employee_Number			int NOT NULL
,	Skill_Code				int NOT NULL
,	DateRegistered			DATE NOT NULL
	PRIMARY KEY(Employee_Number,Skill_Code),
	FOREIGN KEY (Employee_Number) REFERENCES Employee (Employee_Number),
	FOREIGN KEY (Skill_Code) REFERENCES Skill (Skill_Code)
	
)
GO

USE [09_07_As1_Q2]
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='Skill')
BEGIN
     --drop table Skill
     print('asfasdfasf')
END
GO
--Create table Skill--
CREATE TABLE Skill(
	Skill_Code				int PRIMARY KEY
,	Skill_Name				nvarchar(50) NOT NULL
	
)
GO


--2a--
SELECT e.Employee_Name
from  Employee e
	 JOIN Employee_Skill ek
	ON ek.Employee_Number= e.Employee_Number
	JOIN Skill s
	ON s.Skill_Code = ek.Skill_Code
	where s.Skill_Name='java'
	
	
--2b--
	
SELECT e.Employee_Name
FROM Employee e, (
	SELECT ek.Employee_Number
	FROM Employee_Skill ek, Skill sl
	WHERE ek.Skill_Code=sl.Skill_Code AND sl.Skill_Name='java') en
WHERE e.Employee_Number = en.Employee_Number  


--sub query chuẩn--
SELECT e.Employee_Name
FROM Employee e
where e.Employee_Number IN(
	SELECT ek.Employee_Number
	FROM Employee_Skill ek, Skill sl
	WHERE ek.Skill_Code=sl.Skill_Code AND sl.Skill_Name='java') 

--3--
SELECT Department_Name
From Department d, Employee e
where e.Department_Number = d.Department_Number
	Group by (Department_Name)
	Having COUNT(1)>=3