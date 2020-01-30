Create procedure SP_DeleteCity
(
@City_ID int
)
AS 
	  Delete From TblCity
	  where City_ID=@City_ID
Return  