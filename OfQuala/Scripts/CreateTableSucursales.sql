USE [TestDb]
GO

/****** Object:  Table [dbo].[sucursales]    Script Date: 15/03/2023 6:31:58 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sucursales](
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[direccion] [varchar](250) NOT NULL,
	[identificacion] [varchar](50) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[moneda] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sucursales]  WITH CHECK ADD FOREIGN KEY([moneda])
REFERENCES [dbo].[moneda] ([nombre])
GO


