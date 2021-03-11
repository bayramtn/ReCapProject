CREATE TABLE Users
(
ID INT IDENTITY(1,1),
FirstName VARCHAR(50),
LastName VARCHAR(50),
Email VARCHAR(50),
Password  VARCHAR(50)
)

INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Ali','Kaya','alikaya@gmail.com','ali123')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Veli','Yilmaz','veliyilmaz@gmail.com','veli111')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Hale','Demir','haledemir@gmail.com','demir123')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Lale','Celik','lalecelik@hotmail.com','222lale')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Jale','Sahin','jalesahin@gmail.com','sahin1453')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Mert','Yildiz','mertyildiz@gmail.com','yidizzz')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Zeki','Yildirim','zekiyildirim@gmail.com','zeki000')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Metin','Ozturk','metinozturk@hotmail.com','mmetinn')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Ece','Aydin','eceaydin@gmail.com','ecece')
INSERT INTO Users (FirstName,LastName,Email,Password) VALUES ('Elif','Aslan','elifaslan@gmail.com','elif34')

--SELECT*FROM Users

CREATE TABLE Customers
(
Id INT IDENTITY(1,1),
UserId INT,
CompanyName  VARCHAR(50)
)

INSERT INTO Customers(UserId,CompanyName) VALUES (1,'KayaLtd')
INSERT INTO Customers(UserId,CompanyName) VALUES (4,'CelikAs')
INSERT INTO Customers(UserId,CompanyName) VALUES (5,'JaleCicekcilik')
INSERT INTO Customers(UserId,CompanyName) VALUES (7,'YildirimOtomotiv')
INSERT INTO Customers(UserId,CompanyName) VALUES (8,'MetinKurutemizleme')
INSERT INTO Customers(UserId,CompanyName) VALUES (9,'EceTurizm')

--SELECT*FROM Customers
select*
from Users U
left join Customers C  on
U.ID=c.UserId

CREATE TABLE Rentals
(
Id INT IDENTITY(1,1),
CarId INT,
CustomerId INT,
RentDate DATETIME,
ReturnDate DATETIME
)

INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (1,1,'20210110','20210201')
INSERT INTO Rentals(CarId,CustomerId,RentDate) VALUES (2,6,'20210306')
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (4,4,'20210101','20210215')
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (3,2,'20210110','20210112')
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (1,5,'20210205','20210225')
INSERT INTO Rentals(CarId,CustomerId,RentDate) VALUES (5,3,'20210310')
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (2,3,'20210228','20210301')
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES (5,5,'20210227','20210305')

--SELECT*FROM Rentals

select U.FirstName,U.LastName,U.Email,U.Password,
CU.CompanyName,R.RentDate,R.ReturnDate,
B.BrandName,CO.ColorName,
C.ModelYear,C.DailyPrice,C.Description
from Rentals R
join Customers CU on CU.Id=R.CustomerId
join Cars C on C.ID=r.CarId
join Users U on U.ID=CU.UserId
join Colors CO on CO.ColorId=C.ColorId
join Brands B on B.BrandId=C.BrandId
order by R.RentDate,R.ReturnDate

--DROP TABLE Users
--DROP TABLE Customers
--DROP TABLE Rentals