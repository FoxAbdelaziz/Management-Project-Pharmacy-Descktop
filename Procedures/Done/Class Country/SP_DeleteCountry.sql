create procedure SP_DeleteCountry
(
@Country_ID    int
)
As
      Delete from TblCountry  
	  Where   Country_ID = @Country_ID
Return
