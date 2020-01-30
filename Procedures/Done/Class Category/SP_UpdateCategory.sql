Create Procedure SP_UpdateCategory
(
@CatID int,
@CatName nvarchar(50)
)
AS
    update TblCategory Set Cat_Name=@CatName Where Cat_ID=@CatID
return
	    