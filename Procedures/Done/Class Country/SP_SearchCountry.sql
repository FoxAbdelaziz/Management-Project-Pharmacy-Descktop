Create Procedure SP_SearchCountry
@Search nvarchar(50)
AS
      Select  Country_ID 'معرف الدولة', Country_Code 'كود الدولة',Country_Name 'أسم الدولة' from TblCountry
      where   convert (nvarchar, Country_ID) + Country_Code + Country_Name 
	  like '%'+ @Search+'%'
Return