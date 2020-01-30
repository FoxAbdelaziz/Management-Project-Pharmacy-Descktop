Create Procedure SP_SelectActiveMatrile

AS
  select Am_Name 'أسم المادة الفعالة' , Am_Description 'وصف المادة الفعالة' From TblAcviteMatrile
Return