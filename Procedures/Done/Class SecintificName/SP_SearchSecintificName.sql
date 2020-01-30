Create  Procedure SP_SearchSecintificName
@Search nvarchar(50)
AS
    Select Sn_ID 'معرف الأسم العلمى', Sn_Name 'الأسم العلمى' From TblSecintificName
 Where convert(nvarchar,Sn_ID)+ Sn_Name Like '%'+@Search+'%'
Return  