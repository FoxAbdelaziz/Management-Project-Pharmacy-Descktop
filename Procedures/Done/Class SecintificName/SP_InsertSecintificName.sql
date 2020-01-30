Create Procedure SP_InsertSecintificName
@Sn_Name nvarchar(50)
AS
 insert into TblSecintificName (Sn_Name) Values (@Sn_Name)
Return 