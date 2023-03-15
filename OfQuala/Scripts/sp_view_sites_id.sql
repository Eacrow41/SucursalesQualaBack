USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_view_sites_id]    Script Date: 15/03/2023 6:34:11 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[Sp_view_sites_id]
@codigo int
as
select * from sucursales
where codigo = @codigo
GO


