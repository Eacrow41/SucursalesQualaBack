USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_view_sites]    Script Date: 15/03/2023 6:33:55 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[Sp_view_sites]
as
select * from sucursales

GO


