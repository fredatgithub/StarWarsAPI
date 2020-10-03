USE [StarWars2]
GO

/****** Object:  Table [dbo].[Transports]    Script Date: 03/10/2020 22:23:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transports](
	[TransportId] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Edited] [datetime] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[Cost_in_credits] [nvarchar](max) NULL,
	[Length] [nvarchar](max) NULL,
	[Max_atmosphering_speed] [nvarchar](max) NULL,
	[Crew] [nvarchar](max) NULL,
	[Passengers] [nvarchar](max) NULL,
	[Cargo_capacity] [nvarchar](max) NULL,
	[Consumables] [nvarchar](max) NULL,
	[Pilots_PeopleId] [int] NULL,
 CONSTRAINT [PK_dbo.Transports] PRIMARY KEY CLUSTERED 
(
	[TransportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Transports]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Transports_dbo.People_Pilots_PeopleId] FOREIGN KEY([Pilots_PeopleId])
REFERENCES [dbo].[People] ([PeopleId])
GO

ALTER TABLE [dbo].[Transports] CHECK CONSTRAINT [FK_dbo.Transports_dbo.People_Pilots_PeopleId]
GO


