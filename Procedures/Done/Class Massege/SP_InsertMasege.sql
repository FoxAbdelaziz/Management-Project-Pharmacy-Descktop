Create Procedure SP_InsertMasege
(
@MassegeTitle   nvarchar(50),
@MassegeDetails nvarchar(max),
@MDate           date,
@U_Name          nvarchar(50),
@ReadOrNoRead    nvarchar(50)         
)
As
        insert into TblMassege (MassegeTitle,MassegeDetails,MDate,U_Name,ReadOrNoRead) Values (@MassegeTitle,@MassegeDetails,@MDate,@U_Name,@ReadOrNoRead)
Return 