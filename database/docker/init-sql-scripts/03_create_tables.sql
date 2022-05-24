USE [BLOG]
GO
USE [BLOG]
GO
/****** Object:  Table [LT_COMMON].[USERS_TYPE]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LT_COMMON].[USERS_TYPE](
	[UsersTypeNo] [int] NOT NULL,
	[TypeName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_USERS_TYPE] PRIMARY KEY CLUSTERED 
(
	[UsersTypeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [COMMON].[USERS]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [COMMON].[USERS](
	[UsersKey] [uniqueidentifier] NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[UsersTypeNo] [int] NOT NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[UsersKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_USERS_EMAIL]    Script Date: 22.03.2022 20:08:31 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_USERS_EMAIL] ON [COMMON].[USERS]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [COMMON].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_USERS_TYPE] FOREIGN KEY([UsersTypeNo])
REFERENCES [LT_COMMON].[USERS_TYPE] ([UsersTypeNo])
GO
ALTER TABLE [COMMON].[USERS] CHECK CONSTRAINT [FK_USERS_USERS_TYPE]
GO
USE [BLOG]
GO
/****** Object:  Table [LT_COMMON].[BLOG_TYPE]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LT_COMMON].[BLOG_TYPE](
	[BlogTypeNo] [int] NOT NULL,
	[BlogTypeName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_BLOG_TYPE] PRIMARY KEY CLUSTERED 
(
	[BlogTypeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [BLOG]
GO
/****** Object:  Table [CONTENT_MANAGENT].[BLOG_POST]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CONTENT_MANAGENT].[BLOG_POST](
	[BlogPostKey] [uniqueidentifier] NOT NULL,
	[PostText] [varchar](8000) NOT NULL,
	[BlogTitle] [varchar](100) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[UsersKey] [uniqueidentifier] NOT NULL,
	[BlogTypeNo] [int] NOT NULL,
 CONSTRAINT [PK_BLOG_POST] PRIMARY KEY CLUSTERED 
(
	[BlogPostKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST]  WITH CHECK ADD  CONSTRAINT [FK_BLOG_POST_BLOG_TYPE] FOREIGN KEY([BlogTypeNo])
REFERENCES [LT_COMMON].[BLOG_TYPE] ([BlogTypeNo])
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST] CHECK CONSTRAINT [FK_BLOG_POST_BLOG_TYPE]
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST]  WITH CHECK ADD  CONSTRAINT [FK_BLOG_POST_USERS] FOREIGN KEY([UsersKey])
REFERENCES [COMMON].[USERS] ([UsersKey])
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST] CHECK CONSTRAINT [FK_BLOG_POST_USERS]
GO
USE [BLOG]
GO
/****** Object:  Table [CONTENT_MANAGENT].[BLOG_COMMENTS]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CONTENT_MANAGENT].[BLOG_COMMENTS](
	[BlogCommentsKey] [uniqueidentifier] NOT NULL,
	[BlogPostKey] [uniqueidentifier] NOT NULL,
	[UsersKey] [uniqueidentifier] NOT NULL,
	[CommentTitle] [varchar](100) NOT NULL,
	[CommentText] [varchar](8000) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_BLOG_COMMENTS] PRIMARY KEY CLUSTERED 
(
	[BlogCommentsKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_COMMENTS]  WITH CHECK ADD  CONSTRAINT [FK_BLOG_COMMENTS_BLOG_POST] FOREIGN KEY([BlogPostKey])
REFERENCES [CONTENT_MANAGENT].[BLOG_POST] ([BlogPostKey])
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_COMMENTS] CHECK CONSTRAINT [FK_BLOG_COMMENTS_BLOG_POST]
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_COMMENTS]  WITH CHECK ADD  CONSTRAINT [FK_BLOG_COMMENTS_USERS] FOREIGN KEY([UsersKey])
REFERENCES [COMMON].[USERS] ([UsersKey])
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_COMMENTS] CHECK CONSTRAINT [FK_BLOG_COMMENTS_USERS]
GO
USE [BLOG]
GO
/****** Object:  Table [CONTENT_MANAGENT].[BLOG_POST_IMAGES]    Script Date: 22.03.2022 20:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [CONTENT_MANAGENT].[BLOG_POST_IMAGES](
	[BlogPostImagesKey] [uniqueidentifier] NOT NULL,
	[BlogPostKey] [uniqueidentifier] NOT NULL,
	[BlogPostImage] [image] NOT NULL,
 CONSTRAINT [PK_BLOG_POST_IMAGES] PRIMARY KEY CLUSTERED 
(
	[BlogPostImagesKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST_IMAGES]  WITH CHECK ADD  CONSTRAINT [FK_BLOG_POST_IMAGES_BLOG_POST] FOREIGN KEY([BlogPostKey])
REFERENCES [CONTENT_MANAGENT].[BLOG_POST] ([BlogPostKey])
GO
ALTER TABLE [CONTENT_MANAGENT].[BLOG_POST_IMAGES] CHECK CONSTRAINT [FK_BLOG_POST_IMAGES_BLOG_POST]
GO
