Create Procedure SP_SelcetAllSupplier
AS
   Select Su_ID 'معرف الموردين' ,Su_Name 'أسم المورد',Su_Mobile 'رقم التليفون' From TblSupplire
Return

