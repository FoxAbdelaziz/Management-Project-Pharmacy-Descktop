Create Procedure SP_SelectAllCustomer
AS
      select cu.Cu_ID'رقم العميل',cu.Cu_Name'أسم العميل',cu.Cu_Address'العنوان',cu.Cu_Mobile'رقم المحمول'
	  ,cu.Cu_Image 'الصورة', co.Country_Name 'الدولة',c.City_Name 'المدينة'
	  from TblCustomers cu,TblCity c,TblCountry co
      where cu.City_ID=c.City_ID
	  And c.Country_ID=co.Country_ID
Return