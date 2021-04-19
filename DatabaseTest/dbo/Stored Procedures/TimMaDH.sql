Create Proc [dbo].[TimMaDH] ( @MaDH nvarchar(100))
as
declare @kq int
begin
if exists ( select ThanhTienDonHang
            from DonHang
			where MaDonHang = @MaDH
		)
			set @kq = 1;
else
set @kq = 0
return @kq
end
