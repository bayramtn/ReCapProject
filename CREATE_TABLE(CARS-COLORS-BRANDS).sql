CREATE TABLE Cars
(
ID INT IDENTITY(1,1),
BrandId INT,
ColorId INT,
ModelYear INT,
DailyPrice INT,
Description VARCHAR(20)
)

INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (1,2,2000,300,'Family car')
INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (1,1,2010,400,'Classic car')
INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (2,2,2015,500,'Super car')
INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (2,3,2018,450,'Sports car')
INSERT INTO Cars (BrandId,ColorId,ModelYear,DailyPrice,Description) VALUES (3,3,2005,350,'Single door car')

--SELECT*FROM Cars

CREATE TABLE Colors
(
ColorId INT IDENTITY(1,1),
ColorName  VARCHAR(20)
)

INSERT INTO Colors(ColorName) VALUES ('BLUE')
INSERT INTO Colors(ColorName) VALUES ('BLACK')
INSERT INTO Colors(ColorName) VALUES ('RED')

--SELECT*FROM Colors

CREATE TABLE Brands
(
BrandId INT IDENTITY(1,1),
BrandName  VARCHAR(20)
)

INSERT INTO Brands(BrandName) VALUES ('FORD')
INSERT INTO Brands(BrandName) VALUES ('FERRARI')
INSERT INTO Brands(BrandName) VALUES ('MAZDA')

SELECT
Cars.ID,Brands.BrandName,Colors.ColorName,
Cars.ModelYear,Cars.DailyPrice,Cars.Description
FROM 
Cars
JOIN Colors ON
Colors.ColorId =Cars.ColorId 
JOIN Brands ON
Brands.BrandId=Cars.BrandId

--DROP TABLE Cars
--DROP TABLE Colors
--DROP TABLE Brands