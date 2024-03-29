CREATE DATABASE DBMS_FINAL_PROJECT
GO

USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [QLTS_Admin]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE LOGIN [QLTS_Admin] WITH PASSWORD='123456', DEFAULT_DATABASE=[DBMS_FINAL_PROJECT], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [QLTS_nhanvien]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE LOGIN [QLTS_nhanvien] WITH PASSWORD='123456', DEFAULT_DATABASE=[DBMS_FINAL_PROJECT], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [QLTS_phongql]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE LOGIN [QLTS_phongql] WITH PASSWORD='123456', DEFAULT_DATABASE=[DBMS_FINAL_PROJECT], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

USE [DBMS_FINAL_PROJECT]
GO
/****** Object:  User [QLTS_Admin]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE USER [QLTS_Admin] FOR LOGIN [QLTS_Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [QLTS_nhanvien]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE USER [QLTS_nhanvien] FOR LOGIN [QLTS_nhanvien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [QLTS_phongql]Script Date: 5/16/2022 5:31:56 PM ******/
CREATE USER [QLTS_phongql] FOR LOGIN [QLTS_phongql] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [QLTS_Admin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [QLTS_nhanvien]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [QLTS_nhanvien]
GO
ALTER ROLE [db_datareader] ADD MEMBER [QLTS_phongql]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [QLTS_phongql]
GO
/****** Object:  UserDefinedFunction [dbo].[show_total_price_of_order]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[show_total_price_of_order]
(@order_id CHAR(8),@total REAL)
--In ra tổng tiền cho đơn hàng--
RETURNS REAL
	AS
	BEGIN
		SELECT @total = SUM(ORDER_PRODUCT.price) 
		FROM ORDER_PRODUCT
		WHERE ORDER_PRODUCT.order_id  = @order_id
		RETURN @total
	END
GO
ALTER AUTHORIZATION ON [dbo].[show_total_price_of_order] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[COST]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COST](
	[shop_ID] [char](8) NOT NULL,
	[water] [real] NULL,
	[electricity] [real] NULL,
	[ground] [real] NULL,
	[month_in_year] [int] NULL
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[COST] TO  SCHEMA OWNER 
GO
DENY CONTROL ON [dbo].[COST] TO [QLTS_nhanvien] AS [dbo]
GO
DENY DELETE ON [dbo].[COST] TO [QLTS_nhanvien] AS [dbo]
GO
DENY INSERT ON [dbo].[COST] TO [QLTS_nhanvien] AS [dbo]
GO
DENY SELECT ON [dbo].[COST] TO [QLTS_nhanvien] AS [dbo]
GO
DENY TAKE OWNERSHIP ON [dbo].[COST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[COST] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[CUSTOMER]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[c_phone_number] [char](11) NOT NULL,
	[birthday] [date] NULL,
	[address] [nchar](50) NULL,
	[type_cus] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[c_phone_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[CUSTOMER] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT DELETE ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT INSERT ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT SELECT ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT UPDATE ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[CUSTOMER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[CUSTOMER] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[EMPLOYEE]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[emp_ID] [int] IDENTITY(1,1) NOT NULL,
	[emp_name] [nchar](40) NOT NULL,
	[phone_number] [char](11) NULL,
	[emp_role] [char](10) NOT NULL,
	[begin_date] [date] NOT NULL,
	[shop_ID] [char](8) NOT NULL,
	[username] [char](40) NOT NULL,
	[password] [char](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[EMPLOYEE] TO  SCHEMA OWNER 
GO
DENY CONTROL ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
DENY DELETE ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
DENY INSERT ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
DENY SELECT ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
DENY UPDATE ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
DENY VIEW DEFINITION ON [dbo].[EMPLOYEE] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[EMPLOYEE] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[OFFICE]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OFFICE](
	[office_ID] [char](8) NOT NULL,
	[office_name] [nchar](35) NOT NULL,
	[phone_number] [char](11) NOT NULL,
	[office_address] [nchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[office_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[OFFICE] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[OFFICE] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[ORDER_LIST]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_LIST](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[c_phone_number] [char](11) NULL,
	[create_day] [date] NULL,
	[shop_id] [char](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[ORDER_LIST] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT DELETE ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT INSERT ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT SELECT ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[ORDER_LIST] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[ORDER_LIST] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[ORDER_PRODUCT]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_PRODUCT](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[ORDER_PRODUCT] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT DELETE ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT INSERT ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT SELECT ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[ORDER_PRODUCT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[ORDER_PRODUCT] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[PAYMENT]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT](
	[payment_method] [nchar](20) NULL,
	[voucher_id] [char](8) NULL,
	[payment_status] [char](10) NOT NULL,
	[payment_amount] [real] NOT NULL,
	[order_id] [int] NOT NULL,
 CONSTRAINT [PK__PAYMENT__ED1FC9EA0DBE5A44] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[PAYMENT] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT DELETE ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT INSERT ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT SELECT ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT UPDATE ON [dbo].[PAYMENT] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[PAYMENT] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[PRODUCT_IN_SHOP]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_IN_SHOP](
	[product_id] [int] NOT NULL,
	[shop_id] [char](8) NOT NULL,
	[status] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC,
	[shop_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[PRODUCT_IN_SHOP] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[PRODUCTS]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[cost] [real] NOT NULL,
	[production_cost] [real] NULL,
	[name_product] [nchar](40) NULL,
	[type] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[PRODUCTS] TO  SCHEMA OWNER 
GO
GRANT REFERENCES ON [dbo].[PRODUCTS] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT ALTER ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[PRODUCTS] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[SHOP]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHOP](
	[shop_ID] [char](8) NOT NULL,
	[shop_address] [nchar](40) NOT NULL,
	[phone_number] [char](11) NOT NULL,
	[office_ID] [char](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[shop_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[SHOP] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[SHOP] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[VOUCHER]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOUCHER](
	[voucher_id] [char](8) NOT NULL,
	[discount] [real] NOT NULL,
	[description] [nchar](50) NOT NULL,
	[start_day] [date] NOT NULL,
	[end_day] [date] NOT NULL,
	[voucher_constraint] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[voucher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[VOUCHER] TO  SCHEMA OWNER 
GO
DENY CONTROL ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
DENY DELETE ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
DENY INSERT ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
DENY SELECT ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
DENY UPDATE ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[VOUCHER] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[VOUCHER] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Table [dbo].[VOUCHER_ITEM]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOUCHER_ITEM](
	[voucher_id] [char](8) NOT NULL,
	[c_phone_number] [char](11) NOT NULL,
	[used] [char](3) NOT NULL,
	[Date_use] [date] NULL
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[VOUCHER_ITEM] TO  SCHEMA OWNER 
GO
/****** Object:  UserDefinedFunction [dbo].[show_menu_in_shop]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[show_menu_in_shop] (@shop_id CHAR(8))
--In ra những món trong menu của shop--
RETURNS TABLE
AS
RETURN 
		SELECT PRODUCTS.product_id,PRODUCTS.name_product,PRODUCTS.cost
		FROM PRODUCTS INNER JOIN PRODUCT_IN_SHOP
		ON (PRODUCTS.product_id = PRODUCT_IN_SHOP.product_id)
				AND	(PRODUCT_IN_SHOP.status='Y')
		WHERE PRODUCT_IN_SHOP.shop_id=@shop_id
GO
ALTER AUTHORIZATION ON [dbo].[show_menu_in_shop] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT DELETE ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT INSERT ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT SELECT ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT UPDATE ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[show_menu_in_shop] TO [QLTS_nhanvien] AS [dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[show_product_in_order]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[show_product_in_order] (@order_id INT)
-- In ra sản phẩm trong order --
RETURNS TABLE
AS
RETURN
	SELECT PRODUCTS.name_product Tên, 
					ORDER_PRODUCT.quantity Số_lượng,
					ORDER_PRODUCT.price Giá
	FROM ORDER_PRODUCT INNER JOIN PRODUCTS
	ON ORDER_PRODUCT.product_id = PRODUCTS.product_id
	WHERE ORDER_PRODUCT.order_id = @order_id
GO
ALTER AUTHORIZATION ON [dbo].[show_product_in_order] TO  SCHEMA OWNER 
GO
/****** Object:  UserDefinedFunction [dbo].[view_total_payment_of_cus]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[view_total_payment_of_cus](@c_phone_number char(11))
--In ra tổng chi tiêu của khách hàng --
--Chua:Hai--
RETURNS TABLE
AS
	RETURN 
		SELECT SUM(PAYMENT.payment_amount) TongTien
		FROM PAYMENT INNER JOIN ORDER_LIST
		ON ORDER_LIST.order_id = PAYMENT.order_id
		WHERE ORDER_LIST.c_phone_number=@c_phone_number;
GO
ALTER AUTHORIZATION ON [dbo].[view_total_payment_of_cus] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[view_total_payment_of_cus] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  View [dbo].[FEE]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FEE] AS SELECT 
--Xem tiền điện nước mặt bằng của các shop trong 3 tháng gần nhất--
--Viet roi: Dat--
	SUM	( electricity ) Tien_Dien,
	SUM ( water ) Tien_nuoc,
	SUM ( ground ) Tien_mat_bang,
	Cost.shop_ID 
FROM COST
WHERE
	 month_in_year >= MONTH(GETDATE())-3
GROUP BY
	COST.shop_ID
GO
ALTER AUTHORIZATION ON [dbo].[FEE] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[FEE] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  View [dbo].[HCM_SHOP]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HCM_SHOP] AS SELECT
--Những chuổi chi nhánh ở thành phố hcm--
--Viet : Hai--
	shop_ID,
	shop_address,
	Phone_number 
FROM
	dbo.SHOP 
WHERE
	office_ID = 'OF_HCM'
GO
ALTER AUTHORIZATION ON [dbo].[HCM_SHOP] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[OVER_1_MONTH_WORK]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OVER_1_MONTH_WORK] AS --Viet roi: Dat--
SELECT
	emp_ID,
	emp_name,
	emp_role,
	begin_date 
FROM
	EMPLOYEE 
WHERE
	DATEDIFF( DAY, begin_date, GETDATE( ) ) >= 30 
	AND DATEDIFF( DAY, begin_date, GETDATE( ) ) <= 90
GO
ALTER AUTHORIZATION ON [dbo].[OVER_1_MONTH_WORK] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT DELETE ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT INSERT ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT REFERENCES ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT SELECT ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT UPDATE ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[OVER_1_MONTH_WORK] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  View [dbo].[UNPAID_ORDER]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UNPAID_ORDER] AS --Viet roi: Dat--
SELECT
--Xem những đơn hàng chưa thanh toán--
	PAYMENT.order_id,
	ORDER_LIST.c_phone_number,
	payment_amount,
	payment_method,
	payment_status 
FROM
	PAYMENT
	INNER JOIN ORDER_LIST ON ORDER_LIST.order_id= PAYMENT.order_id 
WHERE
	payment_status = 'N'
GO
ALTER AUTHORIZATION ON [dbo].[UNPAID_ORDER] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[VOUCHER_TODAY]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VOUCHER_TODAY] AS --Viet: Hai--
SELECT
--Xem những voucher còn hạn sử dụng--
	voucher_id,
	start_day,
	description 
FROM
	dbo.VOUCHER 
WHERE
	end_day > GETDATE( )
GO
ALTER AUTHORIZATION ON [dbo].[VOUCHER_TODAY] TO  SCHEMA OWNER 
GO
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 400000, 600000, 4500000, 1)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 390000, 800000, 5000000, 2)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 550000, 760000, 5000000, 3)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 460000, 800000, 5000000, 4)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH01', 320000, 800000, 5000000, 5)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 400000, 600000, 5000000, 2)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 600000, 800000, 4500000, 2)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 600000, 700000, 4500000, 3)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 650000, 680000, 4500000, 4)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH02', 400000, 780000, 4500000, 5)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 500000, 680000, 5000000, 3)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 450000, 450000, 5500000, 2)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 600000, 470000, 5500000, 3)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 650000, 420000, 5500000, 4)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH03', 620000, 430000, 5500000, 5)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 600000, 580000, 5000000, 4)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH04', 450000, 750000, 5000000, 5)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 600000, 700000, 4500000, 2)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 700000, 800000, 4500000, 3)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 680000, 900000, 4500000, 4)
INSERT [dbo].[COST] ([shop_ID], [water], [electricity], [ground], [month_in_year]) VALUES (N'SH05', 720000, 1200000, 4500000, 5)
GO
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'01 ', CAST(N'2000-01-01' AS Date), N'KH Vãng lai ', N'NONE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0289991025 ', CAST(N'2001-10-07' AS Date), N'Q7 - Tp Hồ Chí Minh ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0355878898 ', CAST(N'2000-07-26' AS Date), N'Mỏ Cày -  Bến Tre ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0356264391 ', CAST(N'2000-04-09' AS Date), N'Tân Bình - Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0356524956 ', CAST(N'2002-10-03' AS Date), N'Thủ Đức - Tp Hồ Chí Minh  ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0356548452 ', CAST(N'2003-01-30' AS Date), N'Q4- Tp Hồ Chí Minh', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0356588892 ', CAST(N'2002-04-17' AS Date), N'Thủ Đức - Tp Hồ Chí Minh  ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'039549845  ', CAST(N'2022-06-05' AS Date), N'Tp,Hồ Chí Minh', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0399745256 ', CAST(N'2005-11-05' AS Date), N'Phú Nhuận -Tp Hồ Chí Minh ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0563221678 ', CAST(N'2001-06-13' AS Date), N'Châu Đức - Vũng Tàu ', N'GOLD')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'064985884  ', CAST(N'2002-09-05' AS Date), N'Hà Nội', N'MEMBER	   ')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0814069391 ', CAST(N'2002-12-26' AS Date), N'Q3-Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0815653456 ', CAST(N'1998-12-15' AS Date), N'Mỏ Cày - Bến Tre  ', N'MEMBER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0815698565 ', CAST(N'1998-07-03' AS Date), N'Tân Bình - Tp Hồ Chí Minh ', N'GOLD')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0845656365 ', CAST(N'2007-04-08' AS Date), N'Thủ Đức - Tp Hồ Chí Minh  ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0895626225 ', CAST(N'2004-04-27' AS Date), N'Châu Thành - Trà Vinh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0896555636 ', CAST(N'2001-06-21' AS Date), N'Châu Thành - Trà Vinh ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0908745624 ', CAST(N'2004-02-16' AS Date), N'Q8 - Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0909453441 ', CAST(N'1995-12-24' AS Date), N'Q5 - Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0909456277 ', CAST(N'1972-10-15' AS Date), N'Phú Nhuận- Tp Hồ Chí Minh ', N'MEMBER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0909457588 ', CAST(N'2004-11-02' AS Date), N'Q9 - Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0945255332 ', CAST(N'2002-09-10' AS Date), N'Q9 - Tp Hồ Chí Minh ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0945255641 ', CAST(N'2005-03-15' AS Date), N'Sơn Tịnh - Quãng Ngãi ', N'MEMBER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0956478898 ', CAST(N'2004-05-06' AS Date), N'Tân Bình- Tp Hồ Chí Minh  ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0965565325 ', CAST(N'2000-03-29' AS Date), N'Ba Tri - Bến Tre  ', N'BRONZE')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0980000001 ', CAST(N'2002-01-01' AS Date), N'Thủ Đức, Tp Hồ Chí Minh   ', N'SILVER')
INSERT [dbo].[CUSTOMER] ([c_phone_number], [birthday], [address], [type_cus]) VALUES (N'0980000002 ', CAST(N'2000-01-10' AS Date), N'Q2-Tp Hồ Chí Minh ', N'BRONZE')
GO
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON 

INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (1, N'Johnny Dat', N'03935000100', N'CO_FOUNDER', CAST(N'2022-01-01' AS Date), N'SH01', N'adminDat', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (2, N'Hai Pug ', N'03935000101', N'CO_FOUNDER', CAST(N'2022-01-01' AS Date), N'SH02', N'adminHai', N'1234')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (4, N'Tien Pham ', N'03935000102', N'CO_FOUNDER', CAST(N'2020-01-01' AS Date), N'SH01', N'adminTien ', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (5, N'Mayuko Quy', N'03935000103', N'CO_FOUNDER', CAST(N'2020-01-01' AS Date), N'SH02', N'adminQuy', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (6, N'Nguyen Van An   ', N'03935000104', N'PhaChe', CAST(N'2022-04-01' AS Date), N'SH01', N'acc001  ', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (7, N'LeeHari ', N'03935461111', N'PhaChe', CAST(N'2021-01-01' AS Date), N'SH01', N'acc00010', N'123456  ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (8, N'Lê Hồng Quang   ', N'0381231234 ', N'BaoVe ', CAST(N'2021-04-12' AS Date), N'SH01', N'acc00011', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (9, N'Cao Quý ', N'0123456', N'QuanLy', CAST(N'2002-02-01' AS Date), N'SH02', N'quyhamhoc ', N'123456  ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (10, N'Hai Lể  ', N'039350001  ', N'QuanLy', CAST(N'2020-03-12' AS Date), N'SH02', N'Hai L?  ', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (11, N'AAAA', N'1111 ', N'PhaChe', CAST(N'2002-01-01' AS Date), N'SH02', N'admin1  ', N'1234')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (12, N'Lee Hari', N'0395454645 ', N'QuanLy', CAST(N'2022-03-15' AS Date), N'SH01', N'lehia   ', N'123456  ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (13, N'Nguyễn Hải', N'0395465843 ', N'BaoVe ', CAST(N'2022-05-20' AS Date), N'SH04', N'nvhai   ', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (14, N'Quý Ba Khoang   ', N'0397964668 ', N'PhucVu', CAST(N'2022-04-03' AS Date), N'SH05', N'nvquy   ', N'123456  ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (15, N'Nguyễn Văn Đạt  ', N'02168484646', N'QuanLy', CAST(N'2022-03-26' AS Date), N'SH03', N'nvdat   ', N'12345   ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (16, N'Lê Nguyên ', N'056482315  ', N'BaoVe ', CAST(N'2022-02-24' AS Date), N'SH02', N'nvle', N'65897\  ')
INSERT [dbo].[EMPLOYEE] ([emp_ID], [emp_name], [phone_number], [emp_role], [begin_date], [shop_ID], [username], [password]) VALUES (17, N'Nguyen Chien', N'06879456465', N'BaoVe ', CAST(N'2022-03-03' AS Date), N'SH02', N'chien   ', N'chien123')
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
GO
INSERT [dbo].[OFFICE] ([office_ID], [office_name], [phone_number], [office_address]) VALUES (N'OF_HCM  ', N'Văn Phòng Đại Diện Tp Hồ Chí Minh  ', N'19001010   ', N'Quận 1, Tp Hồ Chí Minh  ')
INSERT [dbo].[OFFICE] ([office_ID], [office_name], [phone_number], [office_address]) VALUES (N'OF_HN   ', N'Văn Phòng Đại Diện Hà Nội  ', N'19001020   ', N'Hoàn  Kiếm, Tp Hà Nội   ')
GO
SET IDENTITY_INSERT [dbo].[ORDER_LIST] ON 

INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (1, N'01 ', CAST(N'2022-04-27' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (2, N'01 ', CAST(N'2022-04-27' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (3, N'0399745256 ', CAST(N'2022-04-27' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (4, N'01 ', CAST(N'2022-04-27' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (5, N'0399745256 ', CAST(N'2022-04-29' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (9, N'01 ', CAST(N'2022-05-07' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (10, N'0355878898 ', CAST(N'2022-05-07' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (15, N'0355878898 ', CAST(N'2022-05-08' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (17, N'0356524956 ', CAST(N'2022-05-08' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (18, N'0895626225 ', CAST(N'2022-05-08' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (19, N'0895626225 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (20, N'0895626225 ', CAST(N'2022-05-08' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (21, N'0895626225 ', CAST(N'2022-05-08' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (22, N'0289991025 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (23, N'0399745256 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (24, N'01 ', CAST(N'2022-05-08' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (25, N'01 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (26, N'0815698565 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (27, N'0909453441 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (28, N'0980000001 ', CAST(N'2022-05-08' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (29, N'0289991025 ', CAST(N'2022-05-17' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (30, N'0356264391 ', CAST(N'2022-05-17' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (31, N'0356548452 ', CAST(N'2022-05-17' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (32, N'0356588892 ', CAST(N'2022-05-20' AS Date), N'SH05')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (33, N'0563221678 ', CAST(N'2022-05-21' AS Date), N'SH05')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (35, N'0895626225 ', CAST(N'2022-05-22' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (36, N'0908745624 ', CAST(N'2022-05-24' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (37, N'0909456277 ', CAST(N'2022-05-12' AS Date), N'SH03')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (38, N'0945255332 ', CAST(N'2022-05-14' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (39, N'0965565325 ', CAST(N'2022-05-21' AS Date), N'SH05')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (40, N'0909453441 ', CAST(N'2022-05-17' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (41, N'0814069391 ', CAST(N'2022-05-17' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (42, N'0815698565 ', CAST(N'2022-05-18' AS Date), N'SH03')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (43, N'0845656365 ', CAST(N'2022-05-18' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (44, N'0909453441 ', CAST(N'2022-05-19' AS Date), N'SH05')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (45, N'0814069391 ', CAST(N'2022-05-21' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (46, N'0814069391 ', CAST(N'2022-05-21' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (47, N'0815698565 ', CAST(N'2022-05-23' AS Date), N'SH02')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (48, N'0845656365 ', CAST(N'2022-05-28' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (49, N'0980000001 ', CAST(N'2022-05-29' AS Date), N'SH05')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (50, N'01 ', CAST(N'2022-05-25' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (51, N'0814069391 ', CAST(N'2022-05-25' AS Date), N'SH04')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (52, N'0980000001 ', CAST(N'2022-05-16' AS Date), N'SH01')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (53, N'0909457588 ', CAST(N'2022-05-16' AS Date), N'SH03')
INSERT [dbo].[ORDER_LIST] ([order_id], [c_phone_number], [create_day], [shop_id]) VALUES (54, N'0399745256 ', CAST(N'2022-05-16' AS Date), N'SH04')
SET IDENTITY_INSERT [dbo].[ORDER_LIST] OFF
GO
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (1, 1, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (1, 17, 2, 250000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 2, 2, 80000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 10, 2, 60000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (3, 11, 2, 200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (4, 25, 6, 1320000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (5, 3, 10, 350000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (9, 5, 8, 200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (9, 22, 10, 2500000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (10, 20, 6, 720000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (15, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (17, 2, 1, 40000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (18, 5, 1, 25000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (19, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (20, 7, 1, 32000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (21, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 1, 1, 25300)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 6, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (22, 25, 2, 440000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (23, 5, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (23, 10, 2, 60000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (24, 4, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 2, 2, 80000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 6, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 7, 2, 64000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (25, 23, 2, 200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (26, 6, 6, 150000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (26, 22, 2, 500000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (27, 5, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (27, 14, 8, 1040000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 7, 4, 128000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 14, 4, 520000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (28, 25, 3, 660000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 9, 1, 28000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 10, 1, 30000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (29, 11, 2, 200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 3, 4, 140000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 4, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (30, 25, 4, 880000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (31, 4, 3, 75000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (31, 5, 3, 75000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (32, 3, 2, 70000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (32, 18, 10, 1100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (33, 1, 15, 379500)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (33, 4, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (35, 2, 4, 160000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (35, 13, 4, 800000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (36, 4, 10, 250000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (36, 15, 10, 1200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 3, 15, 525000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 26, 3, 840000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (37, 29, 3, 720000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 2, 3, 120000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 5, 5, 125000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 19, 5, 700000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (38, 25, 4, 880000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 4, 1, 25000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 10, 5, 150000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (39, 19, 4, 560000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (40, 1, 1, 25300)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (40, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (41, 7, 1, 32000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 14, 1, 130000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 26, 1, 280000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (42, 29, 3, 720000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (43, 27, 2, 450000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (43, 30, 3, 660000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (44, 4, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (44, 29, 4, 960000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (45, 3, 4, 140000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (45, 6, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (46, 22, 2, 500000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (46, 25, 2, 440000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (47, 3, 2, 70000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (47, 18, 2, 220000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (47, 19, 2, 280000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (47, 23, 2, 200000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (48, 4, 2, 50000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (48, 7, 3, 96000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (49, 3, 3, 105000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (49, 11, 3, 300000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (50, 5, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (51, 5, 4, 100000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (51, 7, 4, 128000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (52, 2, 1, 40000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (53, 3, 1, 35000)
INSERT [dbo].[ORDER_PRODUCT] ([order_id], [product_id], [quantity], [price]) VALUES (54, 6, 1, 25000)
GO
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 350000, 1)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 0, 2)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', N'SILVERVC', N'DONE', 340000, 3)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1320000, 4)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'SILVERVC', N'DONE', 350000, 5)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 2700000, 9)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'THANG4VV', N'DONE', 720000, 10)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', N'SALE105 ', N'DONE', 35000, 15)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 40000, 17)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', N'SALE105 ', N'DONE', 25000, 18)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', N'SALE105 ', N'DONE', 35000, 19)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', N'SALE105 ', N'DONE', 32000, 20)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 35000, 21)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 550300, 22)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', N'SALE105 ', N'DONE', 160000, 23)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 50000, 24)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 394000, 25)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', N'TRIAN2  ', N'DONE', 650000, 26)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', N'TRIAN2  ', N'DONE', 1140000, 27)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1308000, 28)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 258000, 29)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1120000, 30)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 150000, 31)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 1170000, 32)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 479500, 33)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 960000, 35)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 1450000, 36)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 2085000, 37)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1825000, 38)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 735000, 39)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Momo', NULL, N'DONE', 60300, 40)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 32000, 41)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 1130000, 42)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1110000, 43)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 1010000, 44)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 190000, 45)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 940000, 46)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 770000, 47)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 146000, 48)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', NULL, N'DONE', 405000, 49)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'', NULL, N'DONE', 100000, 50)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Giao hàng   ', NULL, N'DONE', 228000, 51)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 40000, 52)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'TT  ', NULL, N'N ', 35000, 53)
INSERT [dbo].[PAYMENT] ([payment_method], [voucher_id], [payment_status], [payment_amount], [order_id]) VALUES (N'Trực tiếp   ', N'KETTHUC ', N'DONE', 25000, 54)
GO
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (1, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (2, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (3, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH02', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (4, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (5, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (6, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (7, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (8, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (9, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (10, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (11, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH02', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (12, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH04', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (13, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (14, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (15, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH02', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (16, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH04', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (17, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (18, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (19, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (20, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH02', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH04', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (21, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH01', N'Y ')
GO
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (22, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (23, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH01', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH02', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (24, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH01', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH02', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (25, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH04', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (26, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (27, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH03', N'N ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (28, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH03', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (29, N'SH05', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH04', N'Y ')
INSERT [dbo].[PRODUCT_IN_SHOP] ([product_id], [shop_id], [status]) VALUES (30, N'SH05', N'Y ')
GO
SET IDENTITY_INSERT [dbo].[PRODUCTS] ON 

INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (1, 25300, 4500, N'Trà sữa truyền thống', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (2, 40000, 5000, N'Mỳ Cay ĐB Lv1-7 ', N'FOOD')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (3, 35000, 5000, N'Mỳ Cay Lv1-7', N'FOOD')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (4, 25000, 5000, N'Dừa Tắc ', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (5, 25000, 5000, N'Trà Đào ', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (6, 25000, 5000, N'Trà Tắc ', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (7, 32000, 6000, N'Trà Sữa Bạc Hà  ', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (8, 30000, 5500, N'Trà Sữa Hoa Đậu Biếc', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (9, 28000, 5500, N'Trà sữa Thái', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (10, 30000, 5500, N'Trà Sữa Lài ', N'DRINK ')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (11, 100000, 50000, N'Bánh cua bơ ngọt', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (12, 150000, 45000, N'Bánh phô mai', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (13, 200000, 60000, N'Bánh nguyên kem ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (14, 130000, 65000, N'Bánh bơ việt quất ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (15, 120000, 50000, N'Bánh mứt dâu', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (16, 180000, 50000, N'Bánh lan kem bơ ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (17, 125000, 55000, N'Bánh lan trứng muối ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (18, 110000, 54000, N'Bánh phô mai chanh dây  ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (19, 140000, 64000, N'Bánh lan kem xoài ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (20, 120000, 60000, N'Bánh kem chese  ', N'CAKE')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (21, 200000, 20000, N'Mì xào xá xíu   ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (22, 250000, 25000, N'Tobooki phô mai ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (23, 100000, 30000, N'Gà rán sốt cay  ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (24, 230000, 15000, N'Gà rút xương', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (25, 220000, 20000, N'Gà sốt chua ngọt', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (26, 280000, 20000, N'Bạch tuộc sốt bơ tỏi', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (27, 225000, 15000, N'Bạch tuộc sốt phô mai   ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (28, 210000, 24000, N'Pizza   ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (29, 240000, 14000, N'Bánh tráng cuộn ', N'food')
INSERT [dbo].[PRODUCTS] ([product_id], [cost], [production_cost], [name_product], [type]) VALUES (30, 220000, 20000, N'Cá viên chiên   ', N'food')
SET IDENTITY_INSERT [dbo].[PRODUCTS] OFF
GO
INSERT [dbo].[SHOP] ([shop_ID], [shop_address], [phone_number], [office_ID]) VALUES (N'SH01', N'Hoàng Diệu 2,P.Linh Trung, Thủ Đức', N'19001020   ', N'OF_HCM  ')
INSERT [dbo].[SHOP] ([shop_ID], [shop_address], [phone_number], [office_ID]) VALUES (N'SH02', N'Thảo Điền, Q2, Tp Hồ Chí Minh   ', N'19001030   ', N'OF_HCM  ')
INSERT [dbo].[SHOP] ([shop_ID], [shop_address], [phone_number], [office_ID]) VALUES (N'SH03', N'Hồ Gươm, Hà Nội ', N'19002044   ', N'OF_HN   ')
INSERT [dbo].[SHOP] ([shop_ID], [shop_address], [phone_number], [office_ID]) VALUES (N'SH04', N'Đường 48, P.Hiệp Bình Chánh, Thủ Đức', N'19002535   ', N'OF_HCM  ')
INSERT [dbo].[SHOP] ([shop_ID], [shop_address], [phone_number], [office_ID]) VALUES (N'SH05', N'Đống Đa, Hà Nội ', N'19002277   ', N'OF_HN   ')
GO
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'10THANG3', 0.1, N'Giổ tổ Hùng Vương giảm 10%', CAST(N'2022-04-08' AS Date), CAST(N'2022-04-12' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'CATHANG4', 0.1, N'Cá tháng 4 giảm 10% ', CAST(N'2022-03-31' AS Date), CAST(N'2022-04-02' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'CLOSEPJC', 0.2, N'Giảm giá 20%', CAST(N'2022-05-20' AS Date), CAST(N'2022-06-05' AS Date), N'SIVER ')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'KETTHUC ', 0.5, N'Kết thúc close beta ', CAST(N'2022-05-15' AS Date), CAST(N'2022-06-02' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'KTMON   ', 0.4, N'Ket thuc mon', CAST(N'2022-05-12' AS Date), CAST(N'2022-05-24' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'QTLAODON', 0.1, N'Giảm giá 10% quốc tế lao động ', CAST(N'2022-05-01' AS Date), CAST(N'2022-05-06' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'SALE105 ', 0.15, N'SALE tháng năm 15%', CAST(N'2022-05-05' AS Date), CAST(N'2022-05-20' AS Date), N'BRONZE')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'SILVERVC', 0.2, N'KH bạc giảm 20%   ', CAST(N'2022-04-24' AS Date), CAST(N'2022-04-30' AS Date), N'SILVER')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'THANG4VV', 0.05, N'Tháng 4 vui vẽ 5% ', CAST(N'2022-04-01' AS Date), CAST(N'2022-04-30' AS Date), N'MEMBER')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'TRIAN2  ', 0.15, N'Tri ân KH tháng 5 ', CAST(N'2022-04-30' AS Date), CAST(N'2022-05-15' AS Date), N'GOLD')
INSERT [dbo].[VOUCHER] ([voucher_id], [discount], [description], [start_day], [end_day], [voucher_constraint]) VALUES (N'TRIANVIP', 0.2, N'Tri ân khách hàng thường niên ', CAST(N'2022-04-01' AS Date), CAST(N'2022-04-15' AS Date), N'GOLD')
GO
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0814069391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0895626225 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'10THANG3', N'0980000002 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0356264391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0563221678 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0815698565 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0845656365 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0908745624 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIANVIP', N'0909453441 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0814069391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0895626225 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'CATHANG4', N'0980000002 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0289991025 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0355878898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0815653456 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0909456277 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0945255332 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0945255641 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'THANG4VV', N'0980000001 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0356264391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0563221678 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0815698565 ', N'yes', CAST(N'2022-05-08' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0845656365 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0908745624 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'TRIAN2  ', N'0909453441 ', N'yes', CAST(N'2022-05-08' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SILVERVC', N'0356548452 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SILVERVC', N'0356588892 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SILVERVC', N'0399745256 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SILVERVC', N'0909457588 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SILVERVC', N'0965565325 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0399745256 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0814069391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0895626225 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'QTLAODON', N'0980000002 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0355878898 ', N'yes', CAST(N'2022-05-08' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0399745256 ', N'yes', CAST(N'2022-05-08' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0814069391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0895626225 ', N'yes', CAST(N'2022-05-08' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'SALE105 ', N'0980000002 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0289991025 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0355878898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0399745256 ', N'yes', CAST(N'2022-05-16' AS Date))
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0814069391 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0815698565 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0845656365 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0965565325 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KETTHUC ', N'0980000002 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0289991025 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0355878898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0356524956 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'039549845  ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0399745256 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0896555636 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0956478898 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0965565325 ', N'no ', NULL)
INSERT [dbo].[VOUCHER_ITEM] ([voucher_id], [c_phone_number], [used], [Date_use]) VALUES (N'KTMON   ', N'0980000002 ', N'no ', NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [username]Script Date: 5/16/2022 5:31:56 PM ******/
ALTER TABLE [dbo].[EMPLOYEE] ADD  CONSTRAINT [username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[COST]  WITH CHECK ADD FOREIGN KEY([shop_ID])
REFERENCES [dbo].[SHOP] ([shop_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [shop_ID] FOREIGN KEY([shop_ID])
REFERENCES [dbo].[SHOP] ([shop_ID])
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [shop_ID]
GO
ALTER TABLE [dbo].[ORDER_LIST]  WITH CHECK ADD FOREIGN KEY([c_phone_number])
REFERENCES [dbo].[CUSTOMER] ([c_phone_number])
GO
ALTER TABLE [dbo].[ORDER_LIST]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_LIST_shopid] FOREIGN KEY([shop_id])
REFERENCES [dbo].[SHOP] ([shop_ID])
GO
ALTER TABLE [dbo].[ORDER_LIST] CHECK CONSTRAINT [FK_ORDER_LIST_shopid]
GO
ALTER TABLE [dbo].[ORDER_PRODUCT]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[ORDER_LIST] ([order_id])
GO
ALTER TABLE [dbo].[ORDER_PRODUCT]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[PRODUCTS] ([product_id])
GO
ALTER TABLE [dbo].[PAYMENT]  WITH CHECK ADD FOREIGN KEY([voucher_id])
REFERENCES [dbo].[VOUCHER] ([voucher_id])
GO
ALTER TABLE [dbo].[PAYMENT]  WITH CHECK ADD  CONSTRAINT [FK_PAYMENT_order_id] FOREIGN KEY([order_id])
REFERENCES [dbo].[ORDER_LIST] ([order_id])
GO
ALTER TABLE [dbo].[PAYMENT] CHECK CONSTRAINT [FK_PAYMENT_order_id]
GO
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[PRODUCTS] ([product_id])
GO
ALTER TABLE [dbo].[PRODUCT_IN_SHOP]  WITH CHECK ADD FOREIGN KEY([shop_id])
REFERENCES [dbo].[SHOP] ([shop_ID])
GO
ALTER TABLE [dbo].[SHOP]  WITH CHECK ADD FOREIGN KEY([office_ID])
REFERENCES [dbo].[OFFICE] ([office_ID])
GO
ALTER TABLE [dbo].[VOUCHER_ITEM]  WITH CHECK ADD FOREIGN KEY([c_phone_number])
REFERENCES [dbo].[CUSTOMER] ([c_phone_number])
GO
ALTER TABLE [dbo].[VOUCHER_ITEM]  WITH CHECK ADD FOREIGN KEY([voucher_id])
REFERENCES [dbo].[VOUCHER] ([voucher_id])
GO
CREATE PROC [dbo].[login]
@username CHAR(40),
@pass CHAR(40)
AS
    BEGIN
        SELECT *
        FROM EMPLOYEE
		WHERE 
            username=@username 
			and password =@pass
    END
/****** Object:  StoredProcedure [dbo].[add_new_Customer]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_new_Customer]
--Thêm vào khách  hàng mới--
(@c_phone char(11), 
 @birthday date, 
 @address nchar(50), 
 @Type_cus char(10) )
AS 
	INSERT INTO CUSTOMER (c_phone_number,birthday,address,type_cus) 
					VALUES (@c_phone,@birthday,@address,@Type_cus)
GO
ALTER AUTHORIZATION ON [dbo].[add_new_Customer] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[add_new_Customer] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[add_new_Customer] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[add_new_Customer] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT CONTROL ON [dbo].[add_new_Customer] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[add_new_Customer] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[add_new_Customer] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[add_new_employee]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_new_employee] 
@username CHAR(40), 
@password CHAR(40),
@emp_name NCHAR(40),
@phone_number CHAR(11),
@emp_role CHAR(10),
@begin_date DATE,
@shop_ID CHAR(8)
AS
--Thêm vào nhân viên mới--
	INSERT INTO EMPLOYEE(emp_name,phone_number,emp_role,begin_date,
							shop_id,username,password)
	VALUES(@emp_name,@phone_number,@emp_role,@begin_date,@shop_id,@username,@password);
GO
ALTER AUTHORIZATION ON [dbo].[add_new_employee] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[add_new_Voucher]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm vào voucher--
CREATE PROCEDURE [dbo].[add_new_Voucher](
	@voucher_id CHAR ( 8 ), 
	@discount REAL, 
	@description NCHAR ( 50 ),
	@start_day DATE, 
	@end_day DATE,
	@voucher_constraint CHAR ( 10 )) 
	AS 
	--Thêm vào voucher mới
		INSERT INTO VOUCHER ( voucher_id, discount, description, start_day, end_day,	voucher_constraint )
	VALUES
	( @voucher_id,@discount,@description,@start_day,@end_day,@voucher_constraint )
GO
ALTER AUTHORIZATION ON [dbo].[add_new_Voucher] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[add_new_Voucher] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[add_new_Voucher] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[add_new_Voucher] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[checkout_order]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Checkout đơn hàng dùng update --
CREATE PROC [dbo].[checkout_order] 
	@order_id INT,
	@payment_method NCHAR(20),
	@voucher_id CHAR(8)
AS
	UPDATE PAYMENT
	SET 
		payment_method = @payment_method,
		payment_status='DONE',
		voucher_id = @voucher_id
	WHERE
		order_id = @order_id;
GO
ALTER AUTHORIZATION ON [dbo].[checkout_order] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[checkout_order] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[checkout_order] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[checkout_order] TO [QLTS_nhanvien] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[count_voucher_in_month]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Chua: Tien--
CREATE PROCEDURE [dbo].[count_voucher_in_month]
	@month INT
AS
BEGIN
	--Voucher nào được sử dụng nhiều nhất trong tháng--
	SELECT TOP(1) voucher_id, count(voucher_id) as count
	FROM VOUCHER_ITEM
	WHERE MONTH(Date_use) = @month
	GROUP BY voucher_id
	ORDER BY count DESC
END;
GO
ALTER AUTHORIZATION ON [dbo].[count_voucher_in_month] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[count_voucher_in_month] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[count_voucher_in_month] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[count_voucher_in_month] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[del_product]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa Sản Phẩm --
CREATE PROCEDURE [dbo].[del_product]
@name_product NCHAR(40)
AS
	DELETE FROM PRODUCTS WHERE PRODUCTS.name_product = @name_product
GO
ALTER AUTHORIZATION ON [dbo].[del_product] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[del_product] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[del_product] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[del_product] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[delete_order_trans]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa đơn hàng dùng transaction--
CREATE PROCEDURE [dbo].[delete_order_trans]
		@order_id INT
AS
	BEGIN
		BEGIN TRANSACTION;
		SAVE TRANSACTION savespoint;
			BEGIN	TRY
					DELETE FROM PAYMENT WHERE order_id = @order_id;
					DELETE FROM ORDER_PRODUCT	WHERE order_id = @order_id;
					DELETE FROM ORDER_LIST WHERE order_id = @order_id;
					COMMIT TRANSACTION
			END TRY
			BEGIN CATCH
					IF @@TRANCOUNT > 0
					BEGIN
							ROLLBACK TRANSACTION savespoint;
					END
			END CATCH
	END;
GO
ALTER AUTHORIZATION ON [dbo].[delete_order_trans] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[delete_order_trans] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[delete_order_trans] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[delete_order_trans] TO [QLTS_nhanvien] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[diff_btw_cost_each_month]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Viet roi: Dat--
CREATE PROC [dbo].[diff_btw_cost_each_month]
	@shop_id	CHAR(8)
AS
BEGIN
		-- Phân tích chênh lệch chi phí duy trì hàng tháng của shop--
		SELECT shop_id,
			 month_in_year,
			 total,
			 total - LAG(total,1)	OVER (ORDER BY month_in_year) AS cost_delta,
			 CASE
					WHEN ( total - LAG(total,1)	OVER (ORDER BY month_in_year)) < 0 
					THEN N'Giảm'
					ELSE N'Tăng'			 
			 END AS Message
		FROM 
				(SELECT shop_ID,
								month_in_year,
								ground + electricity + water AS total
				FROM COST) AS total_cost
		WHERE total_cost.shop_ID =@shop_id
END;
GO
ALTER AUTHORIZATION ON [dbo].[diff_btw_cost_each_month] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[diff_btw_cost_each_month] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[diff_btw_cost_each_month] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[diff_btw_cost_each_month] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[product_in_day]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Chưa: Quý--
CREATE PROCEDURE [dbo].[product_in_day]
				@day DATE
AS
	BEGIN
		-- Những sản phẩm được bán trong ngày--
		SELECT ORDER_LIST.order_id, 
				PRODUCTS.name_product,
				ORDER_PRODUCT.quantity 
		FROM ORDER_LIST 
		INNER JOIN ORDER_PRODUCT 
		ON ORDER_LIST.order_id = ORDER_PRODUCT.order_id 
		INNER JOIN PRODUCTS 
		ON PRODUCTS.product_id = ORDER_PRODUCT.product_id
		WHERE	ORDER_LIST.create_day= @day
		ORDER BY quantity DESC
	END
GO
ALTER AUTHORIZATION ON [dbo].[product_in_day] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[product_in_day] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[product_in_day] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[product_in_day] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[products_best_sell_in_shop]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Chưa : Hai--
CREATE PROCEDURE [dbo].[products_best_sell_in_shop]
								 @shop_id CHAR(8)
--In ra 5 sản phẩm bán chạy nhất của shop--
AS
BEGIN
			SELECT 	
				PRODUCTS.name_product,
				rank_product.so_luong
			FROM
				(SELECT TOP(5) 
					product_id,
					SUM(quantity) AS so_luong
				FROM
					(SELECT
						ORDER_LIST.order_id,
						ORDER_PRODUCT.product_id,
						ORDER_PRODUCT.quantity
					 FROM ORDER_LIST
					 INNER JOIN ORDER_PRODUCT
					 ON ORDER_LIST.order_id = ORDER_PRODUCT.order_id
					 WHERE shop_id = @shop_id) AS So_luong_san_pham_trong_shop
				GROUP BY So_luong_san_pham_trong_shop.product_id
				ORDER BY so_luong DESC) AS rank_product
			INNER JOIN PRODUCTS
			ON PRODUCTS.product_id =  rank_product.product_id
END;
GO
ALTER AUTHORIZATION ON [dbo].[products_best_sell_in_shop] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[products_best_sell_in_shop] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[products_best_sell_in_shop] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[products_best_sell_in_shop] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[ranking_of_product]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Viet roi--
CREATE PROCEDURE [dbo].[ranking_of_product] 
 AS
 BEGIN
		--Xếp hạng những sản phẩm nhiều nhất của hệ thống--
	SELECT 
			rank_product.product_id,
			PRODUCTS.name_product,
			rank_product.so_luong_ban_ra,
			rank_product.amount_rank
	FROM 
		(SELECT TOP 5
			product_id,
			SUM(quantity) AS so_luong_ban_ra,
			RANK() OVER (ORDER BY SUM(quantity) DESC) AS amount_rank
			FROM ORDER_PRODUCT
			GROUP BY product_id) AS rank_product
			INNER JOIN PRODUCTS
			ON rank_product.product_id = PRODUCTS.product_id
END
GO
ALTER AUTHORIZATION ON [dbo].[ranking_of_product] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[ranking_of_product] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[ranking_of_product] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[ranking_of_product] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[revenue_in_day]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Chưa:Quý--
CREATE PROCEDURE [dbo].[revenue_in_day]
				@day DATE
AS
	BEGIN
	--Tổng doanh thu trong ngày của các chi nhánh-
		SELECT create_day,
					SUM(PAYMENT.payment_amount) AS "Tong thu nhap trong ngay" 
		FROM ORDER_LIST
		INNER JOIN PAYMENT 
		ON ORDER_LIST.order_id = PAYMENT.order_id 
		WHERE ORDER_LIST.create_day= @day
		GROUP BY create_day
	END
GO
ALTER AUTHORIZATION ON [dbo].[revenue_in_day] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[revenue_in_day] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[revenue_in_day] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[revenue_in_day] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[shop_revenue]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[shop_revenue]
--Viet roi--
@month INT
	AS
	--Xem chi phí doanh thu và lợi nhuận của các cửa hàng--
	BEGIN
		SELECT COST.shop_id,
			 revenue.revenue,
 ground+electricity+water AS cost,
			 revenue.revenue - (ground+electricity+water) AS profit
		FROM COST 
		INNER JOIN (
				SELECT ORDER_LIST.shop_id, 
								SUM(PAYMENT.payment_amount) AS revenue
				FROM ORDER_LIST 
				INNER JOIN PAYMENT
				ON PAYMENT.order_id = ORDER_LIST.order_id
				WHERE MONTH(create_day) = @month
				GROUP BY shop_id) AS revenue
		ON revenue.shop_id = COST.shop_id
		WHERE month_in_year = @month
		ORDER BY profit DESC
	END;
GO
ALTER AUTHORIZATION ON [dbo].[shop_revenue] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[shop_revenue] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[shop_revenue] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[shop_revenue] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[update_employee]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_employee] 
	@emp_ID int,
	@emp_role CHAR(10)
	--Cập nhật chứ vụ cho nhân viên--
AS
	BEGIN
		UPDATE EMPLOYEE
		SET EMPLOYEE.emp_role = @emp_role
		WHERE EMPLOYEE.emp_ID = @emp_ID
	END
GO
ALTER AUTHORIZATION ON [dbo].[update_employee] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[update_employee] TO [QLTS_phongql] AS [dbo]
GO
GRANT TAKE OWNERSHIP ON [dbo].[update_employee] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[update_employee] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[update_payment]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_payment] 
	@payment_method NCHAR(20),
	@payment_status CHAR(10),
	@payment_amount REAL,
	@order_id INT
AS
--Cập nhật thanh toán cho đơn hàng--
	UPDATE PAYMENT
		SET 
			PAYMENT.payment_method=@payment_method,
			PAYMENT.payment_status =@payment_status, 
			PAYMENT.payment_amount=@payment_amount
		WHERE PAYMENT.order_id = @order_id
GO
ALTER AUTHORIZATION ON [dbo].[update_payment] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[update_payment] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[update_payment] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[update_payment] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[update_product]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_product] 
--Cập nhật thông tin sản phẩm--
	@product_id int,
	@cost real,
	@production_cost real
AS
	BEGIN
		UPDATE PRODUCTS
		SET PRODUCTS.COST = @cost, PRODUCTS.production_cost=@production_cost
		WHERE PRODUCTS.product_id = @product_id
	END
GO
ALTER AUTHORIZATION ON [dbo].[update_product] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[update_product] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[update_product] TO [QLTS_nhanvien] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[update_product] TO [QLTS_nhanvien] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[view_voucher_of_cus]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[view_voucher_of_cus]
@c_phone_number CHAR(11)
AS
BEGIN
	SELECT VOUCHER_ITEM.voucher_id FROM VOUCHER_ITEM 
	INNER JOIN VOUCHER ON VOUCHER_ITEM.voucher_id = VOUCHER.voucher_id
	WHERE (c_phone_number=@c_phone_number AND used = 'no') and end_day > GETDATE( )
END;
GO
ALTER AUTHORIZATION ON [dbo].[view_voucher_of_cus] TO  SCHEMA OWNER 
GO
GRANT CONTROL ON [dbo].[view_voucher_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[view_voucher_of_cus] TO [QLTS_phongql] AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[view_voucher_of_cus] TO [QLTS_phongql] AS [dbo]
GO
/****** Object:  Trigger [dbo].[Create_Payment_orderId]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Create_Payment_orderId]
ON [dbo].[ORDER_LIST]
AFTER  Insert
AS BEGIN 
DECLARE @order_id int

SELECT @order_id=order_id FROM inserted

	Insert into PAYMENT values ('TT',null,'N',0,@order_id)
  
END
GO
ALTER TABLE [dbo].[ORDER_LIST] ENABLE TRIGGER [Create_Payment_orderId]
GO
/****** Object:  Trigger [dbo].[UPDATE_PAYMENT_AMOUNT]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_PAYMENT_AMOUNT]
ON [dbo].[ORDER_PRODUCT]
WITH EXECUTE AS CALLER
AFTER INSERT, UPDATE, DELETE
AS
BEGIN 
DECLARE @order_id int
DECLARE @payment_amount real

-- lấy mã hóa đơn đang thao tác


SELECT order_id FROM inserted
UNION 
SELECT order_id FROM deleted

SELECT @order_id = order_id FROM ORDER_PRODUCT

-- tính tổng tiền theo hóa đơn đó

SELECT @payment_amount = SUM(ORDER_PRODUCT.price)
FROM ORDER_PRODUCT
WHERE order_id = @order_id

-- CẬP NHẬT CỘT TỔNG TIỀN Ở BẢN HÓA ĐƠN ỨNG VỚI HÓA ĐƠN ĐÓ
UPDATE PAYMENT	
SET payment_amount = @payment_amount 
WHERE PAYMENT.order_id =  @order_id 
END
GO
ALTER TABLE [dbo].[ORDER_PRODUCT] ENABLE TRIGGER [UPDATE_PAYMENT_AMOUNT]
GO
/****** Object:  Trigger [dbo].[AFTER_PAYMET_SET_TYPE_CUS]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery1.sql|7|0|C:\Users\DatIT\AppData\Local\Temp\~vs9A44.sql
CREATE TRIGGER [dbo].[AFTER_PAYMET_SET_TYPE_CUS]
ON [dbo].[PAYMENT]
WITH EXECUTE AS CALLER
AFTER UPDATE
AS
BEGIN
	DECLARE @Payment_status char(10);
	DECLARE @c_phone_cus  char(11);
	DECLARE @voucher_id CHAR(8)
	SELECT 
		@Payment_status = payment_status,
		@c_phone_cus = c_phone_number,
		@voucher_id = voucher_id
	FROM inserted INNER JOIN ORDER_LIST ON ORDER_LIST.order_id = inserted.order_id;
	If( @Payment_status = 'DONE')
	BEGIN 
		IF(@voucher_id IS NOT NULL)
		BEGIN
				PRINT 'THONG BAO';
				PRINT @c_phone_cus;
				PRINT @voucher_id;
				UPDATE VOUCHER_ITEM
				SET used = 'yes',Date_use = GETDATE()
				WHERE c_phone_number = @c_phone_cus AND voucher_id = @voucher_id
		END
		DECLARE @Sum1 REAL ;
		SELECT @Sum1 = SUM(PAYMENT.payment_amount)
		FROM PAYMENT INNER JOIN ORDER_LIST
		ON ORDER_LIST.order_id = PAYMENT.order_id
		WHERE ORDER_LIST.c_phone_number=@c_phone_cus;
		print @Sum1
		IF(@c_phone_cus <> '01')
		BEGIN
				IF(@Sum1 BETWEEN 500000 AND 1000000 )
				BEGIN 
					PRINT 'Thang cap khach hang dong '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='BRONZE' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 BETWEEN 1000001 AND 1500000 )
				BEGIN
					PRINT 'Thang cap khach hang bac '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='SILVER' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 > 2500000 )
				BEGIN 
					PRINT 'Thang cap khach hang vang '
					UPDATE CUSTOMER SET  CUSTOMER.type_cus='GOLD' WHERE CUSTOMER.c_phone_number = @c_phone_cus 
				END
				IF(@Sum1 <500000 )
				BEGIN 
					PRINT 'Khong du dieu kien '
				END
		END
	END

END;
GO
ALTER TABLE [dbo].[PAYMENT] ENABLE TRIGGER [AFTER_PAYMET_SET_TYPE_CUS]
GO
/****** Object:  Trigger [dbo].[ADD_VOUCHER]Script Date: 5/16/2022 5:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ADD_VOUCHER] ON [dbo].[VOUCHER] FOR INSERT,
			UPDATE AS BEGIN
				DECLARE
					@c_Phone CHAR ( 11 ),@Voucher_Type CHAR ( 10 ), @Voucher_id CHAR ( 8 );
				SELECT
					@Voucher_Type = voucher_constraint, @Voucher_id = voucher_id 
				FROM
					inserted;
				DECLARE
					voucher_cursor CURSOR FOR SELECT
					c_phone_number 
				FROM
					CUSTOMER 
				WHERE
					CUSTOMER.type_cus = @Voucher_Type;
				OPEN voucher_cursor FETCH NEXT 
				FROM
					voucher_cursor INTO @c_Phone
				WHILE
						@@FETCH_STATUS = 0 BEGIN
							INSERT INTO VOUCHER_ITEM
						VALUES
							( @Voucher_id,@c_Phone, 'no', NULL ) FETCH NEXT 
						FROM
							voucher_cursor INTO @c_Phone 
						END CLOSE voucher_cursor;
					DEALLOCATE voucher_cursor;
					
				END;
GO
ALTER TABLE [dbo].[VOUCHER] ENABLE TRIGGER [ADD_VOUCHER]
GO
