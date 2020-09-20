-- CREATE DATABASE CodeSharpener
-- USE CodeSharpener

DROP TABLE IF EXISTS Users;
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(40),
	LastName NVARCHAR(40),
	MiddleName NVARCHAR(40),
	Email NVARCHAR(80),
	Password NVARCHAR(40)
);

INSERT INTO Users(FirstName, LastName, MiddleName, Email, Password)
	VALUES('Richard', 'Lee', 'Minsoo', 'lee@gmail.com', 'password');

SELECT * FROM Users;

DROP TABLE IF EXISTS Content;
CREATE TABLE Content(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(40),
	Description NVARCHAR(400),
	ConceptLink NVARCHAR(120),
	WalkthruLink NVARCHAR(120),
	UserId INT FOREIGN KEY REFERENCES Users(Id)
);

INSERT INTO Content(Title, Description, ConceptLink, WalkthruLink, UserId)
	VALUES('Singly Linked List', 'SLL desciption', 'www.CodeSharpener.com/content/SLL/concept', 'www.CodeSharpener.com/content/SLL/walkthru', 1);

SELECT * FROM Content;

DROP TABLE IF EXISTS Challenge;
CREATE TABLE Challenge(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(40),
	Description NVARCHAR(400),
	ContentId INT FOREIGN KEY REFERENCES Content(Id)
);

INSERT INTO Challenge(Title, Description, ContentId)
	VALUES('Reverse Singly Linked List', 'Reverse SLL Challenge Desciption', 1);

SELECT * FROM Challenge;

DROP TABLE IF EXISTS Solution;
CREATE TABLE Solution(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(40),
	Description NVARCHAR(400),
	ChallengeId INT FOREIGN KEY REFERENCES Challenge(Id),
	UserId INT FOREIGN KEY REFERENCES Users(Id)
);

INSERT INTO Solution(Title, Description, ChallengeId, UserId)
	VALUES('Brute Force Method', 'O(n^2) not the most optimal solution', 1, 1);
SELECT * FROM Solution;