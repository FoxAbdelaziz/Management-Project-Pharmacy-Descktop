Create Procedure SP_DeleteActiveMatrile
@Am_ID int

AS
Delete From TblAcviteMatrile Where Am_ID=@Am_ID
return 