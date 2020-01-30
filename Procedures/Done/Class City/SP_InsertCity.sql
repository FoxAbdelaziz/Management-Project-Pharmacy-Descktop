Create Procedure SP_InsertCity
(
@City_Name nvarchar(50),
@Country_ID  int
)
AS
      Insert  into TblCity   
	  (City_Name,Country_ID)
	  Values 
	  (@City_Name,@Country_ID)
Return