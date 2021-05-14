--drop table Contacts2

CREATE TABLE [dbo].[Contacts2]
(
	[ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[FirstName] NVARCHAR(255) NOT NULL DEFAULT '', 
    [LastName] NVARCHAR(255) NOT NULL DEFAULT ''
)

insert into contacts2
(FirstName, LastName)
values
('John','Doe')

insert into contacts2
(FirstName, LastName)
values
('Jane','Doe'),
('John','Smith')

Select * from contacts2

Select * from contacts2 where FirstName = 'Jane'

Select * from contacts2 where FirstName like 'Jo%'

Select * from contacts2 where FirstName like '%o%'

drop table Contacts2