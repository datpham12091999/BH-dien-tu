CREATE Proc [dbo].[TimLinhKien] (@name nvarchar(50))
as
declare @soluong int
begin
set @soluong =( select COUNT(MaSP)
              from SanPham
              Where TenSP like '%' +@name+ '%')
return @soluong
end
