--课程表
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
	pic            NVARCHAR (50) NULL,
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

--学生上课表
IF OBJECT_ID ('dbo.YW_Course_Join') IS NOT NULL
	DROP TABLE dbo.YW_Course_Join
GO

CREATE TABLE dbo.YW_Course_Join
	(
	Id             INT IDENTITY NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL, 
	planId         INT NOT NULL,
	status         INT NOT NULL,
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

--计划表
IF OBJECT_ID ('dbo.YW_Course_Plan') IS NOT NULL
	DROP TABLE dbo.YW_Course_Plan
GO

CREATE TABLE dbo.YW_Course_Plan
	(
	Id             INT IDENTITY NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	name           NVARCHAR (50) NULL,
	content        NVARCHAR (500) NULL, 
	type           NVARCHAR (10) NULL,
	pic            NVARCHAR (50) NULL,
	video          NVARCHAR (50) NULL,
	study          NVARCHAR (50) NULL,
	test           NVARCHAR (50) NULL, 
	planTime       DATETIME NOT NULL,
	startTime      DATETIME NOT NULL,
	finishTime     DATETIME NOT NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,  
	status         INT NOT NULL,
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Course_Plan PRIMARY KEY (Id)
	)
GO

--评论表
IF OBJECT_ID ('dbo.YW_Comment') IS NOT NULL
	DROP TABLE dbo.YW_Comment
GO

CREATE TABLE dbo.YW_Comment
	(
	Id             INT IDENTITY NOT NULL,
	planId         INT NOT NULL,
	planName       NVARCHAR (50) NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,
	content        NVARCHAR (500) NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,  
	status         INT NOT NULL,
	support        INT NOT NULL,
	oppose         INT NOT NULL,
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Comment PRIMARY KEY (Id)
	)
GO

--作业表
IF OBJECT_ID ('dbo.YW_Assignment') IS NOT NULL
	DROP TABLE dbo.YW_Assignment
GO

CREATE TABLE dbo.YW_Assignment
	(
	Id             INT IDENTITY NOT NULL,
	planId         INT NOT NULL,
	planName       NVARCHAR (50) NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,
	title          NVARCHAR (50) NULL, 
	content        NVARCHAR (500) NULL, 
	link           NVARCHAR (50) NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,  
	status         INT NOT NULL, 
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Assignment PRIMARY KEY (Id)
	)
GO

--资料表
IF OBJECT_ID ('dbo.YW_Course_Data') IS NOT NULL
	DROP TABLE dbo.YW_Course_Data
GO

CREATE TABLE dbo.YW_Course_Data
	(
	Id             INT IDENTITY NOT NULL,
	planId         INT NOT NULL,
	planName       NVARCHAR (50) NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,
	title          NVARCHAR (50) NULL, 
	content        NVARCHAR (500) NULL, 
	link           NVARCHAR (50) NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,  
	status         INT NOT NULL, 
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Course_Data PRIMARY KEY (Id)
	)
GO

--测试表
IF OBJECT_ID ('dbo.YW_Exam') IS NOT NULL
	DROP TABLE dbo.YW_Exam
GO

CREATE TABLE dbo.YW_Exam
	(
	Id             INT IDENTITY NOT NULL,
	planId         INT NOT NULL,
	planName       NVARCHAR (50) NOT NULL,
	courseId       INT NOT NULL,
	courseName     NVARCHAR (50) NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,
	title          NVARCHAR (50) NULL, 
	content        NVARCHAR (500) NULL, 
	link           NVARCHAR (50) NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,  
	status         INT NOT NULL, 
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Exam PRIMARY KEY (Id)
	)
GO

--题目表
IF OBJECT_ID ('dbo.YW_Exam_Question') IS NOT NULL
	DROP TABLE dbo.YW_Exam_Question
GO

CREATE TABLE dbo.YW_Exam_Question
	(
	Id             INT IDENTITY NOT NULL,
	examId         INT NOT NULL,
	type           INT NOT NULL, 
	pic            NVARCHAR (50) NOT NULL,
	score          FLOAT NOT NULL,
	chance1        NVARCHAR (500) NULL, 
	chance2        NVARCHAR (500) NULL, 
	chance3        NVARCHAR (500) NULL, 
	chance4        NVARCHAR (500) NULL, 
	chance5        NVARCHAR (500) NULL, 
	content        NVARCHAR (500) NULL, 
	chanceAnswer   NVARCHAR (50) NULL,  
	objectAnswer   NVARCHAR (500) NULL,  
	objectPic      NVARCHAR (50) NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,   
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Exam_Question PRIMARY KEY (Id)
	)
GO

--答题表
IF OBJECT_ID ('dbo.YW_Exam_Answer') IS NOT NULL
	DROP TABLE dbo.YW_Exam_Answer
GO

CREATE TABLE dbo.YW_Exam_Answer
	(
	Id             INT IDENTITY NOT NULL,
	examId         INT NOT NULL,
	questionId     INT NOT NULL,
	type           INT NOT NULL,  
	score          FLOAT NOT NULL,  
	chanceAnswer   NVARCHAR (50) NULL,  
	objectAnswer   NVARCHAR (500) NULL,  
	objectPic      NVARCHAR (50) NULL,  
	result         INT NULL, 
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,   
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Exam_Answer PRIMARY KEY (Id)
	)
GO

--成绩表
IF OBJECT_ID ('dbo.YW_Exam_Score') IS NOT NULL
	DROP TABLE dbo.YW_Exam_Score
GO

CREATE TABLE dbo.YW_Exam_Score
	(
	Id             INT IDENTITY NOT NULL,
	examId         INT NOT NULL, 
	score          FLOAT NOT NULL,
	studentName    NVARCHAR (20) NOT NULL,
	studentId      INT NOT NULL,  
	createTime     DATETIME NOT NULL,
	updateTime     DATETIME NOT NULL,
	createUserName NVARCHAR (20) NOT NULL,
	createUserId   INT NOT NULL,
	updateUserName NVARCHAR (20) NOT NULL,
	updateUserId   INT NOT NULL,   
	Alternate1     NVARCHAR (50) NULL,
	Alternate2     NVARCHAR (50) NULL,
	Alternate3     NVARCHAR (50) NULL,
	Alternate4     NVARCHAR (50) NULL,
	Alternate5     NVARCHAR (50) NULL 
	CONSTRAINT PK_YW_Exam_Score PRIMARY KEY (Id)
	)
GO