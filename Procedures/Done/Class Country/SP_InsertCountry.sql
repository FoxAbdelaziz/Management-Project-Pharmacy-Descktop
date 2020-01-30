Create Procedure SP_InsertCountry
(
@CountryCode Nvarchar(4),
@CountryName Nvarchar(50)
)
AS
      Insert into TblCountry (Country_Code,Country_Name) Values (@CountryCode,@CountryName) 
Return