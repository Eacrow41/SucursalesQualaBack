USE [TestDb]
GO
/****** Object:  StoredProcedure [dbo].[Sp_delete_sites]    Script Date: 15/03/2023 6:41:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[Sp_delete_sites]
@codigo int
as 
delete from sucursales
where codigo = @codigo

