create Procedure SP_SearchCategory
(
@Search Nvarchar(50)
)
AS 
Select Cat_ID 'معرف الأصناف' ,Cat_Name 'أسم الصنف' 
from TblCategory
where convert(nvarchar,Cat_ID) + Cat_Name Like '%' +@Search+'%' 
return 