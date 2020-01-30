Create Procedure SP_InsertProduct
(
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
Insert into TblProduct (P_Name,P_Description,P_Image,BuyPrice,SellPrice,Cat_ID,Am_ID,Sn_ID,Barcode)
       Values (@P_Name,@P_Description,@P_Image,@BuyPrice,@SellPrice,@Cat_ID,@Am_ID,@Sn_ID,@Barcode)
Return 

