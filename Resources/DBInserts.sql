USE [CampaignDb]
GO
SET IDENTITY_INSERT [dbo].[Campaigns] ON 
GO
INSERT [dbo].[Campaigns] ([Id], [Template], [SendingTime], [Priority]) VALUES (1, N'TemplateA', CAST(N'10:15:00' AS Time), 1)
GO
INSERT [dbo].[Campaigns] ([Id], [Template], [SendingTime], [Priority]) VALUES (2, N'TemplateB', CAST(N'10:05:00' AS Time), 2)
GO
INSERT [dbo].[Campaigns] ([Id], [Template], [SendingTime], [Priority]) VALUES (3, N'TemplateC', CAST(N'10:10:00' AS Time), 5)
GO
INSERT [dbo].[Campaigns] ([Id], [Template], [SendingTime], [Priority]) VALUES (4, N'TemplateA', CAST(N'10:15:00' AS Time), 3)
GO
INSERT [dbo].[Campaigns] ([Id], [Template], [SendingTime], [Priority]) VALUES (5, N'TemplateC', CAST(N'10:05:00' AS Time), 4)
GO
SET IDENTITY_INSERT [dbo].[Campaigns] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerCriterias] ON 
GO
INSERT [dbo].[CustomerCriterias] ([Id], [AgeAbove], [AgeBelow], [Gender], [City], [DepositAbove], [DepositBelow], [IsANewCustomer], [CampaignId]) VALUES (1, NULL, NULL, N'Male', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[CustomerCriterias] ([Id], [AgeAbove], [AgeBelow], [Gender], [City], [DepositAbove], [DepositBelow], [IsANewCustomer], [CampaignId]) VALUES (3, NULL, NULL, NULL, N'New York', NULL, NULL, NULL, 3)
GO
INSERT [dbo].[CustomerCriterias] ([Id], [AgeAbove], [AgeBelow], [Gender], [City], [DepositAbove], [DepositBelow], [IsANewCustomer], [CampaignId]) VALUES (4, 45, NULL, NULL, NULL, NULL, NULL, NULL, 2)
GO
INSERT [dbo].[CustomerCriterias] ([Id], [AgeAbove], [AgeBelow], [Gender], [City], [DepositAbove], [DepositBelow], [IsANewCustomer], [CampaignId]) VALUES (5, NULL, NULL, NULL, NULL, 100, NULL, NULL, 4)
GO
INSERT [dbo].[CustomerCriterias] ([Id], [AgeAbove], [AgeBelow], [Gender], [City], [DepositAbove], [DepositBelow], [IsANewCustomer], [CampaignId]) VALUES (6, NULL, NULL, NULL, NULL, NULL, NULL, 1, 5)
GO
SET IDENTITY_INSERT [dbo].[CustomerCriterias] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (1, 44, N'Female', N'New York', 209, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (2, 36, N'Male', N'New York', 208, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (3, 87, N'Female', N'London', 134, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (4, 54, N'Male', N'Paris', 123, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (5, 45, N'Female', N'New York', 210, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (6, 49, N'Female', N'Tel-Aviv', 174, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (7, 35, N'Male', N'Paris', 52, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (8, 61, N'Male', N'Tel-Aviv', 151, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (9, 78, N'Male', N'Paris', 57, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (10, 41, N'Female', N'New York', 131, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (11, 32, N'Female', N'Tel-Aviv', 154, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (12, 62, N'Female', N'Paris', 135, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (13, 67, N'Male', N'Tel-Aviv', 153, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (14, 68, N'Female', N'London', 241, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (15, 41, N'Male', N'London', 134, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (16, 46, N'Female', N'London', 212, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (17, 77, N'Female', N'Tel-Aviv', 97, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (18, 51, N'Male', N'London', 141, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (19, 80, N'Male', N'Paris', 189, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (20, 31, N'Female', N'Tel-Aviv', 134, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (21, 80, N'Female', N'Tel-Aviv', 81, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (22, 36, N'Female', N'London', 237, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (23, 65, N'Female', N'Tel-Aviv', 119, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (24, 72, N'Male', N'Tel-Aviv', 139, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (25, 64, N'Male', N'Tel-Aviv', 128, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (26, 29, N'Male', N'London', 76, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (27, 25, N'Male', N'London', 203, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (28, 77, N'Male', N'New York', 54, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (29, 79, N'Female', N'Paris', 165, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (30, 26, N'Female', N'Paris', 143, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (31, 74, N'Female', N'London', 61, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (32, 74, N'Male', N'New York', 103, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (33, 46, N'Female', N'New York', 121, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (34, 47, N'Female', N'New York', 214, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (35, 78, N'Female', N'New York', 111, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (36, 46, N'Female', N'New York', 223, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (37, 26, N'Female', N'New York', 78, 1, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (38, 49, N'Female', N'Tel-Aviv', 60, 0, 1)
GO
INSERT [dbo].[Customers] ([Id], [Age], [Gender], [City], [Deposit], [IsANewCustomer], [CampaignReceivedToday]) VALUES (39, 74, N'Female', N'New York', 53, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
