Create Procedure SP_UpdateCustomer
(
@Cu_ID         int,
@Cu_Name       nvarchar(50),
@Cu_Address    nvarchar(max),
@Cu_Mobile     varchar(15),
@Cu_Image      image,
@City_ID       int
)
AS
      update TblCustomers 
	  set Cu_Name   = @Cu_Name,
	  Cu_Address    = @Cu_Address,
	  Cu_Mobile     = @Cu_Mobile,
	  Cu_Image      = @Cu_Image,
	  City_ID       = @City_ID
	  Where Cu_ID   = @Cu_ID
Return