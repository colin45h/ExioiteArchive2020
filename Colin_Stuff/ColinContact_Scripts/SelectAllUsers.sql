/*
drop table Users

CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(255) NOT NULL DEFAULT '', 
    [Password] NVARCHAR(255) NOT NULL DEFAULT '', 
    [FirstName] NVARCHAR(255) NOT NULL DEFAULT '', 
    [LastName] NVARCHAR(255) NOT NULL DEFAULT ''
)
*/

--TRUNCATE table users

select * from Users

Select * from Contacts