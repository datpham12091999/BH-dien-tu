CREATE Proc [dbo].[DemSoSP] 
as
declare  @kq int 
Set @kq = (Select COUNT(MaSP) 
FROM SanPham)
Return @kq
