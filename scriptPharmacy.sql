USE [APharmacy_DB]
GO
/****** Object:  User [Admin]    Script Date: 3/22/2018 12:58:31 AM ******/
CREATE USER [Admin] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[sys]
GO
/****** Object:  UserDefinedTableType [dbo].[TypeExpiredDate]    Script Date: 3/22/2018 12:58:32 AM ******/
CREATE TYPE [dbo].[TypeExpiredDate] AS TABLE(
	[Ex_Date] [date] NULL,
	[P_ID] [int] NULL,
	[Qty] [varchar](50) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TypeOrderDetails]    Script Date: 3/22/2018 12:58:32 AM ******/
CREATE TYPE [dbo].[TypeOrderDetails] AS TABLE(
	[P_ID] [bigint] NULL,
	[Qty] [nvarchar](50) NULL,
	[P_Price] [float] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TypeRequstDetails]    Script Date: 3/22/2018 12:58:32 AM ******/
CREATE TYPE [dbo].[TypeRequstDetails] AS TABLE(
	[P_ID] [bigint] NULL,
	[Qty] [varchar](50) NULL,
	[P_Price] [float] NULL
)
GO
/****** Object:  Table [dbo].[TblAcviteMatrile]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAcviteMatrile](
	[Am_ID] [int] IDENTITY(1,1) NOT NULL,
	[Am_Name] [nvarchar](50) NOT NULL,
	[Am_Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_TblAcviteMatrile] PRIMARY KEY CLUSTERED 
(
	[Am_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblArchiveRequst]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblArchiveRequst](
	[Req_ID] [bigint] NOT NULL,
	[Req_Date] [date] NULL,
	[Su_ID] [int] NULL,
	[Buyer_Name] [nvarchar](50) NULL,
	[Total] [nvarchar](50) NULL,
	[P_ID] [bigint] NULL,
	[Qty] [nvarchar](50) NULL,
	[P_Price] [float] NULL,
	[Username] [nvarchar](50) NULL,
	[ProssecDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategory](
	[Cat_ID] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblCategory] PRIMARY KEY CLUSTERED 
(
	[Cat_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCity](
	[City_ID] [int] IDENTITY(1,1) NOT NULL,
	[City_Name] [nvarchar](50) NOT NULL,
	[Country_ID] [int] NULL,
 CONSTRAINT [PK_TblCity] PRIMARY KEY CLUSTERED 
(
	[City_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblControls]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblControls](
	[UserName] [nvarchar](50) NULL,
	[UPassword] [nvarchar](50) NULL,
	[UDateTime] [datetime] NULL,
	[Process] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCountry](
	[Country_ID] [int] IDENTITY(1,1) NOT NULL,
	[Country_Code] [nvarchar](4) NOT NULL,
	[Country_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblCountry] PRIMARY KEY CLUSTERED 
(
	[Country_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCustomers]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCustomers](
	[Cu_ID] [int] IDENTITY(1,1) NOT NULL,
	[Cu_Name] [nvarchar](50) NOT NULL,
	[Cu_Address] [nvarchar](max) NULL,
	[Cu_Mobile] [varchar](50) NOT NULL,
	[Cu_Image] [image] NULL,
	[City_ID] [int] NULL,
 CONSTRAINT [PK_TblCustomers] PRIMARY KEY CLUSTERED 
(
	[Cu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblExpiredDate]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblExpiredDate](
	[Ex_ID] [int] IDENTITY(1,1) NOT NULL,
	[EX_Date] [date] NULL,
	[P_ID] [bigint] NULL,
	[Qty] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TblExpiredDate] PRIMARY KEY CLUSTERED 
(
	[Ex_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblMassege]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblMassege](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MassegeTitle] [nvarchar](50) NULL,
	[MassegeDetails] [nvarchar](max) NULL,
	[MDate] [datetime] NULL,
	[U_Name] [nvarchar](50) NULL,
	[ReadOrNoRead] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblMassege] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOrderDetails]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderDetails](
	[Order_ID] [bigint] NULL,
	[P_ID] [bigint] NULL,
	[Qty] [nvarchar](50) NULL,
	[P_Price] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOrders]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblOrders](
	[Order_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Order_Date] [date] NOT NULL,
	[Total] [varchar](30) NOT NULL,
	[Cu_ID] [int] NULL,
	[Seler_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Orders] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblPermissions]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPermissions](
	[Per_ID] [int] IDENTITY(1,1) NOT NULL,
	[Per_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblPermissions] PRIMARY KEY CLUSTERED 
(
	[Per_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblProduct](
	[P_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[P_Name] [nvarchar](50) NULL,
	[P_Description] [nvarchar](max) NULL,
	[P_Image] [image] NULL,
	[BuyPrice] [varchar](50) NULL,
	[SellPrice] [varchar](50) NULL,
	[Cat_ID] [int] NULL,
	[Am_ID] [int] NULL,
	[Sn_ID] [int] NULL,
	[Barcode] [varchar](50) NULL,
 CONSTRAINT [PK_TblProduct] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblRequstDetails]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblRequstDetails](
	[Req_ID] [bigint] NULL,
	[P_ID] [bigint] NULL,
	[Qty] [nvarchar](50) NULL,
	[P_Price] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblRequsts]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblRequsts](
	[Req_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Req_Date] [date] NOT NULL,
	[Su_ID] [int] NOT NULL,
	[Buyer_Name] [nvarchar](50) NOT NULL,
	[Total] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblRequsts] PRIMARY KEY CLUSTERED 
(
	[Req_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblSecintificName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSecintificName](
	[Sn_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sn_Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblSecintificName] PRIMARY KEY CLUSTERED 
(
	[Sn_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblSupplire]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblSupplire](
	[Su_ID] [int] IDENTITY(1,1) NOT NULL,
	[Su_Name] [nvarchar](50) NOT NULL,
	[Su_Mobile] [varchar](15) NOT NULL,
 CONSTRAINT [TblUspplire_Su_ID_PK] PRIMARY KEY CLUSTERED 
(
	[Su_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblUsers]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUsers](
	[U_ID] [int] IDENTITY(1,1) NOT NULL,
	[U_Name] [nvarchar](50) NOT NULL,
	[U_Password] [nvarchar](50) NOT NULL,
	[U_FullName] [nvarchar](50) NULL,
	[Per_ID] [int] NULL,
 CONSTRAINT [PK_TblUsers] PRIMARY KEY CLUSTERED 
(
	[U_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VManagerControl]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[VManagerControl]
As
select * from TblControls where UserName = 'admin' 
and UDateTime between '2018-12-12 10:30 PM' and '2018-12-12 10:10 PM'
GO
ALTER TABLE [dbo].[TblCity]  WITH CHECK ADD  CONSTRAINT [FK_TblCity_TblCountry] FOREIGN KEY([Country_ID])
REFERENCES [dbo].[TblCountry] ([Country_ID])
GO
ALTER TABLE [dbo].[TblCity] CHECK CONSTRAINT [FK_TblCity_TblCountry]
GO
ALTER TABLE [dbo].[TblCustomers]  WITH CHECK ADD  CONSTRAINT [FK_TblCustomers_TblCity] FOREIGN KEY([City_ID])
REFERENCES [dbo].[TblCity] ([City_ID])
GO
ALTER TABLE [dbo].[TblCustomers] CHECK CONSTRAINT [FK_TblCustomers_TblCity]
GO
ALTER TABLE [dbo].[TblExpiredDate]  WITH CHECK ADD  CONSTRAINT [FK_TblExpiredDate_TblProduct] FOREIGN KEY([P_ID])
REFERENCES [dbo].[TblProduct] ([P_ID])
GO
ALTER TABLE [dbo].[TblExpiredDate] CHECK CONSTRAINT [FK_TblExpiredDate_TblProduct]
GO
ALTER TABLE [dbo].[TblOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderDetails_TblOrders] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[TblOrders] ([Order_ID])
GO
ALTER TABLE [dbo].[TblOrderDetails] CHECK CONSTRAINT [FK_TblOrderDetails_TblOrders]
GO
ALTER TABLE [dbo].[TblOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderDetails_TblProduct] FOREIGN KEY([P_ID])
REFERENCES [dbo].[TblProduct] ([P_ID])
GO
ALTER TABLE [dbo].[TblOrderDetails] CHECK CONSTRAINT [FK_TblOrderDetails_TblProduct]
GO
ALTER TABLE [dbo].[TblOrders]  WITH CHECK ADD  CONSTRAINT [FK_TblOrders_TblCustomers] FOREIGN KEY([Cu_ID])
REFERENCES [dbo].[TblCustomers] ([Cu_ID])
GO
ALTER TABLE [dbo].[TblOrders] CHECK CONSTRAINT [FK_TblOrders_TblCustomers]
GO
ALTER TABLE [dbo].[TblProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblProduct_TblAcviteMatrile] FOREIGN KEY([Am_ID])
REFERENCES [dbo].[TblAcviteMatrile] ([Am_ID])
GO
ALTER TABLE [dbo].[TblProduct] CHECK CONSTRAINT [FK_TblProduct_TblAcviteMatrile]
GO
ALTER TABLE [dbo].[TblProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblProduct_TblCategory] FOREIGN KEY([Cat_ID])
REFERENCES [dbo].[TblCategory] ([Cat_ID])
GO
ALTER TABLE [dbo].[TblProduct] CHECK CONSTRAINT [FK_TblProduct_TblCategory]
GO
ALTER TABLE [dbo].[TblProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblProduct_TblSecintificName] FOREIGN KEY([Sn_ID])
REFERENCES [dbo].[TblSecintificName] ([Sn_ID])
GO
ALTER TABLE [dbo].[TblProduct] CHECK CONSTRAINT [FK_TblProduct_TblSecintificName]
GO
ALTER TABLE [dbo].[TblRequstDetails]  WITH CHECK ADD  CONSTRAINT [FK_TblRequstDetails_TblProduct] FOREIGN KEY([P_ID])
REFERENCES [dbo].[TblProduct] ([P_ID])
GO
ALTER TABLE [dbo].[TblRequstDetails] CHECK CONSTRAINT [FK_TblRequstDetails_TblProduct]
GO
ALTER TABLE [dbo].[TblRequstDetails]  WITH CHECK ADD  CONSTRAINT [FK_TblRequstDetails_TblRequsts] FOREIGN KEY([Req_ID])
REFERENCES [dbo].[TblRequsts] ([Req_ID])
GO
ALTER TABLE [dbo].[TblRequstDetails] CHECK CONSTRAINT [FK_TblRequstDetails_TblRequsts]
GO
ALTER TABLE [dbo].[TblRequsts]  WITH CHECK ADD  CONSTRAINT [FK_TblRequsts_TblSupplire] FOREIGN KEY([Su_ID])
REFERENCES [dbo].[TblSupplire] ([Su_ID])
GO
ALTER TABLE [dbo].[TblRequsts] CHECK CONSTRAINT [FK_TblRequsts_TblSupplire]
GO
ALTER TABLE [dbo].[TblUsers]  WITH CHECK ADD  CONSTRAINT [FK_TblUsers_TblPermissions] FOREIGN KEY([Per_ID])
REFERENCES [dbo].[TblPermissions] ([Per_ID])
GO
ALTER TABLE [dbo].[TblUsers] CHECK CONSTRAINT [FK_TblUsers_TblPermissions]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteActiveMatrile]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteActiveMatrile]
@Am_ID int

AS
Delete From TblAcviteMatrile Where Am_ID=@Am_ID
return 
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteCategory]
(
@CatID int 
)
AS
delete from TblCategory where Cat_ID=@CatID
return 


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_DeleteCity]
(
@City_ID int
)
AS 
	  Delete From TblCity
	  where City_ID=@City_ID
Return  
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteControls]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteControls]
AS
 Delete From TblControls
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DeleteCountry]
(
@Country_ID    int
)
As
      Delete from TblCountry  
	  Where   Country_ID = @Country_ID
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteCustomer]
(
@Cu_ID         int
)
AS
      delete From TblCustomers 
	  Where Cu_ID   = @Cu_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteProduct]
@P_ID Bigint

AS
   Delete From TblProduct 
   Where P_ID=@P_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSecintifcName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_DeleteSecintifcName]
(
@Sn_ID int
)
AS
Delete From TblSecintificName Where Sn_ID=@Sn_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSupllire]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteSupllire]
@Su_ID int
AS
    delete from  TblSupplire where Su_ID=@Su_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_DeleteUser]
(
@U_ID   int
)
AS
      Delete From TblUsers
	  Where U_ID = @U_ID 
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_FillAcviteMatrileComboBox]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_FillAcviteMatrileComboBox]
AS
  Select am.Am_ID ,Am.Am_Name From TblAcviteMatrile Am
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_FillCategoryComboBox]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_FillCategoryComboBox]
AS
  Select ca.Cat_ID ,ca.Cat_Name From TblCategory Ca
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_FillSecintificNameComboBox]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_FillSecintificNameComboBox]
AS
  Select sn.Sn_ID ,sn.Sn_Name From TblSecintificName Sn
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_GetExpiredDateProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_GetExpiredDateProduct]
(
@ID Bigint
)
AS
   Select EX_Date 'تاريخ الصلاحية',isnull(Qty,0) AS 'الكمية فى المخزن' From TblExpiredDate 
   Where  P_ID=@ID 
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_GetImageProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_GetImageProduct]
(
@ID bigint
)
AS
   Select P_Image From TblProduct 
   Where P_ID=@ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_GetSelectedProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_GetSelectedProduct]
@P_ID Int 
AS
Select Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   p.Barcode,
	   P.P_Description,
	   p.P_Image
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
  Where P.P_ID=@P_ID
Return   
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertActiveMatrile]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertActiveMatrile]
(
@Am_Name nvarchar(50),
@AM_Description nvarchar(MAX)
)
AS
   insert into TblAcviteMatrile (Am_Name,Am_Description) values (@Am_Name,@AM_Description)
return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertCategory]
@Cat_Name nvarchar(50)
AS
insert into TblCategory (Cat_Name) Values (@Cat_Name);
return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertCity]
(
@City_Name nvarchar(50),
@Country_ID  int
)
AS
      Insert  into TblCity   
	  (City_Name,Country_ID)
	  Values 
	  (@City_Name,@Country_ID)
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertControl]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_InsertControl]
@username nvarchar(50),
@password nvarchar(50),
@DateTime datetime ,
@Process nvarchar(max)
AS
  insert into TblControls (UserName,UPassword,UDateTime,Process) values (@username,@password,@DateTime,@Process)
Return 

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertCountry]
(
@CountryCode Nvarchar(4),
@CountryName Nvarchar(50)
)
AS
      Insert into TblCountry (Country_Code,Country_Name) Values (@CountryCode,@CountryName) 
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertCustomer]
(
@Cu_Name nvarchar(50),
@Cu_Address nvarchar(max),
@Cu_Mobile varchar(15),
@Cu_Image image,
@City_ID int
)
AS
      insert into TblCustomers 
	  (Cu_Name,Cu_Address,Cu_Mobile,Cu_Image,City_ID)
	  Values
	  (@Cu_Name,@Cu_Address,@Cu_Mobile,@Cu_Image,@City_ID)
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertMasege]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertMasege]
(
@MassegeTitle   nvarchar(50),
@MassegeDetails nvarchar(max),
@MDate           date,
@U_Name          nvarchar(50),
@ReadOrNoRead    nvarchar(50)         
)
As
        insert into TblMassege (MassegeTitle,MassegeDetails,MDate,U_Name,ReadOrNoRead) Values (@MassegeTitle,@MassegeDetails,@MDate,@U_Name,@ReadOrNoRead)
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertOrder]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_InsertOrder]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertProduct]
(
@P_Name nvarchar(50),
@P_Description nvarchar(max),
@P_Image image,
@BuyPrice varchar(50),
@SellPrice varchar(50),
@Cat_ID int,
@Am_ID int,
@Sn_ID int,
@Barcode varchar(50)
)
AS
Insert into TblProduct (P_Name,P_Description,P_Image,BuyPrice,SellPrice,Cat_ID,Am_ID,Sn_ID,Barcode)
       Values (@P_Name,@P_Description,@P_Image,@BuyPrice,@SellPrice,@Cat_ID,@Am_ID,@Sn_ID,@Barcode)
Return 

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRequst]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_InsertRequst]
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
   Fetch   @ExpiredDate into @EX_Date, @P_ID ,@Qty
   End   
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSecintificName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertSecintificName]
@Sn_Name nvarchar(50)
AS
 insert into TblSecintificName (Sn_Name) Values (@Sn_Name)
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSupplire]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertSupplire]
(
@Su_Name nvarchar(50),
@Su_Mobile varchar(15)
)
AS
      Insert Into TblSupplire (Su_Name,Su_Mobile) Values (@Su_Name,@Su_Mobile) 
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertUser]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_InsertUser]
(
@U_Name       nvarchar(50),
@U_Password   nvarchar(50),
@U_FullName   nvarchar(50),
@Per_ID       int
)
AS
      insert into TblUsers
	  (U_Name,U_Password,U_FullName,Per_ID) 
	  values 
	  (@U_Name,@U_Password,@U_FullName,@Per_ID) 
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_Login]
@UserName nvarchar(50),
@PassWord nvarchar(50)
as 
Select * From TblUsers Where U_Name=@UserName And U_Password=@PassWord
return
GO
/****** Object:  StoredProcedure [dbo].[SP_PirntOneRequest]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_PirntOneRequest]
@Req_ID int
AS
      Select R.Req_ID,R.Req_Date,R.Total,R.Buyer_Name,S.Su_Name, 
	  P.P_Name , RD.P_Price,Rd.Qty
	  From TblRequsts R , TblSupplire S,TblRequstDetails RD , TblProduct P
	  Where  R.Req_ID=RD.Req_ID And R.Su_ID=S.Su_ID And Rd.P_ID =P.P_ID And R.Req_ID= @Req_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_PrintOneProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_PrintOneProduct]
@P_ID int
As 
Select P.P_ID, 
	   Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   isnull (Sum (Convert(decimal,Ex.Qty)),0),
	   p.Barcode,
	   P.P_Description
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  where P.P_ID = @P_ID
  Group By P.P_ID,
           Ca.Cat_Name,
           P.P_Name,
	       Am.Am_Name,
	       Sn.Sn_Name,
	       p.SellPrice,
	       P.BuyPrice,
           p.Barcode,
	       P.P_Description
  Return


GO
/****** Object:  StoredProcedure [dbo].[SP_PrintOrders]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_PrintOrders]
(
@Order_ID int
)
AS
      select o.Order_ID,o.Order_Date,o.Total,o.Seler_Name,cu.Cu_Name,p.P_Name,od.P_Price,od.Qty 
	  from TblOrders o,TblOrderDetails od,TblCustomers cu,TblProduct p
      where o.Order_ID=od.Order_ID And cu.Cu_ID=o.Cu_ID And p.P_ID = od.P_ID And o.Order_ID =@Order_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchActiveMatrile]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SearchActiveMatrile]
@Search nvarchar(50)
AS
  select Am_ID 'معرف المادة' , Am_Name 'أسم المادة الفعالة' , Am_Description 'وصف المادة الفعالة' 
  From TblAcviteMatrile
  where convert (nvarchar,Am_ID)+Am_Name+Am_Description like '%'+@Search+'%'
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[SP_SearchCategory]
(
@Search Nvarchar(50)
)
AS 
Select Cat_ID 'معرف الأصناف' ,Cat_Name 'أسم الصنف' 
from TblCategory
where convert(nvarchar,Cat_ID) + Cat_Name Like '%' +@Search+'%' 
return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SearchCity]
@Search nvarchar(50)
AS
      Select C.City_ID'معرف المدينة',C.City_Name'أسم المدينة' , co.Country_Name 'أسم الدولة'
	  from TblCity C,TblCountry Co
	  where C.Country_ID=Co.Country_ID
	  and convert(nvarchar,City_ID)+City_Name+Country_Name
	  like '%' +@Search+ '%'
return
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SearchCountry]
@Search nvarchar(50)
AS
      Select  Country_ID 'معرف الدولة', Country_Code 'كود الدولة',Country_Name 'أسم الدولة' from TblCountry
      where   convert (nvarchar, Country_ID) + Country_Code + Country_Name 
	  like '%'+ @Search+'%'
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SearchCustomer]
@Search nvarchar(50)
AS
      select cu.Cu_ID'رقم العميل',cu.Cu_Name'أسم العميل',cu.Cu_Address'العنوان',cu.Cu_Mobile'رقم المحمول'
	  ,cu.Cu_Image 'الصورة', co.Country_Name 'الدولة',c.City_Name 'المدينة'
	  from TblCustomers cu,TblCity c,TblCountry co
      where cu.City_ID=c.City_ID
	  And c.Country_ID=co.Country_ID
	  And convert (nvarchar,cu.Cu_ID) +cu.Cu_Name +cu.Cu_Address + convert (nvarchar,cu.Cu_Mobile) +co.Country_Name +c.City_Name like '%'+@Search+'%'
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SearchProduct]
@Search nvarchar(50)
As 
Select * From
      (Select 
	   P.P_ID, 
	   Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   isnull (Sum (Convert(decimal,Ex.Qty)),0) Qty,
	   p.Barcode,
	   P.P_Description
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  Group By P.P_ID,
           Ca.Cat_Name,
           P.P_Name,
	       Am.Am_Name,
	       Sn.Sn_Name,
	       p.SellPrice,
	       P.BuyPrice,
           p.Barcode,
	       P.P_Description) Products
 Where 
 convert(nvarchar,P_ID) +  
	   Cat_Name      +
       P_Name        +
	   Am_Name       +
	   Sn_Name       +
	   BuyPrice      +
	   SellPrice     +
  convert(nvarchar,  Qty)+
	   Barcode       +
	   P_Description Like '%'+@Search+'%'
  Return


GO
/****** Object:  StoredProcedure [dbo].[SP_SearchSecintificName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  Procedure [dbo].[SP_SearchSecintificName]
@Search nvarchar(50)
AS
    Select Sn_ID 'معرف الأسم العلمى', Sn_Name 'الأسم العلمى' From TblSecintificName
 Where convert(nvarchar,Sn_ID)+ Sn_Name Like '%'+@Search+'%'
Return  
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchSupplier]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SearchSupplier]
@Search nvarchar(50)
AS
   Select Su_ID 'معرف الموردين' ,Su_Name 'أسم المورد',Su_Mobile 'رقم التليفون' From TblSupplire
where Convert(nvarchar,Su_ID) + Su_Name +Su_Mobile Like '%' +@Search+ '%'
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_SearchUser]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_SearchUser]
(
@Serach  nvarchar(50)
)
AS
     Select u.U_ID 'معرف المستخدم',u.U_Name'أسم المستخدم',u.U_Password'كلمة المرور',u.U_FullName'الأسم بالكامل',p.Per_Name'نوع الصلاحية' 
	  from TblUsers u,TblPermissions p
	  where u.Per_ID=p.Per_ID And
	  convert (nvarchar, u.U_ID)+ u.U_Name+ u.U_FullName + p.Per_Name like '%'+@Serach+'%'
	  Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelcetAllSupplier]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelcetAllSupplier]
AS
   Select Su_ID 'معرف الموردين' ,Su_Name 'أسم المورد',Su_Mobile 'رقم التليفون' From TblSupplire
Return


GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllActiveMatrile]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectAllActiveMatrile]

AS
  select Am_ID 'معرف المادة' , Am_Name 'أسم المادة الفعالة' , Am_Description 'وصف المادة الفعالة' From TblAcviteMatrile
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllCategory]
AS 
Select Cat_ID 'معرف الأصناف' ,Cat_Name 'أسم الصنف' from TblCategory
return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllCity]
AS
      Select C.City_ID'معرف المدينة',C.City_Name'أسم المدينة' , co.Country_Name 'أسم الدولة'
	  from TblCity C,TblCountry Co
	  where C.Country_ID=Co.Country_ID
return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllControls]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectAllControls]

AS
  Select co.UserName 'أسم المستخدم' , co.UPassword 'كلمة المرور',co.UDateTime 'تاريخ الدخول' ,co.Process 'العملية'
  from TblControls co
  group by UserName,UPassword,UDateTime,Process
  order by UDateTime
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllCountry]

AS
      Select  Country_ID 'معرف الدولة', Country_Code 'كود الدولة',Country_Name 'أسم الدولة' from TblCountry
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllCustomer]
AS
      select cu.Cu_ID'رقم العميل',cu.Cu_Name'أسم العميل',cu.Cu_Address'العنوان',cu.Cu_Mobile'رقم المحمول'
	  ,cu.Cu_Image 'الصورة', co.Country_Name 'الدولة',c.City_Name 'المدينة'
	  from TblCustomers cu,TblCity c,TblCountry co
      where cu.City_ID=c.City_ID
	  And c.Country_ID=co.Country_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllOrders]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectAllOrders]
AS
select o.Order_ID'معرف الفاتورة',o.Order_Date'تاريخ الفاتورة',o.Total'الأجمالي', c.Cu_Name 'أسم العميل',o.Seler_Name'أسم البائع' from TblOrders o,TblCustomers c
where c.Cu_ID=o.Cu_ID      
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllPermation]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllPermation]
AS
      Select Per_ID,Per_Name from TblPermissions
Return  
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllProduct]
As 
Select P.P_ID, 
	   Ca.Cat_Name,
       P.P_Name,
	   Am.Am_Name,
	   Sn.Sn_Name,
	   P.BuyPrice,
	   p.SellPrice,
	   isnull (Sum (Convert(decimal,Ex.Qty)),0),
	   p.Barcode,
	   P.P_Description
  FROM TblProduct P Join TblCategory Ca 
  on p.Cat_ID = ca.Cat_ID
                    Join TblAcviteMatrile Am
  on P.Am_ID = Am.Am_ID
                    join TblSecintificName Sn
  on P.Sn_ID=Sn.Sn_ID
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  Group By P.P_ID,
           Ca.Cat_Name,
           P.P_Name,
	       Am.Am_Name,
	       Sn.Sn_Name,
	       p.SellPrice,
	       P.BuyPrice,
           p.Barcode,
	       P.P_Description
  Return


GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllRequest]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectAllRequest]
AS
      Select r.Req_ID 'رقم الفاتورة',r.Req_Date 'تاريخ الفاتورة',s.Su_Name 'أسم المورد', r.Total 'الأجمالى'
	  From TblRequsts r ,TblSupplire s
	  where  r.Su_ID = s.Su_ID
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllSecintificName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectAllSecintificName]

AS
    Select Sn_ID 'معرف الأسم العلمى', Sn_Name 'الأسم العلمى' From TblSecintificName
 
Return  
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectAllUsers]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectAllUsers]
AS
     Select u.U_ID 'معرف المستخدم',u.U_Name'أسم المستخدم',u.U_Password'كلمة المرور',u.U_FullName'الأسم بالكامل',p.Per_Name'نوع الصلاحية' 
	  from TblUsers u,TblPermissions p
	  where u.Per_ID=p.Per_ID
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_SelectByIDSupplire]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_SelectByIDSupplire]
@Su_ID Int 
AS
    Select Su_Name,Su_Mobile  
	From TblSupplire 
	where Su_ID = @Su_ID 
Return
 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectCityByCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_SelectCityByCountry]
(
@countryID  int 
)
AS
       select City_ID,City_Name from TblCity 
	   where Country_ID= @countryID
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectCountMsg]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectCountMsg]
(@UName nvarchar(50),
@ReadOrNoRead nvarchar(50))
AS
    select count(ID) from TblMassege 
	Where U_Name =@UName
	And ReadOrNoRead = @ReadOrNoRead
Return 
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectCustomer]
AS
	SELECT Cu_ID 'كود العميل', Cu_Name 'أسم العميل',Cu_Mobile 'رقم التليفون' from TblCustomers 
RETURN
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectProductDetails]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_SelectProductDetails]
As 
Select P.P_ID 'معرف المنتج', 
       P.P_Name 'أسم المنتج',
	   P.SellPrice 'سعر بيع المنتج',
	   isnull (Sum (Convert(decimal,Ex.Qty)),0) 'الكمية',
	   p.Barcode 'الباركود'
  FROM TblProduct P 
               Left join TblExpiredDate Ex
  on P.P_ID = Ex.P_ID
  Group By P.P_ID,
           P.P_Name,
	       P.SellPrice,
           p.Barcode
return
GO
/****** Object:  StoredProcedure [dbo].[SP_ShowMessageByName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_ShowMessageByName]
(
@U_Name nvarchar(50)
)
AS
     Select MassegeTitle'عنوان الرسالة',MassegeDetails'تفاصيل الرسالة',MDate'تاريخ أرسال الرسالة',U_Name'أسم المستخدم',ReadOrNoRead 'تم عرض الرسالة' from TblMassege 
	 Where U_Name=@U_Name
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateActvieMatirel]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateActvieMatirel]
(
@Am_ID int,
@Am_Name nvarchar(50),
@Am_Desc nvarchar(max)
)

AS
   update TblAcviteMatrile Set  Am_Name= @Am_Name, Am_Description =@Am_Desc Where Am_ID = @Am_ID 
return 
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCategory]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_UpdateCategory]
(
@CatID int,
@CatName nvarchar(50)
)
AS
    update TblCategory Set Cat_Name=@CatName Where Cat_ID=@CatID
return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCity]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SP_UpdateCity]
(
@City_ID int ,
@City_Name nvarchar(50),
@Country_ID  int
)
AS
      update TblCity Set City_Name=@City_Name,
	  Country_ID = @Country_ID
	  where City_ID=@City_ID
Return  
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCountry]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_UpdateCountry]
(
@Country_ID    int,
@Country_Code  nvarchar(4),
@Country_Name  nvarchar(50)
)
As
      update  TblCountry Set Country_Code= @Country_Code,Country_Name =@Country_Name 
	  Where   Country_ID = @Country_ID
Return

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCustomer]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateCustomer]
(
@Cu_ID         int,
@Cu_Name       nvarchar(50),
@Cu_Address    nvarchar(max),
@Cu_Mobile     varchar(15),
@Cu_Image      image,
@City_ID       int
)
AS
      update TblCustomers 
	  set Cu_Name   = @Cu_Name,
	  Cu_Address    = @Cu_Address,
	  Cu_Mobile     = @Cu_Mobile,
	  Cu_Image      = @Cu_Image,
	  City_ID       = @City_ID
	  Where Cu_ID   = @Cu_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateMessageByName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_UpdateMessageByName]
(
@ReadOrNoRead nvarchar(50),
@U_Name nvarchar(50)
)
AS
       Update TblMassege set ReadOrNoRead = @ReadOrNoRead
	   Where U_Name =@U_Name
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateProduct]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateProduct]
(
@P_ID bigint,
@P_Name nvarchar(50),
@P_Description nvarchar(max),
@P_Image image,
@BuyPrice varchar(50),
@SellPrice varchar(50),
@Cat_ID int,
@Am_ID int,
@Sn_ID int,
@Barcode varchar(50)
)
AS
Update TblProduct Set P_Name=@P_Name,
                      P_Description=@P_Description,
					  P_Image=@P_Image,
					  BuyPrice=@BuyPrice,
					  SellPrice=@SellPrice,
					  Cat_ID=@Cat_ID,
					  Am_ID=@Am_ID,
					  Sn_ID=@Sn_ID,
					  Barcode=@Barcode
Where                 P_ID=@P_ID
Return 


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSecintifcName]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateSecintifcName]
(
@Sn_ID int,
@Sn_Name nvarchar(50)
)
AS
 Update TblSecintificName Set Sn_Name =@Sn_Name Where Sn_ID=@Sn_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSupllire]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateSupllire]
@Su_ID int,
@Su_Name nvarchar(50),
@Su_Mobile varchar(15)
AS
    update TblSupplire set Su_Name=@Su_Name,Su_Mobile= Su_Mobile
	where Su_ID=@Su_ID
Return
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateUser]    Script Date: 3/22/2018 12:58:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_UpdateUser]
(
@U_ID   int,
@U_Name nvarchar(50),
@U_Password nvarchar(50),
@U_FullName nvarchar(50),
@Per_ID int

)
AS
      Update TblUsers set U_Name = @U_Name, U_Password = @U_Password ,U_FullName= @U_FullName ,Per_ID = @Per_ID
	  Where U_ID = @U_ID 
Return

GO
