USE ProjectManager
GO
Create table Projects(
	ProjectID			int IDENTITY(1,1) PRIMARY KEY
,	ProjectName			nvarchar(255) NOT NULL
,	ProjectStartDate	date NOT NULL
,	ProjectDescription	nvarchar(max)
,	ProjectDetail		nvarchar(max) NOT NULL
,	ProjectComplateOn	Date		  NOT NULL
,	ProjectManagerID	int			  NOT NULL
)


USE ProjectManager
GO
Create table Projects_Modules(
	ModuleID						int IDENTITY(1,1) PRIMARY KEY
,	ProjectID						int	 NOT NULL
,	EmployeeID						int	 NOT NULL
,	ProjectModulesDate				Date NOT NULL
,	ProjectModulesComplateOn		Date NOT NULL
,	ProjectModulesDescription		nvarchar(max)
)

USE ProjectManager
GO
Create table Employee(
	EmployeeID				int IDENTITY(1,1) PRIMARY KEY
,	EmployeeLastName		nvarchar(50) NOT NULL
,	EmployeeFisrtName		nvarchar(50) NOT NULL
,	EmployeeHireDate		Date		 NOT NULL
,	EmployeeStatus			int			 NOT NULL
,	SupervisorID			int			 NOT NULL
,	SocialSecurityNumber	int			 NOT NULL
)

USE ProjectManager
GO
Create table WorkDone(
	WorkDoneID				int IDENTITY(1,1) PRIMARY KEY
,	ModuleID				int				NOT NULL
,	WorkDoneDate			date			NOT NULL
,	WorkDoneDescription		nvarchar(max)	NOT NULL
,	WorkDoneStatus			int				NOT NULL
)


ALTER TABLE Projects
ADD FOREIGN KEY (ProjectManagerID) REFERENCES Employee(EmployeeID);

ALTER TABLE Employee
ADD FOREIGN KEY (SupervisorID) REFERENCES Employee(EmployeeID);

ALTER TABLE Projects_Modules
ADD FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID);

ALTER TABLE Projects_Modules
ADD FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);

ALTER TABLE WorkDone
ADD EmployeeID int not null
ALTER TABLE WorkDone
ADD FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);

ALTER TABLE WorkDone
ADD FOREIGN KEY (ModuleID) REFERENCES Projects_Modules(ModuleID);



USE ProjectManager
GO
ALTER TABLE Projects
AlTER column ProjectComplateOn date

USE ProjectManager
GO
ALTER TABLE Projects_Modules
AlTER column ProjectModulesComplateOn date

USE ProjectManager
GO
ALTER TABLE WorkDone
AlTER column WorkDoneDescription nvarchar(max)

