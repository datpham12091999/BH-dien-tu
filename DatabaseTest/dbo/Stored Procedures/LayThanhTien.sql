Create Proc [dbo].[LayThanhTien] ( @MaDH nvarchar(8))
as
declare @ThanhTien int
begin
set @ThanhTien = ( select ThanhTienDonHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @ThanhTien
end
