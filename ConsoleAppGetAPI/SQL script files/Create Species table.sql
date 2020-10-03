USE [StarWars2]
GO

/****** Object:  Table [dbo].[Species]    Script Date: 03/10/2020 22:22:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Species](
	[SpeciesId] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Edited] [datetime] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Classification] [nvarchar](max) NULL,
	[Designation] [nvarchar](max) NULL,
	[Average_height] [nvarchar](max) NULL,
	[Skin_colors] [nvarchar](max) NULL,
	[Hair_colors] [nvarchar](max) NULL,
	[Eye_colors] [nvarchar](max) NULL,
	[Average_lifespan] [nvarchar](max) NULL,
	[Language] [nvarchar](max) NULL,
	[People] [nvarchar](max) NULL,
	[Homeworld_PlanetId] [int] NULL,
 CONSTRAINT [PK_dbo.Species] PRIMARY KEY CLUSTERED 
(
	[SpeciesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Species]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Species_dbo.Planets_Homeworld_PlanetId] FOREIGN KEY([Homeworld_PlanetId])
REFERENCES [dbo].[Planets] ([PlanetId])
GO

ALTER TABLE [dbo].[Species] CHECK CONSTRAINT [FK_dbo.Species_dbo.Planets_Homeworld_PlanetId]
GO


