
Create Proc [dbo].[TimTaiKhoan] (  @tentk nvarchar(50))
as
declare @kq int
begin
if exists ( select DangNhap
            from DangNhap
			where DangNhap = @tentk
			)
			set @kq =1;
else 
set @kq = 0;
return @kq;
end
