Create procedure SP_UpdateCity
(
@City_ID int ,
@City_Name nvarchar(50),
@Country_ID  int
)
AS
      update TblCity Set City_Name=@City_Name,
	  Country_ID = @Country_ID
	  where City_ID=@City_ID
Return  