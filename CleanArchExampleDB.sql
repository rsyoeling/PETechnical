USE [CleanArchExampleDB]
GO
/****** Object:  Table [dbo].[Promocion]    Script Date: 30/10/2021 14:24:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promocion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](300) NULL,
	[Email] [varchar](100) NULL,
	[Estado] [varchar](20) NULL,
	[Codigo] [varchar](12) NULL,
	[FechaCreacion] [datetime] NULL,
	[FechaCanje] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Promocion] ON 

INSERT [dbo].[Promocion] ([Id], [Nombre], [Email], [Estado], [Codigo], [FechaCreacion], [FechaCanje]) VALUES (3, N'yoel', N'rsyoeling@gmail.com', N'canjeado', N'CODPRO023723', CAST(N'2021-10-29T02:37:23.667' AS DateTime), CAST(N'2021-10-29T06:24:59.310' AS DateTime))
INSERT [dbo].[Promocion] ([Id], [Nombre], [Email], [Estado], [Codigo], [FechaCreacion], [FechaCanje]) VALUES (6, N'leoncio', N'rodriguezsyoell@gmail.com', N'generado', N'CODPRO062354', CAST(N'2021-10-29T06:23:54.870' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Promocion] OFF
GO
