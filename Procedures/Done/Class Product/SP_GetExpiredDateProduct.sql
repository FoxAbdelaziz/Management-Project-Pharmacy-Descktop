USE [A.Pharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetExpiredDateProduct]    Script Date: 12/18/2017 7:42:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_GetExpiredDateProduct]
(
@ID Bigint
)
AS
   Select EX_Date 'تاريخ الصلاحية',isnull(Qty,0) AS 'الكمية فى المخزن' From TblExpiredDate 
   Where  P_ID=@ID 
Return
