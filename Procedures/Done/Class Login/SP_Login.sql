Create Procedure SP_Login
@UserName nvarchar(50),
@PassWord nvarchar(50)
as 
Select * From TblUsers Where U_Name=@UserName And U_Password=@PassWord
return