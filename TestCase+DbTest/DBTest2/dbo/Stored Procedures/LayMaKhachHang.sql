Create Proc [dbo].[LayMaKhachHang] ( @tenKh nvarchar(50) , @SDT nvarchar(50))
as
declare @MaKH int
begin
set @MaKH = ( select MaKhachHang
			  from KhachHang
			  where HoTen = @tenKh and SDT = @SDT
			  )
return @MaKH
end
