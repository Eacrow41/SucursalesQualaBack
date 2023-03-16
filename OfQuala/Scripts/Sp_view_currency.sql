USE [TestDb]
GO

/****** Object:  StoredProcedure [dbo].[Sp_view_currency]    Script Date: 15/03/2023 10:53:26 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[Sp_view_currency]
as
select * from moneda

GO


