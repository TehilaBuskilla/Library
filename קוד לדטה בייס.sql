CREATE TABLE KindsOfBooks(
CodeKindBook int identity(1,1)primary key,
KindBook varchar(50) not null,
)

CREATE TABLE Genders(
CodeGender int identity(1,1)primary key,
KindGender varchar(50) not null,

)
CREATE TABLE StatusUser(
CodeStatus int identity(1,1)primary key,
KindStatus varchar(50) not null,
)

CREATE TABLE Users(
IdUser int primary key,
NameUser varchar(50) not null,
AgeUser int not null,
GenderCode int foreign key references Genders(CodeGender),
StatusCode int foreign key references StatusUser(CodeStatus),

)
CREATE TABLE KindsOfBooksForUsers(
CodeKindsOfBooksForUsers int identity(1,1)primary key,
UserId int foreign key references Users(IdUser),
KindBookCode int foreign key references KindsOfBooks(CodeKindBook),
)

CREATE TABLE Authors(
CodeAuthor int identity(1,1)primary key,
NameAuthor varchar(50) not null,
)

CREATE TABLE AuthorsForUsers(
CodeAuthorsForUsers int identity(1,1)primary key,
AuthorCode int foreign key references Authors(CodeAuthor),
UserId int  foreign key references Users(IdUser),
)

CREATE TABLE StatusForUsers(
CodeStatusForUsers int identity(1,1)primary key,
StatusCode int  foreign key references StatusUser(CodeStatus),
UserId int  foreign key references Users(IdUser),
)
CREATE TABLE Audiences(
CodeAudience int identity(1,1)primary key,
KindAudience varchar(50) not null,
Age int not null,


)

CREATE TABLE AudiencesForUsers(
CodeAudiencesForUsers int identity(1,1)primary key,
AudienceCode int  foreign key references Audiences(CodeAudience),
UserId int  foreign key references Users(IdUser),
)

CREATE TABLE ReadingBooks (
CodeBook int identity(1,1)primary key,
NameBook varchar(50) not null,
AuthorCode int  foreign key references Authors(CodeAuthor),
KindBookCode int foreign key references KindsOfBooks(CodeKindBook),
AudienceCode int foreign key references Audiences(CodeAudience),
StatusCode int  foreign key references StatusUser(CodeStatus),
GenderCode int  foreign key references Genders(CodeGender),
LengthBook int not null,
IsBorrowed bit,
)

CREATE TABLE ProfileBook(
CodeProfileBook int identity(1,1)primary key,
BookCode int  foreign key references ReadingBooks(CodeBook),
KindBook int default (0),
AudienceAge int default (0),
AudienceStatus int default (0),
AudienceGender int default (0),

)
CREATE TABLE BorrowedBooks(
CodeBorrowedBooks int identity(1,1)primary key,
BookCode int,
UserId int,
BorrowingDate date,
IsBorrowed bit,
FOREIGN KEY ([BookCode]) REFERENCES [dbo].[ReadingBooks] ([CodeBook]),
FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([IdUser]),
)


/*insert*/












