alter function [dbo].[CHARTXE]()
returns table as return 
SELECT  top 10  dbo.tb_XEMAY.TENXE, sum(dbo.tb_CHITIETHOADON.SOLUONG) as cc
FROM            dbo.tb_CHITIETHOADON INNER JOIN
                         dbo.tb_XEMAY ON dbo.tb_CHITIETHOADON.MAXE = dbo.tb_XEMAY.MAXE
						 group by tb_XEMAY.TENXE
						 order by cc desc
						 



select * from CHARTXE()