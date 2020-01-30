Create Procedure SP_InsertSupplire
(
@Su_Name nvarchar(50),
@Su_Mobile varchar(15)
)
AS
      Insert Into TblSupplire (Su_Name,Su_Mobile) Values (@Su_Name,@Su_Mobile) 
Return