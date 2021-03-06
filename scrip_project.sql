USE [Webshop]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](30) NOT NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK__Categori__19093A2B592429AB] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[ContactName] [nvarchar](30) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](12) NOT NULL,
	[Username] [varchar](20) NULL,
	[Password] [varchar](30) NULL,
	[image] [nvarchar](100) NULL,
	[Role] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK__Customer__A4AE64B891B36497] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ShipperID] [int] NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[totalmoney] [int] NULL,
 CONSTRAINT [PK__Orders__C3905BAF56E3235E] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders Details]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders Details](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [int] NOT NULL,
 CONSTRAINT [PK__Orders D__08D097C1AB635983] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[UnitPrice] [int] NOT NULL,
	[UnitsInStock] [int] NULL,
	[UnitsOnOrder] [int] NULL,
	[CategoryID] [int] NOT NULL,
	[image] [nvarchar](100) NULL,
	[description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role Account]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role Account](
	[Role] [int] NOT NULL,
	[Rolename] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] NOT NULL,
	[CompanyName] [nvarchar](30) NOT NULL,
	[Phone] [nvarchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViewProduct]    Script Date: 24/03/2022 9:58:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViewProduct](
	[ProductID] [int] NULL,
	[view] [int] NULL,
	[viewdate] [date] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (1, N'JORDAN', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (2, N'NIKE', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (3, N'ADIDAS', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (4, N'CONVERSE', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (5, N'VANS', NULL)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [Description]) VALUES (13, N'test', N'')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (1, N'Admin', N'Hà Nội 2', N'0987654321', N'admin', N'123', N'', 1, 1)
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (2, N'Nguyễn Đức Cường', N'Quảng Ninh', N'0987654321', N'user2', N'123', N'images/user_2.png', 2, 1)
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (3, N'saitama', N'Z city', N'0987654321', N'user3', N'123', N'images/user_3.png', 2, 1)
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (4, N'Đăng Văn Lâm', N'Russia', N'0987654321', N'user4', N'123', N'', 2, 1)
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (5, N'Đỗ Hùng Dũng', N'Hà Nội', N'0987654321', N'user5', N'123', N'', 2, 1)
INSERT [dbo].[Customers] ([CustomerID], [ContactName], [Address], [Phone], [Username], [Password], [image], [Role], [status]) VALUES (6, N'Nguyen Huu Thanh', N'u city', N'0987654321', N'user6', N'123', N'', 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (4, 2, NULL, CAST(N'2021-01-13T00:00:00.000' AS DateTime), NULL, NULL, 1696000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (5, 2, NULL, CAST(N'2021-02-13T00:00:00.000' AS DateTime), NULL, NULL, 2842000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (6, 4, NULL, CAST(N'2022-01-14T00:00:00.000' AS DateTime), NULL, NULL, 1696000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (7, 4, NULL, CAST(N'2022-02-14T00:00:00.000' AS DateTime), NULL, NULL, 5038000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (8, 3, NULL, CAST(N'2022-03-14T00:00:00.000' AS DateTime), NULL, NULL, 2088000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (9, 5, NULL, CAST(N'2022-03-14T00:00:00.000' AS DateTime), NULL, NULL, 1838000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (10, 3, NULL, CAST(N'2022-03-14T00:00:00.000' AS DateTime), NULL, NULL, 2388000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (12, 4, NULL, CAST(N'2022-03-14T20:35:14.590' AS DateTime), NULL, NULL, 1396000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (13, 2, NULL, CAST(N'2022-03-15T11:26:10.510' AS DateTime), NULL, NULL, 2288000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (14, 6, NULL, CAST(N'2022-03-15T18:03:56.580' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (15, 5, NULL, CAST(N'2022-03-15T22:50:36.150' AS DateTime), NULL, NULL, 2488000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (18, 5, NULL, CAST(N'2022-03-16T20:19:49.490' AS DateTime), NULL, NULL, 648000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (20, 5, NULL, CAST(N'2022-03-16T20:35:33.233' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (21, 5, NULL, CAST(N'2022-03-16T20:39:51.643' AS DateTime), NULL, NULL, 1190000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (24, 5, NULL, CAST(N'2022-03-16T20:40:30.187' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (36, 5, NULL, CAST(N'2022-03-16T20:51:18.570' AS DateTime), NULL, NULL, 1894000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (37, 5, NULL, CAST(N'2022-03-16T21:21:55.990' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (38, 4, NULL, CAST(N'2022-03-16T23:52:32.290' AS DateTime), NULL, NULL, 898000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (39, 4, NULL, CAST(N'2022-03-16T23:53:27.470' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (40, 2, NULL, CAST(N'2022-03-17T11:32:39.810' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (41, 5, NULL, CAST(N'2022-03-17T11:34:03.807' AS DateTime), NULL, NULL, 798000)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ShipperID], [OrderDate], [RequiredDate], [ShippedDate], [totalmoney]) VALUES (42, 3, NULL, CAST(N'2022-03-20T14:44:49.350' AS DateTime), NULL, NULL, 1696000)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (4, 19, 2, 848000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (5, 4, 2, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (5, 7, 1, 598000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (5, 8, 1, 648000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (6, 10, 1, 848000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (6, 19, 1, 848000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (7, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (7, 19, 5, 848000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (8, 6, 1, 1190000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (8, 12, 1, 898000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (9, 5, 1, 1190000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (9, 8, 1, 648000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (10, 3, 1, 1490000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (10, 16, 1, 898000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (12, 7, 1, 598000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (12, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (13, 3, 1, 1490000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (13, 17, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (14, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (15, 1, 1, 1690000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (15, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (18, 8, 1, 648000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (20, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (21, 2, 1, 1190000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (24, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (36, 7, 1, 598000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (36, 8, 2, 648000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (37, 18, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (38, 16, 1, 898000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (39, 4, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (40, 17, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (41, 17, 1, 798000)
INSERT [dbo].[Orders Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (42, 9, 2, 848000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (1, N'Nike Air Jordan 6 Retro', 1690000, 24, 0, 1, N'images/Jordan_6_Retro.jpg', N'Giày Nike Air Jordan 6 Retro Travis Scott British Khaki')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (2, N'Nike Air Jordan 1 Retro', 1190000, 29, 0, 1, N'images/Jordan_1_Retro.jpg', N'Giày Nike Air Jordan 1 Retro High Black White')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (3, N'Nike Kwondo1', 1490000, 13, 0, 2, N'images/Nike_Kwondo.jpg', N'Nike Kwondo1 x Peaceminusone G-Dragon')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (4, N'Nike Air Force 1', 798000, 20, 0, 2, N'images/nike_air_force_1.jpg', N'Nike Air Force 1 07 Lv8 Utility')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (5, N'Adidas Yeezy Boost 350', 1190000, 15, 0, 3, N'images/yeezy_boost.jpg', N'Giày Adidas Yeezy Boost 350 V2 Desert Sage')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (6, N'Adidas Ultra Boost', 1190000, 23, 0, 3, N'images/ADIDAS_ULTRA_BOOST.jpg', N'Giày Adidas Ultra Boost 2020 Triple Black')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (7, N'Converse Chuck Taylor 1970s Đen', 598000, 27, 0, 4, N'images/converse_1970s.jpg', N'Converse Chuck Taylor 1970s Đen Cổ Cao')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (8, N'Converse Chuck Taylor 1970s Kem', 648000, 35, 0, 4, N'images/converse_1970s_cream.jpg', N'Converse Chuck Taylor 1970s Kem Thấp Cổ')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (9, N'Vans Vault Checkerboard', 848000, 37, 0, 5, N'images/vans_vault.jpg', N'Vans Vault Checkerboard Slip On 2021')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (10, N'Vans Vault Old Skool', 848000, 32, 0, 5, N'images/vans_vault_2021.jpg', N'Vans Vault Old Skool Black 2021')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (11, N'Giày Nike Air Jordan 1 Mid Chicago', 1190000, 27, 0, 2, N'images/Giay-Nike-Air-Jordan-1-Mid-Chicago.jpg', N'Giày Nike Air Jordan 1 Mid Chicago ‘White Toe’')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (12, N'Adidas Alphabounce', 898000, 25, 0, 3, N'images/Giay-Adidas-Alphabounce-Instinct-M-cam-xanh.jpg1_-800x600.jpg', N'Giày Adidas Alphabounce Instinct M cam xanh')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (14, N'Nike Air Max 97', 898000, 50, 0, 2, N'images/Nike-Air-Max-97-MSCHF-x-INRI-Jesus-replica-800x600.jpg', N'Giày Nike Air Max 97 MSCHF x INRI Jesus')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (15, N'Nike Air Max 97', 798000, 18, 0, 2, N'images/nike-air-max-97-sean-wotherspead-replica-800x600.jpg', N'Giày Nike Air Max 97 sean wotherspoon')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (16, N'Nike Blazer Low Paisley', 898000, 27, 0, 2, N'images/Nike-Blazer-Low-Paisley-Swoosh-800x600.jpg', N'Nike Blazer Low Paisley Swoosh')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (17, N'Nike Blazer Low 77 Vintage', 798000, 17, 0, 2, N'images/Nike-Blazer-Low-77-Vintage-White-Black-800x600.jpg', N'Nike Blazer Low 77 Vintage White Black')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (18, N'Nike Blazer Mid 77 Vintage', 798000, 43, 0, 2, N'images/Nike-Blazer-Mid-77-Vintage-White-Black-800x600.jpg', N'Nike Blazer Mid 77 Vintage White Black')
INSERT [dbo].[Products] ([ProductID], [ProductName], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [CategoryID], [image], [description]) VALUES (19, N'Nike Air Zoom Pegasus 35', 848000, 18, 0, 2, N'images/Nike-Air-Zoom-Pegasus-35-xanh-duong-replica-7-800x600.jpg', N'Giày Nike Air Zoom Pegasus 35 xanh dương')
GO
INSERT [dbo].[Role Account] ([Role], [Rolename]) VALUES (1, N'admin')
INSERT [dbo].[Role Account] ([Role], [Rolename]) VALUES (2, N'user')
GO
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (1, 10, CAST(N'2022-03-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (1, 9, CAST(N'2022-02-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (1, 15, CAST(N'2022-02-21' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (1, 13, CAST(N'2022-01-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (2, 19, CAST(N'2022-03-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (2, 19, CAST(N'2022-02-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (2, 25, CAST(N'2022-02-21' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (2, 33, CAST(N'2022-01-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (3, 9, CAST(N'2022-03-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (3, 9, CAST(N'2022-02-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (3, 5, CAST(N'2022-02-21' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (3, 3, CAST(N'2022-01-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (4, 39, CAST(N'2022-03-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (4, 19, CAST(N'2022-02-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (4, 53, CAST(N'2022-02-21' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (4, 23, CAST(N'2022-01-20' AS Date))
INSERT [dbo].[ViewProduct] ([ProductID], [view], [viewdate]) VALUES (5, 39, CAST(N'2021-12-20' AS Date))
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role Account] ([Role])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Role]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__Customer__2D27B809] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__Customer__2D27B809]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__ShipperI__2E1BDC42] FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__ShipperI__2E1BDC42]
GO
ALTER TABLE [dbo].[Orders Details]  WITH CHECK ADD  CONSTRAINT [FK_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Orders Details] CHECK CONSTRAINT [FK_OrderID]
GO
ALTER TABLE [dbo].[Orders Details]  WITH CHECK ADD  CONSTRAINT [FK_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orders Details] CHECK CONSTRAINT [FK_ProductID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK__Products__Catego__2A4B4B5E] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK__Products__Catego__2A4B4B5E]
GO
ALTER TABLE [dbo].[ViewProduct]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
