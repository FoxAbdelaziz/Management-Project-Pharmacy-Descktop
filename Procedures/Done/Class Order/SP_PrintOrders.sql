Create proc SP_PrintOrders
(
@Order_ID int
)
AS
      select o.Order_ID,o.Order_Date,o.Total,o.Seler_Name,cu.Cu_Name,p.P_Name,od.P_Price,od.Qty 
	  from TblOrders o,TblOrderDetails od,TblCustomers cu,TblProduct p
      where o.Order_ID=od.Order_ID And cu.Cu_ID=o.Cu_ID And p.P_ID = od.P_ID And o.Order_ID =@Order_ID
Return