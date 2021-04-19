create  Function  [dbo].[TimSPtrung] (  @tensp nvarchar(50))
returns int
begin
declare @kq int
if  Exists ( select [Số Lượng]
              from DSGH
			  where TenSP = @tensp)
			 set @kq = 1
else
			set @kq = 0
return @kq
end
