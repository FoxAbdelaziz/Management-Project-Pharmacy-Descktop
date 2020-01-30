USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUsers]    Script Date: 2/1/2018 6:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_SelectAllUsers]
AS
     Select u.U_ID 'معرف المستخدم',u.U_Name'أسم المستخدم',u.U_Password'كلمة المرور',u.U_FullName'الأسم بالكامل',p.Per_Name'نوع الصلاحية' 
	  from TblUsers u,TblPermissions p
	  where u.Per_ID=p.Per_ID
Return
