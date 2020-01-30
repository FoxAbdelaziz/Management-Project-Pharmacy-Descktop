create procedure SP_CityByCountry
(
@countryID  int 
)
AS
       select City_ID,City_Name from TblCity 
	   where Country_ID= @countryID
Return 