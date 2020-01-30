Create Procedure SP_UpdateUser
(
@U_ID   int,
@U_Name nvarchar(50),
@U_Password nvarchar(50),
@U_FullName nvarchar(50),
@Per_ID int

)
AS
      Update TblUsers set U_Name = @U_Name, U_Password = @U_Password ,U_FullName= @U_FullName ,Per_ID = @Per_ID
	  Where U_ID = @U_ID 
Return
