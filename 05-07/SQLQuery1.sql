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
ADD Fsoft_Account nvarchar(30) NOT NULL UNIQUE;
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
SELECT TOP 1 *, DATEDIFF(YYYY,Birth_Date, GETDATE()) as age FROM Trainee
ORDER BY LEN(Full_Name) DESC


--Exercise 2: Querying and Filtering Data
--Query 1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product;

--Query 2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice!=0;

--Query 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color='';

--Query 4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color!='';

--Query 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color='' AND ListPrice!=0;



