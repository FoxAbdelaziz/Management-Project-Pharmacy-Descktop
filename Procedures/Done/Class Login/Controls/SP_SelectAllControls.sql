USE [A.Pharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllControls]    Script Date: 12/18/2017 10:18:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_SelectAllControls]

AS
  Select co.UserName 'أسم المستخدم' , co.UPassword 'كلمة المرور',co.UDateTime 'تاريخ الدخول' ,co.Process 'العملية'
  from TblControls co
  group by UserName,UPassword,UDateTime,Process
  order by UDateTime
Return 