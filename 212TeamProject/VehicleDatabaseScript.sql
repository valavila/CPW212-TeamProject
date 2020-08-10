/*
This is the script for the Automoblie site
Name: John Uthus
Date: 7/24/2020
*/

USE master
GO

DROP DATABASE IF EXISTS GroupProject
GO

CREATE DATABASE GroupProject
GO

USE GroupProject
GO

-- drops table if exits
DROP TABLE IF EXISTS Vehicles
GO

-- you would not belive how long those makes and models get
CREATE TABLE Vehicles
(
	-- colName		dataType		Attributes
	VehicleId			int			PRIMARY KEY IDENTITY,
	VehicleIdNum	char(17)		NOT NULL,
	PlateNum		varchar(8)		NOT NULL,
	Make			varchar(40)		NOT NULL,
	Model			varchar(70)		NOT NULL,
	Year			int			NOT NULL,
	Color			varchar(30)		NOT NULL,
)
GO

INSERT INTO Vehicles(VehicleIdNum, PlateNum, Make, Model, Year, Color)
VALUES	('5UXFE83507LZ40758', '722 ALG' ,'BMW', 'X5', 2007, 'Red'),
		('1J8FT47W67D346374', '565 MKB' ,'JEEP', 'Compass', 2007, 'Red'),
		('5YJSA1E12HF198784', '373 NHP' ,'TESLA', 'Model S', 2017, 'Orange'),
		('3VWTDAAT6KM500015', '166 ARS' ,'VOLKSWAGEN', 'Beetle', 2019, 'Green'),
		('WDDPK6GA0HF126853', '758 NFG' ,'MERCEDES-BENZ', 'SLC 43', 2017, 'Silver'),
		('JACCH55LXG7801475', '923 AKR' ,'ISUZU', 'TROOPER', 1986, 'Blue'),
		('19XFA15509E023669', '720 QWE' ,'HONDA', 'Civic', 2009, 'Silver'),
		('19XFA15309E024724', '928 UPI' ,'HONDA', 'Civic', 2009, 'Blue')
		