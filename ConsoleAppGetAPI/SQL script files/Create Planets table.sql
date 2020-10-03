USE [StarWars2]
GO

/****** Object:  Table [dbo].[Planets]    Script Date: 03/10/2020 22:22:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Planets](
	[PlanetId] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Edited] [datetime] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Rotation_period] [nvarchar](max) NULL,
	[Orbital_period] [nvarchar](max) NULL,
	[Diameter] [nvarchar](max) NULL,
	[Climate] [nvarchar](max) NULL,
	[Gravity] [nvarchar](max) NULL,
	[Terrain] [nvarchar](max) NULL,
	[Surface_water] [nvarchar](max) NULL,
	[Population] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Planets] PRIMARY KEY CLUSTERED 
(
	[PlanetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


