CREATE TABLE KindsOfBooks(
CodeKindBook bigint identity(1,1)primary key,
KindBook varchar(50) not null,
)

CREATE TABLE Genders(
CodeGender bigint identity(1,1)primary key,
KindGender varchar(50) not null,

)
CREATE TABLE StatusUser(
CodeStatus bigint identity(1,1)primary key,
KindStatus varchar(50) not null,
)

CREATE TABLE Users(
IdUser bigint primary key,
NameUser varchar(50) not null,
AgeUser int not null,
GenderCode bigint foreign key references Genders(CodeGender),
StatusCode bigint foreign key references StatusUser(CodeStatus),

)
CREATE TABLE KindsOfBooksForUsers(
CodeKindsOfBooksForUsers bigint identity(1,1)primary key,
UserId bigint foreign key references Users(IdUser),
KindBookCode bigint foreign key references KindsOfBooks(CodeKindBook),
)

CREATE TABLE Authors(
CodeAuthor bigint identity(1,1)primary key,
NameAuthor varchar(50) not null,
)

CREATE TABLE AuthorsForUsers(
CodeAuthorsForUsers bigint identity(1,1)primary key,
AuthorCode bigint foreign key references Authors(CodeAuthor),
UserId bigint  foreign key references Users(IdUser),
)

CREATE TABLE StatusForUsers(
CodeStatusForUsers bigint identity(1,1)primary key,
StatusCode bigint  foreign key references StatusUser(CodeStatus),
UserId bigint  foreign key references Users(IdUser),
)
CREATE TABLE Audiences(
CodeAudience bigint identity(1,1)primary key,
KindAudience varchar(50) not null,
Age int not null,


)

CREATE TABLE AudiencesForUsers(
CodeAudiencesForUsers bigint identity(1,1)primary key,
AudienceCode bigint  foreign key references Audiences(CodeAudience),
UserId bigint  foreign key references Users(IdUser),
)

CREATE TABLE ReadingBooks (
CodeBook bigint identity(1,1)primary key,
NameBook varchar(50) not null,
AuthorCode bigint  foreign key references Authors(CodeAuthor),
KindBookCode bigint foreign key references KindsOfBooks(CodeKindBook),
AudienceCode bigint foreign key references Audiences(CodeAudience),
StatusCode bigint  foreign key references StatusUser(CodeStatus),
GenderCode bigint  foreign key references Genders(CodeGender),
LengthBook int not null,
IsBorrowed bit,
)

CREATE TABLE ProfileBook(
CodeProfileBook bigint identity(1,1)primary key,
BookCode bigint  foreign key references ReadingBooks(CodeBook),
KindBook int default (0),
AudienceAge int default (0),
AudienceStatus int default (0),
AudienceGender int default (0),

)
CREATE TABLE BorrowedBooks(
CodeBorrowedBooks bigint identity(1,1)primary key,
BookCode bigint,
UserId bigint,
BorrowingDate date,
IsBorrowed bit,
FOREIGN KEY ([BookCode]) REFERENCES [dbo].[ReadingBooks] ([CodeBook]),
FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([IdUser]),
)


/*insert*/












