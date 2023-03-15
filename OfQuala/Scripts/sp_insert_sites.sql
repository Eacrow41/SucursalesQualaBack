USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_insert_sites]    Script Date: 15/03/2023 6:33:39 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[Sp_insert_sites]
@codigo int,
@descripcion varchar(250),
@direccion varchar(250),
@identificacion varchar(50),
@fecha_creacion date,
@moneda varchar(50)
as
INSERT INTO sucursales
           (codigo
           ,descripcion
           ,direccion
           ,identificacion
		   ,fecha_creacion
           ,moneda)
     VALUES
			(@codigo,
			 @descripcion,
			 @direccion,
			 @identificacion,
			 @fecha_creacion,
			 @moneda)

GO


