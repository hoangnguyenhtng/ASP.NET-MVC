USE [QL_LINHKIENDIENTU_WEB]
GO
/****** Object:  Table [dbo].[accounts]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[phone] [varchar](11) NULL,
	[password] [varchar](500) NULL,
	[image] [nvarchar](500) NULL,
	[fullname] [nchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[status] [bit] NULL,
	[idrole] [int] NULL,
 CONSTRAINT [PK_accounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[category]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[alias] [varchar](100) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[orderdetails]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetails](
	[idorder] [int] NOT NULL,
	[idproduct] [int] NOT NULL,
	[price] [decimal](18, 0) NULL,
	[quantity] [int] NULL,
	[subtotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_orderdetails] PRIMARY KEY CLUSTERED 
(
	[idorder] ASC,
	[idproduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orders]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idaccount] [int] NULL,
	[createdate] [date] NULL,
	[email] [varchar](100) NULL,
	[fullname] [nvarchar](100) NULL,
	[address] [nvarchar](500) NULL,
	[phone] [varchar](11) NULL,
	[total] [decimal](18, 0) NULL,
	[note] [nvarchar](500) NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[products]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NULL,
	[alias] [varchar](200) NULL,
	[price] [decimal](18, 0) NULL,
	[quantity] [int] NULL,
	[promationprice] [decimal](18, 0) NULL,
	[description] [ntext] NULL,
	[image] [varchar](500) NULL,
	[newproduct] [bit] NULL,
	[idcategory] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[role]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[alias] [varchar](100) NOT NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[accounts] ON 

INSERT [dbo].[accounts] ([id], [username], [email], [phone], [password], [image], [fullname], [address], [status], [idrole]) VALUES (1, N'dongduy', N'dongduy1206@gmail.com', N'0376880903', N'827ccb0eea8a706c4c34a16891f84e7b', N'Assets/Client/img/logo.svg', N'Duong Dong                                                                                          ', N'TP.HCM', 1, 2)
INSERT [dbo].[accounts] ([id], [username], [email], [phone], [password], [image], [fullname], [address], [status], [idrole]) VALUES (2, N'admin', N'admin@gmail.com', N'0376880903', N'827ccb0eea8a706c4c34a16891f84e7b', N'Assets/Client/img/logo.svg', N'admin                                                                                               ', N'admin', 1, 1)
SET IDENTITY_INSERT [dbo].[accounts] OFF
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id], [name], [alias]) VALUES (1, N'Laptop', N'lap-top')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (2, N'Mainboard', N'main-board')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (3, N'CPU', N'cpu')
INSERT [dbo].[category] ([id], [name], [alias]) VALUES (4, N'RAM', N'ram')
SET IDENTITY_INSERT [dbo].[category] OFF
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (25, 3, CAST(8490 AS Decimal(18, 0)), 2, CAST(16980 AS Decimal(18, 0)))
INSERT [dbo].[orderdetails] ([idorder], [idproduct], [price], [quantity], [subtotal]) VALUES (25, 4, CAST(5500 AS Decimal(18, 0)), 2, CAST(11000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [idaccount], [createdate], [email], [fullname], [address], [phone], [total], [note]) VALUES (25, 1, CAST(N'2023-04-09' AS Date), N'dongduy0612@gmail.com', N'Duy Duong', N'My Tho city Phường Yên Hải Thị xã Quảng Yên Tỉnh Quảng Ninh', N'0376880903', CAST(27980 AS Decimal(18, 0)), N'da')
SET IDENTITY_INSERT [dbo].[orders] OFF
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (1, N'Asus Rog Strix G G512 Ial013t', N'Asus-Rog-Strix-G-G512-Ial013t', CAST(2199 AS Decimal(18, 0)), 1, CAST(2000 AS Decimal(18, 0)), N'<p>M&agrave;u x&aacute;m kim loại v&agrave; ấn tượng hơn khi kết hợp với những đường ph&acirc;y xước đẹp mắt.Thiết kế chiến lược n&agrave;y l&agrave; sự hợp t&aacute;c của Asus với Tập đo&agrave;n BMW Designworks cho ra đời d&atilde;i m&agrave;u 3D Flow Zone sống động</p>
', N'Assets/Client/img/imagelp1.jpg', NULL, 1)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (2, N'Asus H410m-e', N'Asus-H410me', CAST(1865 AS Decimal(18, 0)), 5, CAST(1000 AS Decimal(18, 0)), N'<p>Sẵn s&agrave;ng cho bộ vi xử l&yacute; Intel&reg; Core &trade; thế hệ thứ 10 mới nhất</p>
', N'Assets/Client/img/imagemb1.jpg', NULL, 1)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (3, N'AMD Ryzen 7 3700x', N'amd-ryzen-7-3700x', CAST(8490 AS Decimal(18, 0)), 98, CAST(0 AS Decimal(18, 0)), N'Một trong những mã CPU được nhiều người mong đợi nhất trong list cpu Ryezn 3000 Series', N'Assets/Client/img/imagecp1.jpg', 1, 3)
INSERT [dbo].[products] ([id], [name], [alias], [price], [quantity], [promationprice], [description], [image], [newproduct], [idcategory]) VALUES (4, N'Adata Value Value 4GB', N'adata-value-value-4gb', CAST(5500 AS Decimal(18, 0)), 98, CAST(0 AS Decimal(18, 0)), N'một trong những công ty đứng đầu trong ngành sản xuất, thiết kế bộ nhớ và ổ cứng kho dữ liệu trên thế giói được thành lập vào tháng 5 năm 2001', N'Assets/Client/img/imagera1.jpg', 1, 4)
SET IDENTITY_INSERT [dbo].[products] OFF
SET IDENTITY_INSERT [dbo].[role] ON 

INSERT [dbo].[role] ([id], [name], [alias]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[role] ([id], [name], [alias]) VALUES (2, N'user', N'user')
SET IDENTITY_INSERT [dbo].[role] OFF
ALTER TABLE [dbo].[accounts]  WITH CHECK ADD  CONSTRAINT [FK_accounts_role] FOREIGN KEY([idrole])
REFERENCES [dbo].[role] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[accounts] CHECK CONSTRAINT [FK_accounts_role]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [FK_orderdetails_orders] FOREIGN KEY([idorder])
REFERENCES [dbo].[orders] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [FK_orderdetails_orders]
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD  CONSTRAINT [FK_orderdetails_products] FOREIGN KEY([idproduct])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[orderdetails] CHECK CONSTRAINT [FK_orderdetails_products]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_accounts] FOREIGN KEY([idaccount])
REFERENCES [dbo].[accounts] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_accounts]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_category] FOREIGN KEY([idcategory])
REFERENCES [dbo].[category] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_category]
GO
/****** Object:  Trigger [dbo].[compute_money_order]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[compute_money_order] on [dbo].[orderdetails]
for insert
as
begin
	declare @idorder int,@idproduct int,@subtotal decimal(18,0)
	select @idorder = idorder,@idproduct=idproduct,@subtotal=price*quantity from inserted
	update orderdetails 
	set subtotal=@subtotal
	where idorder=@idorder and idproduct=@idproduct

	update [orders]
	set total=(select sum(price*quantity) from orderdetails where idorder=@idorder)
	where id=@idorder
end


GO
/****** Object:  Trigger [dbo].[update_quantity_products_orderdetail]    Script Date: 09/04/2023 09:14:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[update_quantity_products_orderdetail] on [dbo].[orderdetails]
for insert 
as
begin
	declare @idproduct int,@quantity int
	select @idproduct=idproduct,@quantity=quantity from inserted
	update products
	set quantity-=@quantity
	where id=@idproduct
end


GO
