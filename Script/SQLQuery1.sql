CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[LastName] NVARCHAR(512) NOT NULL,
	[FirstName] NVARCHAR(512) NOT NULL,
	[MiddleName] NVARCHAR(512) NOT NULL,
	[PaymentTypeId] INT NOT NULL,
	[PaymentSum] INT NOT NULL
);

CREATE TABLE [dbo].[PaymentType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(512) NOT NULL
);

ALTER TABLE Employees
ADD CONSTRAINT FK_Employee_PaymentType
FOREIGN KEY (PaymentTypeId) REFERENCES PaymentType(Id);

insert into [dbo].[PaymentType] ([Name]) values (N'Почасовая');
insert into [dbo].[PaymentType] ([Name]) values (N'Дневная');
insert into [dbo].[PaymentType] ([Name]) values (N'Месячная');

insert into [dbo].[Employees] ([LastName], [FirstName], [MiddleName], [PaymentTypeId], [PaymentSum])
values (N'Иванов', N'Иван', N'Иванович', 1, 15);
insert into [dbo].[Employees] ([LastName], [FirstName], [MiddleName], [PaymentTypeId], [PaymentSum])
values (N'Сумкин', N'Константин', N'Сергеевич', 2, 50);
insert into [dbo].[Employees] ([LastName], [FirstName], [MiddleName], [PaymentTypeId], [PaymentSum])
values (N'Путин', N'Владимир', N'Владимирович', 3, 800);