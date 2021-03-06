USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRequst]    Script Date: 1/13/2018 6:50:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_InsertRequst]
(
@Req_Date          Date,
@Total             Varchar(50),
@Su_ID             int,
@Buyer_Name        nvarchar(50),
@TypeRequstDetails TypeRequstDetails readonly,
@TypeExpiredDate   TypeExpiredDate   readonly
)
AS 
   insert into TblRequsts (Req_Date,Total,Su_ID,Buyer_Name) values (@Req_Date,@Total,@Su_ID,@Buyer_Name)

   insert into TblRequstDetails (Req_ID , P_ID, Qty,P_Price) Select max(R.Req_ID),RD.P_ID,Rd.Qty ,RD.P_Price From  TblRequsts R , @TypeRequstDetails RD
   Group By Rd.P_ID,Rd.Qty,Rd.P_Price

   insert into TblExpiredDate (EX_Date,P_ID,Qty) Select Ex_Date,P_ID,Qty From @TypeExpiredDate 
Return 