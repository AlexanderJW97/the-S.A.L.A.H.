CREATE TABLE users
(
	[username] INT NOT NULL PRIMARY KEY, 
    [salt] NCHAR(10) NULL, 
    [encryptedpassword] NCHAR(10) NULL
)
