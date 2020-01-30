Create Procedure SP_ControlInsert
@username nvarchar(50),
@password nvarchar(50),
@DateTime datetime ,
@Process nvarchar(max)

AS
  insert into TblControls (UserName,UPassword,UDateTime,Process) values (@username,@password,@DateTime,@Process)
Return 
