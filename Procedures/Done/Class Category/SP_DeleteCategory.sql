Create Procedure SP_DeleteCategory
(
@CatID int 
)
AS
delete from TblCategory where Cat_ID=@CatID
return 

