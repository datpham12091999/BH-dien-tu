Create Proc [dbo].[LaySoLuongSP] ( @masp int )
as
declare @SL int
begin
set @SL = ( select SoLuong
            from SanPham
			where MaSP = @masp
			)
return @SL
end
