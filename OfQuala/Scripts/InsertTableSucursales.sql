USE [TestDb]
GO

INSERT INTO [dbo].[sucursales]
           ([codigo]
           ,[descripcion]
           ,[direccion]
           ,[identificacion]
           ,[fecha_creacion]
           ,[moneda])
     VALUES
           ('1'
           ,'Bogota'
           ,'Calle 12 # 98 - 23'
           ,'BGT'
           ,GETDATE()
           ,'COP')
GO


