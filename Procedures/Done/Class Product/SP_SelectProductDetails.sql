USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectProductDetails]    Script Date: 1/26/2018 9:01:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_SelectProductDetails]
As 
Select P.P_ID 'معرف المنتج', 
       P.P_Name 'أسم المنتج',
	   P.SellPrice 'سعر بيع المنتج',
	   isnull (Sum (Convert(decimal,Ex.Qty)),0) 'الكمية',
	   p.Barcode 'الباركود'
  FROM TblProduct P 
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  Group By P.P_ID,
           P.P_Name,
	       P.SellPrice,
           p.Barcode
return