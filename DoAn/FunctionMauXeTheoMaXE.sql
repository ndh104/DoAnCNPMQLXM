USE [QLXEMAY]
GO
/****** Object:  UserDefinedFunction [dbo].[MAUXETHEOMAXE]    Script Date: 11/01/2022 2:33:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER function [dbo].[MAUXETHEOMAXE](@maxe Nvarchar (5))
returns table as return 
select a.IDMAU, b.TENMAU
from tb_CHITIETMAUXE a, tb_MAUSAC b, tb_XEMAY c
where a.MAXE = c.MAXE and a.IDMAU=b.IDMAU and a.MAXE = @maxe