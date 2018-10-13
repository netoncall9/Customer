USE [Employee]
GO

CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	Name [varchar](59) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]





/****** Object:  Table [dbo].[Customer]    Script Date: 10/12/2018 7:37:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](59) NOT NULL,
	[LastName] [varchar](59) NOT NULL,
	[DepartmentId] INT NOT NULL
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [Customer] ADD CONSTRAINT FK_DepartmentID_Department FOREIGN KEY(DepartmentId) REFERENCES [Department](ID)

GO

SET ANSI_PADDING OFF
GO


INSERT INTO Department values('HR1')
INSERT INTO Department values('HR2')
INSERT INTO Department values('HR3')
INSERT INTO Department values('HR4')
INSERT INTO Department values('HR5')