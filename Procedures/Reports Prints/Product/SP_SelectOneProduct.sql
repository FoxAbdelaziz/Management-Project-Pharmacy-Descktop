Create Procedure SP_SelectOneProduct
@P_ID int
As 
Select P.P_ID, 
	   Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   isnull (Sum (Convert(decimal,Ex.Qty)),0),
	   p.Barcode,
	   P.P_Description
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  where P.P_ID = @P_ID
  Group By P.P_ID,
           Ca.Cat_Name,
           P.P_Name,
	       Am.Am_Name,
	       Sn.Sn_Name,
	       p.SellPrice,
	       P.BuyPrice,
           p.Barcode,
	       P.P_Description
  Return

