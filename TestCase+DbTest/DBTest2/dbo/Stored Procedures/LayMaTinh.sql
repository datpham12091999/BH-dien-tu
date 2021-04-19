
CREATE Proc [dbo].[LayMaTinh] (@tinh nvarchar(50))
as
declare @Matinh int
begin
set @Matinh =
(select MaTinh from Tinh
Where TenTinh = @tinh)
return @Matinh
end
