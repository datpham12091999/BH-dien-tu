CREATE Procedure [dbo].[KTDangNhapNV] (@tendangnhap varchar(50) , @matkhau varchar(50))
as
declare @kq int
begin
if Exists ( select * from TKNhanVien
where TenTK  = @tendangnhap and MatKhau = @matkhau)
   set @kq =1 
   else if not exists ( select * from TKNhanVien
where TenTK= @tendangnhap )
   set @kq =2
   else if not exists (select * from TKNhanVien
   where MatKhau = @matkhau)
   set @kq =3
   else
   set @kq = -1
end
return @kq
