USE Fsoft_Training
GO
IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='Trainee')
BEGIN
     drop table Tranee
END
GO
--Create table Trainee--
CREATE TABLE Trainee(
	TraineeID			int IDENTITY(1,1) PRIMARY KEY
,	Full_Name			nvarchar(50) NOT NULL
,	Birth_Date			Date
,	Gender				bit
,	ET_IQ				int
,	ET_Gmath			int
,	ET_English			int
,	Training_Class		nvarchar(50)
,	Evaluation_Notes	nvarchar(max)
)
--Add feild Fsoft_Account--
ALTER TABLE Trainee
ADD Fsoft_Account nvarchar(30) UNIQUE;
--Insert 10 record--
INSERT INTO Trainee(Full_Name,Birth_Date,Gender,ET_IQ,ET_Gmath,ET_English,Training_Class,Fsoft_Account)
VALUES ('Le A','1996/04/05',0,8,9,15,'PTIT_.NET_18_05','Acb1'),
	('Le B','1996/04/05',0,9,9,16,'PTIT_.NET_18_05','Acb2'),
	('Le C','1996/04/05',0,10,8,18,'PTIT_.NET_18_05','Acb3'),
	 ('Le D','1996/04/05',0,11,7,17,'PTIT_.NET_18_05','Acb4'),
	 ('Le E','1996/04/05',0,12,10,16,'PTIT_.NET_18_05','Acb5'),
	 ('Le F','1996/04/05',0,7,8,19,'PTIT_.NET_18_05','Acb6'),
	 ('Le G','1996/04/05',0,13,11,20,'PTIT_.NET_18_05','Acb7'),
	 ('Le H','1996/04/05',0,14,12,25,'PTIT_.NET_18_05','Acb8'),
	('Le I','1996/04/05',0,15,13,30,'PTIT_.NET_18_05','Acb9'),
	 ('Le K','1996/04/05',0,8,9,15,'PTIT_.NET_18_05','Acb10')

--Create a VIEW which includes all the ET-passed trainees--

CREATE VIEW view_TrainessPassET
AS
SELECT Full_Name, Birth_Date, Gender, ET_IQ,ET_Gmath,ET_English,Training_Class, Fsoft_Account
FROM Trainee
WHERE ET_IQ + ET_Gmath>=20 AND ET_IQ>=8 AND ET_Gmath>=8 AND ET_English>=18

--Q5
USE Fsoft_Training
GO
SELECT TOP 1 *, DATEDIFF(yyyy, Birth_Date, GetDate()) as age FROM Trainee
ORDER BY LEN(Full_Name) DESC


--Exercise 2: Querying and Filtering Data
--Query 1
USE FPT
GO
SELECT ProductID, Name, Color, ListPrice
FROM Product;

--Query 2
USE FPT
GO
SELECT ProductID, Name, Color, ListPrice
FROM Product
WHERE ListPrice<>0;

--Query 3
USE FPT
GO
SELECT ProductID, Name, Color, ListPrice
FROM Product
WHERE Color is null;

--Query 4
USE FPT
GO
SELECT ProductID, Name, Color, ListPrice
FROM Product
WHERE Color!='';

--Query 5
SELECT ProductID, Name, Color, ListPrice
FROM Product
WHERE Color is null AND ListPrice<>0;

--Query 6
USE FPT
GO
SELECT Color+': '+Rtrim(Name) as 'Color  And Name'
From Product
WHERE Color is Not Null;

-- Query 7
USE FPT
GO
SELECT   Rtrim(Name)+' -- Color: '+Color as 'Name  And Color'
From Product
WHERE Color is Not Null;

-- Query 8
USE FPT
GO
SELECT   ProductID, Name
From Product
WHERE ProductID >=400 AND ProductID <=500;


-- Query 9
USE FPT
GO
SELECT   ProductID,  Name, Color
From Product
WHERE Color IN('Black','Blue');


-- Query 10
USE FPT
GO
SELECT  Name, ListPrice
From Product
WHERE Name Like 'S%';

-- Query 11
USE FPT
GO
SELECT  Name, ListPrice
From Product
WHERE Name Like 'S%' OR Name Like 'A%'
Order by Name ASC 

-- Query 12
USE FPT
GO
SELECT  Name, ListPrice
From Product
WHERE LTRIM(RTRIM(Name)) Like 'SPO%' AND LTRIM(RTRIM(Name)) NOT Like '%k'
Order by Name ASC 

--Q13
Use FPT
GO

Select distinct color from dbo.Product
GO
--Q14
Use FPT
GO
Select distinct ProductID,color from dbo.Product where ProductID is not NULL and color is not null

GO
--Q15 ?? ProductSubCategoryID 
Use FPT
GO

SELECT 
       LEFT([Name],35) AS [Name]
      , Color, ListPrice
FROM dbo.Product
WHERE Color IN ('Red','Black') 
      OR ListPrice BETWEEN 1000 AND 2000 
ORDER BY ProductID

GO

--Q16
Update dbo.Product 
set Color = 'UNKNOW'
where COlor is NULL
Select * from dbo.Product


