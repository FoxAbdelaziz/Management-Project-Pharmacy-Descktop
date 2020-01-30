USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchUser]    Script Date: 2/1/2018 6:47:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[SP_SearchUser]
(
@Serach  nvarchar(50)
)
AS
     Select u.U_ID 'معرف المستخدم',u.U_Name'أسم المستخدم',u.U_Password'كلمة المرور',u.U_FullName'الأسم بالكامل',p.Per_Name'نوع الصلاحية' 
	  from TblUsers u,TblPermissions p
	  where u.Per_ID=p.Per_ID And
	  convert (nvarchar, u.U_ID)+ u.U_Name+ u.U_FullName + p.Per_Name like '%'+@Serach+'%'
	  Return