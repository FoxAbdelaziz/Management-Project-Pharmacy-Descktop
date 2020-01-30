Create Procedure SP_SearchActiveMatrile
@Search nvarchar(50)
AS
  select Am_ID 'معرف المادة' , Am_Name 'أسم المادة الفعالة' , Am_Description 'وصف المادة الفعالة' 
  From TblAcviteMatrile
  where convert (nvarchar,Am_ID)+Am_Name+Am_Description like '%'+@Search+'%'
Return