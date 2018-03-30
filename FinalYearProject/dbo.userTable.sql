CREATE TABLE [dbo].[Table]
(
	[userID] INT NOT NULL PRIMARY KEY, 
    [username] NCHAR(10) NOT NULL, 
    [password] NCHAR(10) NOT NULL, 
    [group] NVARCHAR(50) NOT NULL
)
