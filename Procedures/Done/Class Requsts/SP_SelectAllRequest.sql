Create Procedure SP_SelectAllRequest
AS
      Select r.Req_ID 'رقم الفاتورة',r.Req_Date 'تاربخ الفاتورة',s.Su_Name 'أسم المورد', r.Total 'الأجمالى'
	  From TblRequsts r ,TblSupplire s
	  where  r.Su_ID = s.Su_ID
Return 