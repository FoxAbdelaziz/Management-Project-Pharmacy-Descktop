Create Procedure SP_SearchCity
@Search nvarchar(50)
AS
      Select C.City_ID'معرف المدينة',C.City_Name'أسم المدينة' , co.Country_Name 'أسم الدولة'
	  from TblCity C,TblCountry Co
	  where C.Country_ID=Co.Country_ID
	  and convert(nvarchar,City_ID)+City_Name+Country_Name
	  like '%' +@Search+ '%'
return