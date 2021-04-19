Create Proc [dbo].[TimMaDHTrung] ( @MaDonHang nvarchar(8))
as
declare @kq int
begin 
if exists ( select MaDonHang
            from DonHang
			where MaDonHang = @MaDonHang)
			set @kq = 1
else
set @kq = 0
return @kq;
end
