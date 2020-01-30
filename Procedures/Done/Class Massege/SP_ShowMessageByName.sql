Alter Procedure SP_ShowMessageByName
(
@U_Name nvarchar(50)
)
AS
     Select MassegeTitle'عنوان الرسالة',MassegeDetails'تفاصيل الرسالة',MDate'تاريخ أرسال الرسالة',U_Name'أسم المستخدم',ReadOrNoRead 'تم عرض الرسالة' from TblMassege 
	 Where U_Name=@U_Name
Return