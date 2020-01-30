Create Procedure SP_SearchSupplier
@Search nvarchar(50)
AS
   Select Su_ID 'معرف الموردين' ,Su_Name 'أسم المورد',Su_Mobile 'رقم التليفون' From TblSupplire
where Convert(nvarchar,Su_ID) + Su_Name +Su_Mobile Like '%' +@Search+ '%'
Return
