USE [Tickets]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NULL,
	[Email] [nvarchar](150) NOT NULL,
	[User] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [text] NOT NULL,
	[Description] [text] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[ServiceType] [nvarchar](50) NOT NULL,
	[Priority] [nvarchar](50) NOT NULL,
	[CustomerName] [nvarchar](150) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ClosedAt] [datetime] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTickets]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTickets](
	[IdUser] [int] NOT NULL,
	[IdTicket] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [FirstName], [LastName], [Email], [User], [Password], [CreatedAt]) VALUES (1, N'Octavian                                          ', N'Axente                                            ', N'axente.octavian@gmail.com', N'aoctavian', N'aoctavian', CAST(N'2021-03-22T10:41:48.877' AS DateTime))
INSERT [dbo].[Account] ([Id], [FirstName], [LastName], [Email], [User], [Password], [CreatedAt]) VALUES (2, N'A                                                 ', N'A                                                 ', N'a@gmail.com', N'a', N'a', CAST(N'2021-03-22T13:43:41.050' AS DateTime))
INSERT [dbo].[Account] ([Id], [FirstName], [LastName], [Email], [User], [Password], [CreatedAt]) VALUES (3, N'Qwerty                                            ', NULL, N'qwerty@gmail.com', N'qwerty', N'qwerty', CAST(N'2021-03-22T23:13:33.470' AS DateTime))
INSERT [dbo].[Account] ([Id], [FirstName], [LastName], [Email], [User], [Password], [CreatedAt]) VALUES (5, N'b                                                 ', N'b                                                 ', N'b@gmail.com', N'b', N'b', CAST(N'2021-03-23T13:13:17.770' AS DateTime))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 

INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (2, N'Project problem login', N'LogIn button not working', N'New', N'Problem', N'FindBug', N'High', N'ABCDEF', CAST(N'2021-03-22T12:56:27.750' AS DateTime), NULL)
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (3, N'Project update', N'Account controller needs code update to current standars', N'New', N'Update', N'CodeUpdate', N'Medium', N'local', CAST(N'2021-03-22T13:10:11.483' AS DateTime), CAST(N'2021-03-22T13:10:12.000' AS DateTime))
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (4, N'Project feature implementation', N'Email notification feature implementation', N'New', N'Feature', N'FeatureRequest', N'Low', N'local', CAST(N'2021-03-22T13:44:47.257' AS DateTime), NULL)
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (5, N'Project problem 2', N'Register buton not working', N'New', N'Problem', N'FindBug', N'High', N'ABCDEF', CAST(N'2021-03-22T15:11:40.737' AS DateTime), NULL)
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (6, N'Project feature', N'SMS notification', N'In discussion', N'Feature', N'FeatureRequest', N'Very Low', N'local', CAST(N'2021-03-22T19:05:20.640' AS DateTime), NULL)
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (10, N'Project Update code to current standards', N'Code update', N'In discussion', N'Update', N'CodeUpdate', N'Medium', N'TTTTT', CAST(N'2021-03-22T22:34:26.860' AS DateTime), NULL)
INSERT [dbo].[Ticket] ([Id], [Subject], [Description], [Status], [Type], [ServiceType], [Priority], [CustomerName], [CreatedAt], [ClosedAt]) VALUES (19, N'abc', N'abc', N'In discussion', N'Problem', N'FindBug', N'High', N'abc', CAST(N'2021-03-23T12:36:05.650' AS DateTime), CAST(N'2021-03-23T12:49:05.783' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (1, 2)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (1, 3)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (1, 4)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (1, 19)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (2, 6)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (3, 5)
INSERT [dbo].[UserTickets] ([IdUser], [IdTicket]) VALUES (3, 10)
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Ticket] ADD  CONSTRAINT [DF_Ticket_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[UserTickets]  WITH CHECK ADD  CONSTRAINT [FK_UserTickets_Account] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[UserTickets] CHECK CONSTRAINT [FK_UserTickets_Account]
GO
ALTER TABLE [dbo].[UserTickets]  WITH CHECK ADD  CONSTRAINT [FK_UserTickets_Ticket] FOREIGN KEY([IdTicket])
REFERENCES [dbo].[Ticket] ([Id])
GO
ALTER TABLE [dbo].[UserTickets] CHECK CONSTRAINT [FK_UserTickets_Ticket]
GO
/****** Object:  StoredProcedure [dbo].[GetTicketPriority]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTicketPriority]
AS
BEGIN
	SELECT DISTINCT [Priority]
	FROM [Ticket]
END
GO
/****** Object:  StoredProcedure [dbo].[GetTicketServiceType]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTicketServiceType]
AS
BEGIN
	SELECT DISTINCT [ServiceType]
	FROM [Ticket]
END
GO
/****** Object:  StoredProcedure [dbo].[GetTicketStatus]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTicketStatus]
AS
BEGIN
	SELECT DISTINCT [Status]
	FROM [Ticket]
END
GO
/****** Object:  StoredProcedure [dbo].[GetTicketType]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetTicketType]
AS
BEGIN
	SELECT DISTINCT [Type]
	FROM [Ticket]
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAccount]    Script Date: 23.03.2021 13:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertAccount]
	@firstName nchar(50),
	@lastName nchar(50) = null,
	@email nvarchar(150),
	@user nvarchar(50),
	@password nvarchar(50)
AS
BEGIN
	
	DECLARE @id int = -1
	SELECT @id = [Id] FROM [Account] WHERE [User] = @user
	IF @id = -1
		BEGIN
			INSERT INTO [Account] VALUES (@firstName, @lastName, @email, @user, @password, getdate())
			PRINT 'Successfully added'
		END
	ELSE
		PRINT 'User already exists in the database'
END
GO
