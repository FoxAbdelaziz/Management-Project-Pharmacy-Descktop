USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectCountMsg]    Script Date: 1/24/2018 5:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_SelectCountMsg]
(@UName nvarchar(50),
@ReadOrNoRead nvarchar(50))
AS
    select count(ID) from TblMassege 
	Where U_Name =@UName
	And ReadOrNoRead = @ReadOrNoRead
Return 