Create Proc [dbo].[LayMaSanPham] ( @tensp nvarchar(50))
as
declare @MaSP int
begin
set @MaSP = ( select MaSP
			  from SanPham
			  where TenSP = @tensp
			  )
return @MaSP
end
