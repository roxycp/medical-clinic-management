CREATE TABLE Medici (
    Id           INT PRIMARY KEY IDENTITY,
    Nume         NVARCHAR(50) NOT NULL,
    Prenume      NVARCHAR(50) NOT NULL,
    Specialitate NVARCHAR(100) NOT NULL,
    Telefon      NVARCHAR(15),
    Email        NVARCHAR(100)
);

CREATE TABLE Pacienti (
    Id           INT PRIMARY KEY IDENTITY,
    Nume         NVARCHAR(50) NOT NULL,
    Prenume      NVARCHAR(50) NOT NULL,
    CNP          NVARCHAR(13) NOT NULL UNIQUE,
    DataNasterii DATE NOT NULL,
    Telefon      NVARCHAR(15),
    Email        NVARCHAR(100),
    Adresa       NVARCHAR(200)
);

CREATE TABLE Programari (
    Id              INT PRIMARY KEY IDENTITY,
    IdPacient       INT NOT NULL FOREIGN KEY REFERENCES Pacienti(Id),
    IdMedic         INT NOT NULL FOREIGN KEY REFERENCES Medici(Id),
    DataProgramarii DATETIME NOT NULL,
    Diagnostic      NVARCHAR(200),
    Observatii      NVARCHAR(500)
);

CREATE TABLE Retete (
    Id             INT PRIMARY KEY IDENTITY,
    IdProgramare   INT NOT NULL FOREIGN KEY REFERENCES Programari(Id),
    DataEliberarii DATE NOT NULL,
    Medicamente    NVARCHAR(500) NOT NULL,
    Observatii     NVARCHAR(500)
);