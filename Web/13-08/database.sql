CREATE DATABASE ContactManager

USE ContactManager
Go

IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='users')
BEGIN
     DROP TABLE users
END
CREATE TABLE users(
	user_id		INT		PRIMARY KEY,
	user_name	VARCHAR(50),
	password	VARCHAR(30),
	createdDate	DATETIME
	
)

IF  EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES Where Table_Schema = 'dbo'  AND Table_Name ='contact')
BEGIN
     DROP TABLE contact
END
CREATE TABLE contact(
	contactid		INT		PRIMARY KEY,
	FirtName		NVARCHAR(50)	NOT NULL,	
	LastName		NVARCHAR(50)	NOT NULL,
	Category		NVARCHAR(50)	NOT NULL,
	PhoneNumber		NVARCHAR(14)	NOT NULL,
	Email			VARCHAR(100),
	Location		NVARCHAR(100),
	Favorite		BIT,
	Image			VARCHAR(200),
	UserID			INT				NOT NULL
	
)


