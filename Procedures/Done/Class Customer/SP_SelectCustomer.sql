CREATE PROCEDURE SP_SelectCustomer
AS
	SELECT Cu_ID 'كود العميل', Cu_Name 'أسم العميل',Cu_Mobile 'رقم التليفون' from TblCustomers 
RETURN 
