Create Procedure SP_UpdateProduct
(
@P_ID bigint,
@P_Name nvarchar(50),
@P_Description nvarchar(max),
@P_Image image,
@BuyPrice varchar(50),
@SellPrice varchar(50),
@Cat_ID int,
@Am_ID int,
@Sn_ID int,
@Barcode varchar(50)
)
AS
Update TblProduct Set P_Name=@P_Name,
                      P_Description=@P_Description,
					  P_Image=@P_Image,
					  BuyPrice=@BuyPrice,
					  SellPrice=@SellPrice,
					  Cat_ID=@Cat_ID,
					  Am_ID=@Am_ID,
					  Sn_ID=@Sn_ID,
					  Barcode=@Barcode
Where                 P_ID=@P_ID
Return 

