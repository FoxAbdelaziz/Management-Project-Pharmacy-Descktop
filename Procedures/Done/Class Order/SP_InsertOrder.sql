Create procedure SP_InsertOrder
(
@OrderDate        date,
@Total            varchar(30),
@Cu_ID            int,
@Seler_Name       nvarchar(50),
@TypeOrderDetails TypeOrderDetails Readonly 
)
AS
      insert into TblOrders (Order_Date,Total,Cu_ID,Seler_Name) values (@OrderDate,@Total,@Cu_ID,@Seler_Name)
	  
	  insert into TblOrderDetails (Order_ID,P_ID,P_Price,Qty) 
	  Select max(o.Order_ID),od.P_ID,od.P_Price,od.Qty from TblOrders o,@TypeOrderDetails od
      group by od.P_ID,od.P_Price,od.Qty

	  Declare @Products   cursor
	  set     @products = cursor for(select P_ID,Qty from @TypeOrderDetails)
	  open    @products

	  Declare @P_ID        int,
	          @Qty         nvarchar(50)
      Fetch   @products    into 
	          @P_ID, 
			  @Qty

       while @@FETCH_STATUS = 0 

	   begin
	   Declare @ExpiredDate   cursor
	   set     @ExpiredDate = cursor For (Select Ex_Date, Qty From TblExpiredDate Where P_ID =@P_ID And convert(float,Qty)>0) order by EX_Date
	   open    @ExpiredDate

	   Declare @Ex_Date   date,
	           @Ex_Qty    nvarchar(50)
			   
	   Fetch @ExpiredDate into @Ex_Date,@Ex_Qty
	    
	   while @@FETCH_STATUS = 0 
	   Begin 

	   if(convert(float,@qty)<=convert(float,@Ex_Qty))
	   begin

	   update TblExpiredDate set Qty = convert(float,Qty) - convert(float,@Qty)
	   Where P_ID=@P_ID And Ex_Date=@Ex_Date 
	   break 

	   End

	   Else 
	   begin 
	   update TblExpiredDate set Qty = '0'
	   Where P_ID=@P_ID And Ex_Date=@Ex_Date 
	   
	   set @Qty =Convert(float,@Qty) - Convert(float,@Ex_Qty)
	   End
	   Fetch @ExpiredDate into @Ex_Date,@Ex_Qty

	   End
	   Fetch @products into @P_ID, @Qty

	   End
Return