USE [StarWars2]
GO

/****** Object:  Table [dbo].[People]    Script Date: 03/10/2020 22:22:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[PeopleId] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Edited] [datetime] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Height] [nvarchar](max) NULL,
	[Mass] [nvarchar](max) NULL,
	[Hair_color] [nvarchar](max) NULL,
	[Skin_color] [nvarchar](max) NULL,
	[Eye_color] [nvarchar](max) NULL,
	[Birth_year] [tinyint] NOT NULL,
	[Gender] [nvarchar](max) NULL,
	[Homeworld_PlanetId] [int] NULL,
	[Starship_Id] [int] NULL,
	[Vehicle_Id] [int] NULL,
	[Transport_TransportId] [int] NULL,
 CONSTRAINT [PK_dbo.People] PRIMARY KEY CLUSTERED 
(
	[PeopleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_dbo.People_dbo.Planets_Homeworld_PlanetId] FOREIGN KEY([Homeworld_PlanetId])
REFERENCES [dbo].[Planets] ([PlanetId])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_dbo.People_dbo.Planets_Homeworld_PlanetId]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_dbo.People_dbo.Starships_Starship_Id] FOREIGN KEY([Starship_Id])
REFERENCES [dbo].[Starships] ([Id])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_dbo.People_dbo.Starships_Starship_Id]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_dbo.People_dbo.Transports_Transport_TransportId] FOREIGN KEY([Transport_TransportId])
REFERENCES [dbo].[Transports] ([TransportId])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_dbo.People_dbo.Transports_Transport_TransportId]
GO

ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_dbo.People_dbo.Vehicles_Vehicle_Id] FOREIGN KEY([Vehicle_Id])
REFERENCES [dbo].[Vehicles] ([Id])
GO

ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_dbo.People_dbo.Vehicles_Vehicle_Id]
GO


