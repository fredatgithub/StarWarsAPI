USE [StarWars2]
GO

/****** Object:  Table [dbo].[Starships]    Script Date: 03/10/2020 22:22:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Starships](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Transport_ptr] [int] NOT NULL,
	[Hyperdrive_rating] [nvarchar](max) NULL,
	[MGLT] [nvarchar](max) NULL,
	[Starship_class] [nvarchar](max) NULL,
	[Pilots_PeopleId] [int] NULL,
 CONSTRAINT [PK_dbo.Starships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Starships]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Starships_dbo.People_Pilots_PeopleId] FOREIGN KEY([Pilots_PeopleId])
REFERENCES [dbo].[People] ([PeopleId])
GO

ALTER TABLE [dbo].[Starships] CHECK CONSTRAINT [FK_dbo.Starships_dbo.People_Pilots_PeopleId]
GO


