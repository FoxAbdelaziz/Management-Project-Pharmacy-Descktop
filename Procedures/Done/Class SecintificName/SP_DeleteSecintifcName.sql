Create Procedure SP_DeleteSecintifcName
(
@Sn_ID int
)
AS
Delete From TblSecintificName Where Sn_ID=@Sn_ID
Return