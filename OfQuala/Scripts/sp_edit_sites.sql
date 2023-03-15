USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_edit_sites]    Script Date: 15/03/2023 6:33:24 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Sp_edit_sites]
@codigo int,
@descripcion varchar(250),
@direccion varchar(250),
@identificacion varchar(50),
@fecha_creacion date,
@moneda varchar(50)
as 
update sucursales
 SET 
      descripcion = @descripcion
      ,direccion = @direccion
      ,identificacion = @identificacion
	  ,fecha_creacion = @fecha_creacion
      ,moneda = @moneda	  
 WHERE codigo = @codigo

GO


