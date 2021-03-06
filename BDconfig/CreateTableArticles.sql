CREATE TABLE Articles
(
	[ArticleId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[ArticleTxt] NVARCHAR(MAX) NOT NULL,
	[Img1] NVARCHAR(250) NOT NULL,
	[Img2] NVARCHAR(250) NULL,
	[Data] NVARCHAR(25) NOT NULL,
	[Author] NVARCHAR(100) NOT NULL,
)