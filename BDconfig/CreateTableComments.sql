CREATE TABLE Comments
(
	[CommentId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CommentUser] NVARCHAR(2500) NOT NULL,
	[RecordId] INT NOT NULL,
	[UserId]INT NOT NULL	
)
