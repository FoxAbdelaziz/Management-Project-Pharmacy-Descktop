Create Procedure SP_SelectAllCountry

AS
      Select  Country_ID 'معرف الدولة', Country_Code 'كود الدولة',Country_Name 'أسم الدولة' from TblCountry
Return