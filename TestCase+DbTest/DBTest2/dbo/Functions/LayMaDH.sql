CREATE Function [dbo].[LayMaDH] ( @MaDH nvarchar(50) )
returns nvarchar(8)
begin
declare @MaDH1 nvarchar(8)
set @MaDH1 = ( select MaDonHang
			  from DonHang
			  where MaDonHang = @MaDH
			  )
return @MaDH1
end
