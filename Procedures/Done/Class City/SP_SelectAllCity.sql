Create Procedure SP_SelectAllCity
AS
      Select C.City_ID'معرف المدينة',C.City_Name'أسم المدينة' , co.Country_Name 'أسم الدولة'
	  from TblCity C,TblCountry Co
	  where C.Country_ID=Co.Country_ID
return