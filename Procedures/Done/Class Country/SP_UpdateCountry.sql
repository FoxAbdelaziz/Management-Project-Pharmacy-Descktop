create procedure SP_UpdateCountry
(
@Country_ID    int,
@Country_Code  nvarchar(4),
@Country_Name  nvarchar(50)
)
As
      update  TblCountry Set Country_Code= @Country_Code,Country_Name =@Country_Name 
	  Where   Country_ID = @Country_ID
Return
