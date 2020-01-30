USE [APharmacy_DB]
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllOrders]    Script Date: 2/1/2018 4:03:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[SP_SelectAllOrders]
AS
select o.Order_ID'معرف الفاتورة',o.Order_Date'تاريخ الفاتورة',o.Total'الأجمالي', c.Cu_Name 'أسم العميل',o.Seler_Name'أسم البائع' from TblOrders o,TblCustomers c
where c.Cu_ID=o.Cu_ID      
Return