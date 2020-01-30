Create Procedure SP_SelectAllCategory
AS 
Select Cat_ID 'معرف الأصناف' ,Cat_Name 'أسم الصنف' from TblCategories
return 