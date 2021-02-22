CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(50),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID)
)
CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)
CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)
INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','2','2017','300','Yaris'),
	('1','3','2015','250','Auris'),
	('2','1','2017','200','Corsa'),
	('3','3','2016','175','Civic');
	

	INSERT INTO Colors(ColorName)
VALUES
	('Beyaz'),
	('Gri'),
	('Mavi');
	INSERT INTO Brands(BrandName)
VALUES
	('Toyota'),
	('Opel'),
	('Honda');

	CREATE TABLE Users(
	UserId int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	UserEmail nvarchar(50),
	UserPassword nvarchar(50)
	)
	CREATE TABLE Customers(
	CustomerId int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(50),
	FOREIGN KEY (UserId)  REFERENCES Users(UserId)
	)
	CREATE TABLE Rentals(
	RentalId int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
	)
	INSERT INTO Users(FirstName,MiddleName,LastName,UserEmail,UserPassword)
VALUES
	('Engin','Aydoğdu','ea@gmail.com','123456'),
	('Selen','','ck@gmail.com','123456'),
	('','Karabel','cvk@gmail.com','123456');

INSERT INTO Customers(UserID,CompanyName)
VALUES
	('1','Selin K.'),
	('2','TheKarabels'),
	('3','WL German Shepherd');

