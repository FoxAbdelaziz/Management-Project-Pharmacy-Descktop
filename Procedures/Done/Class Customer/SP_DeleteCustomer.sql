Create Procedure SP_DeleteCustomer
(
@Cu_ID         int
)
AS
      delete From TblCustomers 
	  Where Cu_ID   = @Cu_ID
Return