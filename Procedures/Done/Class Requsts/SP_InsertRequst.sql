USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRequst]    Script Date: 1/15/2018 6:33:10 PM ******/
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

   Declare @ExpiredDate Cursor 
   Set     @ExpiredDate=Cursor for(select Ex_Date,P_ID,Qty from @TypeExpiredDate)
   Open    @ExpiredDate
   Declare @EX_Date Date,
           @P_ID    int,
		   @Qty     varchar(50)
   Fetch   @ExpiredDate into 	@EX_Date, @P_ID ,@Qty
   While   @@FETCH_STATUS =0
   Begin
   if exists (select Ex_ID From TblExpiredDate where EX_Date = @EX_Date And P_ID = @P_ID)
   update TblExpiredDate Set Qty = Convert (float,Qty)+Convert (float,@Qty)
   Where Ex_ID = (select Ex_ID From TblExpiredDate where EX_Date = @EX_Date And P_ID = @P_ID)
   Else 
   insert into TblExpiredDate (EX_Date,P_ID,Qty) 
   Values (@EX_Date,@P_ID,@Qty)
    Fetch   @ExpiredDate into 	@EX_Date, @P_ID ,@Qty
   End   
Return 