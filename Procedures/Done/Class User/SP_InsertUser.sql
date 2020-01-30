Create Procedure SP_InsertUser
(
@U_Name       nvarchar(50),
@U_Password   nvarchar(50),
@U_FullName   nvarchar(50),
@Per_ID       int
)
AS
      insert into TblUsers
	  (U_Name,U_Password,U_FullName,Per_ID) 
	  values 
	  (@U_Name,@U_Password,@U_FullName,@Per_ID) 
Return 