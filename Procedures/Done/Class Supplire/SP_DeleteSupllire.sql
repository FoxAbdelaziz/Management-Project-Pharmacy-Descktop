Create Procedure SP_DeleteSupllire
@Su_ID int
AS
    delete from  TblSupplire where Su_ID=@Su_ID
Return