Create Proc [dbo].[TimKH] ( @TenKH nvarchar(50) , @SDT nvarchar(50))
as
declare @kq int
begin
if Exists ( select HoTen
            from KhachHang
			where HoTen = @TenKH and SDT = @SDT)
			set @kq = 1
else
	       set @kq = 0
return @kq;
end
