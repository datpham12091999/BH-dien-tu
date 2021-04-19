create Function [dbo].[TimGiaBan] ( @ma int )
returns int
AS
BEGIN
Declare @GiaSP int;
Set @GiaSP =  ( Select GiaBan
from SanPham
where MaSP = @ma);
Return @GiaSP
END;
