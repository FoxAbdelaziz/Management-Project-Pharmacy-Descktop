Create Procedure SP_PirntRequest
@Req_ID int
AS
      Select R.Req_ID,R.Req_Date,R.Total,R.Buyer_Name,S.Su_Name, 
	  P.P_Name , RD.P_Price,Rd.Qty
	  From TblRequsts R , TblSupplire S,TblRequstDetails RD , TblProduct P
	  Where  R.Req_ID=RD.Req_ID And R.Su_ID=S.Su_ID And Rd.P_ID =P.P_ID And R.Req_ID= @Req_ID
Return