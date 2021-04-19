CREATE Proc [dbo].[TimKiemSanPham] ( @TenSP nvarchar(50))
as
begin
Select TenSP , GiaBan ,MaSP
From  SanPham
where TenSP like '%' +@TenSP+ '%'
end
