Create Procedure SP_UpdateActvieMatirel
(
@Am_ID int,
@Am_Name nvarchar(50),
@Am_Desc nvarchar(max)
)

AS
   update TblAcviteMatrile Set  Am_Name= @Am_Name, Am_Description =@Am_Desc Where Am_ID = @Am_ID 
return 