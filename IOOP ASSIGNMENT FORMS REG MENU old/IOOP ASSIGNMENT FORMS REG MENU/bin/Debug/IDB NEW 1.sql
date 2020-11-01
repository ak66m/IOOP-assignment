USE [IOOP assignment]
GO
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A00001', N'Hakeem', N'Hassan', N'APU, technology park Jeddah', N'ak66m123', N'1234567 ', N'male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A00002', N'Ali', N'Khan', N'APU, technology park Malaysia', N'ali123', N'12345678', N'male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0003 ', N'asdasd', N'asdasd', N'adas', N'asda', N'asdasd  ', N'Male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0004 ', N'Anas', N'Bahurmoz', N'APU', N'Anas', N'123     ', N'Male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0005 ', N'MMK', N'MMK', N'Park', N'MMK', N'123     ', N'Male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0006 ', N'Test', N'Test', N'Test', N'Test', N'123     ', N'Female    ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0007 ', N'Test2', N'Test2', N'Test8', N'Test2', N'12345   ', N'Female    ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0008 ', N'Test3', N'Test3', N'Test3', N'Test3', N'123     ', N'Male      ')
INSERT [dbo].[REGESTERATION_T] ([app_id], [app_firstname], [app_lastname], [app_address], [app_username], [app_password], [app_gender]) VALUES (N'A0009 ', N'Test', N'Test', N'Test', N'Test4', N'123     ', N'Male      ')
GO

create table PAYMENT
(app_id char(6) NOT NULL, payment_method varchar(10) NOT NULL, type_of_insurance varchar(50) NOT NULL, date_start date NOT NULL, date_end date , 
total numeric(8,2)NOT NULL)

insert into PAYMENT (app_id, payment_method, type_of_insurance ,date_start,date_end,total) values ('A0003','card','third party','10/30/2020','10/30/2020','2000')


SELECT app_address from REGESTERATION_T where app_id = 'A0004' 

SELECT date_start from Payment where app_id = 'A0004'


insert into PAYMENT (app_id ) values ('A1254')

ALTER TABLE PAYMENT
ADD CONSTRAINT FK_app_id
     FOREIGN KEY (app_id)
	 REFERENCES REGESTERATION_T (app_id)



