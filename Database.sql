USE [PracticalTest]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 06-09-2017 01:08:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [bigint] IDENTITY(1,1) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 06-09-2017 01:08:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserService]    Script Date: 06-09-2017 01:08:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserService](
	[UserId] [bigint] NOT NULL,
	[ServiceId] [bigint] NOT NULL,
 CONSTRAINT [PK_UserService] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Service] ON 

GO
INSERT [dbo].[Service] ([ServiceId], [CreateDate], [Name]) VALUES (1, CAST(0x07D057DC8D0E403D0B AS DateTime2), N'Information Technology')
GO
INSERT [dbo].[Service] ([ServiceId], [CreateDate], [Name]) VALUES (2, CAST(0x071011D9BA0E403D0B AS DateTime2), N'Marketing and Sales')
GO
INSERT [dbo].[Service] ([ServiceId], [CreateDate], [Name]) VALUES (3, CAST(0x07A01180DD0E403D0B AS DateTime2), N'FINANCE')
GO
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([UserId], [CreateDate], [FullName], [IsActive]) VALUES (3, CAST(0x07100465690E403D0B AS DateTime2), N'MEHUL BHALALA', 1)
GO
INSERT [dbo].[User] ([UserId], [CreateDate], [FullName], [IsActive]) VALUES (4, CAST(0x070000000000413D0B AS DateTime2), N'Vikas', 1)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
INSERT [dbo].[UserService] ([UserId], [ServiceId]) VALUES (3, 1)
GO
INSERT [dbo].[UserService] ([UserId], [ServiceId]) VALUES (3, 2)
GO
INSERT [dbo].[UserService] ([UserId], [ServiceId]) VALUES (3, 3)
GO
ALTER TABLE [dbo].[UserService]  WITH CHECK ADD  CONSTRAINT [FK_UserService_Service_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserService] CHECK CONSTRAINT [FK_UserService_Service_ServiceId]
GO
ALTER TABLE [dbo].[UserService]  WITH CHECK ADD  CONSTRAINT [FK_UserService_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserService] CHECK CONSTRAINT [FK_UserService_User_UserId]
GO
