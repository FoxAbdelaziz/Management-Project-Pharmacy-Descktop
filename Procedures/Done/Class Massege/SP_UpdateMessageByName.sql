Create Proc SP_UpdateMessageByName
(
@ReadOrNoRead nvarchar(50),
@U_Name nvarchar(50)
)
AS
       Update TblMassege set ReadOrNoRead = @ReadOrNoRead
	   Where U_Name =@U_Name
Return