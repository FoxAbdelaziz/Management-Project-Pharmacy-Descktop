Create Procedure SP_UpdateSecintifcName
(
@Sn_ID int,
@Sn_Name nvarchar(50)
)
AS
 Update TblSecintificName Set Sn_Name =@Sn_Name Where Sn_ID=@Sn_ID
Return