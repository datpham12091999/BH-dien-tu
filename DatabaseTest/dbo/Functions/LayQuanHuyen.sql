Create Function [dbo].[LayQuanHuyen] ( @MaDH nvarchar(50) )
returns nvarchar(50)
begin
declare @DiaChi nvarchar(50)
set @DiaChi = ( select [Quan/Huyen]
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @Diachi
end
