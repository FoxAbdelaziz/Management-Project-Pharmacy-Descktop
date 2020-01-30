USE [A.Pharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllActiveMatrile]    Script Date: 12/17/2017 12:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_SelectAllActiveMatrile]

AS
  select Am_ID 'معرف المادة' , Am_Name 'أسم المادة الفعالة' , Am_Description 'وصف المادة الفعالة' From TblAcviteMatrile
Return