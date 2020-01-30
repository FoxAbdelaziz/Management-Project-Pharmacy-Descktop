Create Procedure SP_DeleteUser
(
@U_ID   int
)
AS
      Delete From TblUsers
	  Where U_ID = @U_ID 
Return
