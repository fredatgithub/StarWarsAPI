USE [StarWars2]
GO

/****** Object:  Table [dbo].[Films]    Script Date: 03/10/2020 22:22:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Films](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Edited] [datetime] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Episode_id] [int] NOT NULL,
	[Opening_crawl] [nvarchar](max) NULL,
	[Director] [nvarchar](max) NULL,
	[Producer] [nvarchar](max) NULL,
	[Release_date] [datetime] NOT NULL,
	[Characters_PeopleId] [int] NULL,
	[Planets_PlanetId] [int] NULL,
	[Species_SpeciesId] [int] NULL,
	[Starships_Id] [int] NULL,
	[Vehicles_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Films] PRIMARY KEY CLUSTERED 
(
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Films_dbo.People_Characters_PeopleId] FOREIGN KEY([Characters_PeopleId])
REFERENCES [dbo].[People] ([PeopleId])
GO

ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_dbo.Films_dbo.People_Characters_PeopleId]
GO

ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Films_dbo.Planets_Planets_PlanetId] FOREIGN KEY([Planets_PlanetId])
REFERENCES [dbo].[Planets] ([PlanetId])
GO

ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_dbo.Films_dbo.Planets_Planets_PlanetId]
GO

ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Films_dbo.Species_Species_SpeciesId] FOREIGN KEY([Species_SpeciesId])
REFERENCES [dbo].[Species] ([SpeciesId])
GO

ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_dbo.Films_dbo.Species_Species_SpeciesId]
GO

ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Films_dbo.Starships_Starships_Id] FOREIGN KEY([Starships_Id])
REFERENCES [dbo].[Starships] ([Id])
GO

ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_dbo.Films_dbo.Starships_Starships_Id]
GO

ALTER TABLE [dbo].[Films]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Films_dbo.Vehicles_Vehicles_Id] FOREIGN KEY([Vehicles_Id])
REFERENCES [dbo].[Vehicles] ([Id])
GO

ALTER TABLE [dbo].[Films] CHECK CONSTRAINT [FK_dbo.Films_dbo.Vehicles_Vehicles_Id]
GO


