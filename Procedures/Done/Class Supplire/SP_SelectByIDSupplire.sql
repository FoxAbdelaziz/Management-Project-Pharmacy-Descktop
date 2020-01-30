Create Procedure SP_SelectByIDSupplire
@Su_ID Int 
AS
    Select Su_Name,Su_Mobile  
	From TblSupplire 
	where Su_ID = @Su_ID 
Return
 