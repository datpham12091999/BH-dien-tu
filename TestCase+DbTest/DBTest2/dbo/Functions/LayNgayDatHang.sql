Create Function [dbo].[LayNgayDatHang] ( @MaDH nvarchar(8))
returns Date
begin
declare @NgayDH date
set @NgayDH = ( select NgayMuaHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @NgayDH
end
