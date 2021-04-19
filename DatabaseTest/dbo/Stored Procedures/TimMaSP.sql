Create Proc [dbo].[TimMaSP] ( @tenSP nvarchar(50))
as
declare @ma int
begin
set @ma = ( Select MaSP
        from SanPham
		where TenSP = @tenSP)
return @ma

end
