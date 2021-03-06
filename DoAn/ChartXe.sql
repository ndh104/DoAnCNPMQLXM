USE [QLXEMAY]
GO
/****** Object:  UserDefinedFunction [dbo].[CHARTXE]    Script Date: 11/01/2022 2:33:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER function [dbo].[CHARTXE]()
returns table as return 

SELECT  top 10   sum(a.SOLUONG) as SOLUONG,   c.TENXE
FROM tb_CHITIETHOADON a, tb_CHITIETMAUXE b, tb_XEMAY c 
WHERE a.IDCHITIETXE = b.IDCHITIETXE and b.MAXE = c.MAXE
GROUP by c.TENXE
ORDER by SOLUONG desc