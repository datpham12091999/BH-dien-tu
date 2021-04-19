Create Procedure [dbo].[KTDangNhap] (@tendangnhap varchar(50) , @matkhau varchar(50))
as
declare @kq int
begin
if Exists ( select * from DangNhap 
where DangNhap  = @tendangnhap and MatKhau = @matkhau)
   set @kq =1 
   else if not exists ( select * from DangNhap
where DangNhap= @tendangnhap )
   set @kq =2
   else if not exists (select * from DangNhap
   where MatKhau = @matkhau)
   set @kq =3
   else
   set @kq = -1
end
return @kq
