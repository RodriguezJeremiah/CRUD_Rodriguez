maded by: Rodriguez Jeremiah James

query for the table

USE [PRACTICALDB]
GO

/****** Object:  Table [dbo].[tbl_000_Contact]    Script Date: 01/30/2024 1:49:40 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_000_Contact](
	[RecId] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [nvarchar](250) NOT NULL,
	[FirstName] [nvarchar](250) NOT NULL,
	[LastName] [nvarchar](250) NOT NULL,
	[MiddleName] [nvarchar](250) NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[LocalAddress] [nvarchar](max) NULL,
	[TelNo] [nvarchar](150) NULL,
	[MobileNo] [nvarchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_1tbl_000_Contact] PRIMARY KEY CLUSTERED 
(
	[RecId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


