Create Procedure SP_InsertCustomer
(
@Cu_Name nvarchar(50),
@Cu_Address nvarchar(max),
@Cu_Mobile varchar(15),
@Cu_Image image,
@City_ID int
)
AS
      insert into TblCustomers 
	  (Cu_Name,Cu_Address,Cu_Mobile,Cu_Image,City_ID)
	  Values
	  (@Cu_Name,@Cu_Address,@Cu_Mobile,@Cu_Image,@City_ID)
Return