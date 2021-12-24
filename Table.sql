USE [SimpleCalculator]
GO

/****** Object:  Table [dbo].[Calculator]    Script Date: 24.12.2021 12:17:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Calculator](
	[BerechnungID] [int] IDENTITY(1,1) NOT NULL,
	[Berechnung] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Calculator] PRIMARY KEY CLUSTERED 
(
	[BerechnungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


