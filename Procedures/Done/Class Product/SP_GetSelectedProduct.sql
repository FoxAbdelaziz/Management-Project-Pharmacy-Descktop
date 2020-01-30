Create Procedure SP_GetSelectedProduct
@P_ID Int 
AS
Select Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   p.Barcode,
	   P.P_Description,
	   p.P_Image
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
  Where P.P_ID=@P_ID
Return   