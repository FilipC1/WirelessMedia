

CREATE TABLE Proizvod(
	ProizvodId int IDENTITY(1,1) PRIMARY KEY,
	Naziv nvarchar(100) NULL,
	Opis nvarchar(100) NULL,
	Kategorija nvarchar(100) NULL,
	Proizvodjac nvarchar(100) NULL,
	Dobavljac nvarchar(100) NULL,
	Cena decimal(10, 2) NOT NULL
);

INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(22275.00 AS Decimal(10, 2)),  'PVC prozori i vrata', 'Trocal Germany', 'Rollplast SRB', 'Trocal New 70mm 140x140', 'Dvokrilni prozor Trocal 70mm dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(33348.95 AS Decimal(10, 2)),  'PVC prozori i vrata', 'Trocal Germany', 'Rollplast SRB', 'Trocal New AD 76mm 140x140','Dvokrilni prozor Trocal 76mm dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(38459.50 AS Decimal(10, 2)),  'PVC prozori i vrata', 'Trocal Germany', 'Rollplast SRB', 'Trocal 88 New 140x140',  'Dvokrilni prozor Trocal 88 NEW dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(30234.95 AS Decimal(10, 2)),  'PVC prozori i vrata', 'Trocal Germany', 'Rollplast SRB', 'Trocal New 70mm ulazna vrata 100x200', 'Jednokrilna ulazna vrata Trokal 70mm dimenzija 100x200')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(14795.00 AS Decimal(10, 2)),  'ALU prozori i vrata', 'Etem Greece', 'Rollplast SRB', 'Etem E-1000 140x140', 'Dvokrilni prozor hladni aluminijum dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(26687.00 AS Decimal(10, 2)),  'ALU prozori i vrata', 'Etem Greece', 'Rollplast SRB', 'Etem E-45 140x140', 'Dvokrilni prozor termo aluminijum dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(29934.95 AS Decimal(10, 2)),  'ALU prozori i vrata', 'ALUMIL Greece', 'Rollplast SRB', 'Alumil E-700 140x140', 'Dvokrilni prozor ALUMIL termo aluminijum dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(28867.00 AS Decimal(10, 2)),  'ALU prozori i vrata', 'Etem Greece', 'Rollplast SRB', 'Etem E-1000 ulazna vrata 100x200',  'Jednokrilna ulazna vrata ETEM e-1000 dimenzija 100x200')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(12045.00 AS Decimal(10, 2)),  'ALU i PVC roletne', 'Trocal Germany', 'Rollplast SRB', 'AL Mini roletne 140x140', 'Spoljasnja ALU roletna dimenzija 140x140')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(19034.95 AS Decimal(10, 2)),  'ALU i PVC roletne', 'Trocal Germany', 'Rollplast SRB', 'AL RELAX roletna 140x160', 'Unutrasnja ALU roletna dimenzija 140x160')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(18267.00 AS Decimal(10, 2)),  'ALU i PVC roletne', 'Trocal Germany', 'Rollplast SRB', 'PVC RELAX roletna 140x160', 'Unutrasnja PVC roletna dimenzija 140x160')
INSERT INTO Proizvod (Cena, Kategorija, Proizvodjac, Dobavljac, Naziv, Opis) VALUES (CAST(17545.00 AS Decimal(10, 2)),  'ALU i PVC roletne', 'Trocal Germany', 'Rollplast SRB', 'PVC PRIMA roletna 140x140', 'Spoljasnja PVC roletna dimenzija 140x140')