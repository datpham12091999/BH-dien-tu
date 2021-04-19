
create Function [dbo].[TimTenSP] ( @ma int )
returns VarChar(50)
AS
BEGIN
Declare @TenSP VarChar (50);
Set @TenSP =  ( Select TenSP
from SanPham
where MaSP = @ma);
Return @TenSP
END;
