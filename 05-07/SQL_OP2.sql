
--Question 1.a--
USE Fsoft_Training
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='EMPLOYEE')
BEGIN
     drop table EMPLOYEE
END
GO
--Create table EMPLOYEE--
CREATE TABLE EMPLOYEE(
	EmpNo			int IDENTITY(1,1) PRIMARY KEY
,	EmpName			nvarchar(50) NOT NULL
,	BirthDay			Date	NOT NULL
,	DeptNo				bit		NOT NULL
,	MgrNo				int		NOT NULL
,	StartDate			Date	NOT NULL
,	Salary				int		NOT NULL
,	Level_Emp			int		NOT NULL
,	Status_Emp			int		NOT NULL
,	Note			nvarchar(max)
)


--Question 1.d--
USE Fsoft_Training
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='EMP_SKILL')
BEGIN
     drop table EMP_SKILL
     print(1)
END
GO
--Create table EMP_SKILL--
CREATE TABLE EMP_SKILL(
	SkillNo				int		NOT NULL
,	EmpNo				int		NOT NULL
,	SkillLevel			int		NOT NULL
,	RegDate				Date	NOT NULL
,	Description			nvarchar(max)
	PRIMARY KEY(SkillNo, EmpNo)
)

--Question 1.b--
USE Fsoft_Training
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='SKILL')
BEGIN
     drop table SKILL
     print(1)
END
GO
--Create table SKILL--
CREATE TABLE SKILL(
	SkillNo			int IDENTITY(1,1) PRIMARY KEY
,	SkillName		nvarchar(50)		NOT NULL
,	Note			nvarchar(max)
)

--Question 1.c--
USE Fsoft_Training
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='DEPARTMENT ')
BEGIN
     drop table DEPARTMENT 
     print(1)
END
GO
--Create table DEPARTMENT --
CREATE TABLE DEPARTMENT (
	DeptNo			int IDENTITY(1,1) PRIMARY KEY
,	SkillName		nvarchar(50)		NOT NULL
,	Note			nvarchar(max)
)

--Question 2: Add Field Email to EMPLOYEE
USE Fsoft_Training
GO
ALTER TABLE EMPLOYEE
ADD Email nvarchar(50) UNIQUE;

--Modify  Field MgrNo to EMPLOYEE
USE Fsoft_Training
GO
ALTER TABLE EMPLOYEE
ADD DEFAULT 0 FOR MgrNo  ;

ALTER TABLE EMPLOYEE
ADD DEFAULT '0' FOR Status_Emp  ;

--Question 3: --
ALTER TABLE EMPLOYEE 
ADD CONSTRAINT FK_DEPARTMENTEMPLOYEE
FOREIGN KEY (DeptNo ) REFERENCES DEPARTMENT (DeptNo);

--	Remove the Description field 
ALTER TABLE EMP_SKILL
DROP COLUMN Description 

--Question 4:
USE Fsoft_Training
GO
CREATE VIEW EMPLOYEE_TRACKING
AS
SELECT EmpNo, EmpName, Level_Emp
FROM EMPLOYEE
WHERE Level_Emp IN (3,4,5)
