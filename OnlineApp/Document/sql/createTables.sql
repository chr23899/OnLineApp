IF OBJECT_ID ('dbo.YW_Course') IS NOT NULL
	DROP TABLE dbo.YW_Course
GO

CREATE TABLE dbo.YW_Course
	(
	Id             INT IDENTITY NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	linkBook       NVARCHAR (50)  NOT NULL,
	teacherName    NVARCHAR (20) NOT NULL,
	teacherId      INT NOT NULL,
	content        NVARCHAR (500) NULL,
	title          NVARCHAR (50) NULL,
	span           NVARCHAR (50) NULL,
	show           NVARCHAR (10) NULL,
	courseNum      INT NULL,
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL, 
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,
	status         INT NOT NULL,
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Course PRIMARY KEY (Id)
	)
GO

IF OBJECT_ID ('dbo.YW_Course_Join') IS NOT NULL
	DROP TABLE dbo.YW_Course_Join
GO

CREATE TABLE dbo.YW_Course_Join
	(
	Id             INT IDENTITY NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL, 
	teacherName    NVARCHAR (20) NOT NULL,
	teacherId      INT NOT NULL,
	studentName    NVARCHAR (20) NOT NULL,
	studentId      INT NOT NULL,   
	lastTime       DATETIME NOT NULL, 
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Course_Join PRIMARY KEY (Id)
	)
GO

