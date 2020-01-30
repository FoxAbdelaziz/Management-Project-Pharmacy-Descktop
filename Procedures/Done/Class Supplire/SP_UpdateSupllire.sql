Create Procedure SP_UpdateSupllire
@Su_ID int,
@Su_Name nvarchar(50),
@Su_Mobile varchar(15)
AS
    update TblSupplire set Su_Name=@Su_Name,Su_Mobile= Su_Mobile
	where Su_ID=@Su_ID
Return