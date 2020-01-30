Create Procedure SP_DeleteProduct
@P_ID Bigint

AS
   Delete From TblProduct 
   Where P_ID=@P_ID
Return