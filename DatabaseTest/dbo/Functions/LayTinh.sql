Create Function [dbo].[LayTinh] ( @MaDH nvarchar(50) )
returns nvarchar(50)
begin
declare @DiaChi nvarchar(50)
set @DiaChi = ( select [Tinh/ThanhPho]
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @Diachi
end
