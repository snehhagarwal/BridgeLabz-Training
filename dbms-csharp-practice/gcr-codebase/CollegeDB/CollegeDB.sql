/* =========================================================
   DATABASE CREATION (DDL)

        -- CREATE DATABASE
           CREATE DATABASE database_name;

        -- USE DATABASE
           USE database_name;
  ========================================================= */

CREATE DATABASE UniversityDB;
GO

USE UniversityDB;
GO


/* =========================================================
   DROP TABLE (DDL)

        -- DROP TABLE
           DROP TABLE table_name;

        -- DROP TABLE IF EXISTS
           DROP TABLE IF EXISTS table_name;
  ========================================================= */

DROP TABLE IF EXISTS Registrations;
DROP TABLE IF EXISTS Learners;
DROP TABLE IF EXISTS Subjects;
DROP TABLE IF EXISTS Divisions;
GO


/* =========================================================
   CREATE TABLE : Departments (DDL)

        -- CREATE TABLE
           CREATE TABLE table_name (
               column datatype constraint
           );

        -- PRIMARY KEY
           column datatype PRIMARY KEY;

        -- UNIQUE
           column datatype UNIQUE;
  ========================================================= */

CREATE TABLE Divisions (
    DivisionID INT PRIMARY KEY,
    DivisionTitle VARCHAR(50) UNIQUE NOT NULL
);
GO


/* =========================================================
   CREATE TABLE : Students (DDL)

        -- FOREIGN KEY
           FOREIGN KEY (column)
           REFERENCES parent_table(column);
  ========================================================= */

CREATE TABLE Learners (
    LearnerID INT PRIMARY KEY,
    LearnerFullName VARCHAR(50) NOT NULL,
    ContactEmail VARCHAR(100) UNIQUE,
    DivisionID INT,
    FOREIGN KEY (DivisionID) REFERENCES Divisions(DivisionID)
);
GO


/* =========================================================
   CREATE TABLE : Courses (DDL)
  ========================================================= */

CREATE TABLE Subjects (
    SubjectID INT PRIMARY KEY,
    SubjectTitle VARCHAR(50) NOT NULL,
    DivisionID INT,
    FOREIGN KEY (DivisionID) REFERENCES Divisions(DivisionID)
);
GO


/* =========================================================
   CREATE TABLE : Enrollments (COMPOSITE KEY)

        -- COMPOSITE PRIMARY KEY
           PRIMARY KEY (column1, column2);
  ========================================================= */

CREATE TABLE Registrations (
    LearnerID INT,
    SubjectID INT,
    Term VARCHAR(20),
    PRIMARY KEY (LearnerID, SubjectID),
    FOREIGN KEY (LearnerID) REFERENCES Learners(LearnerID),
    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
);
GO


/* =========================================================
   INSERT DATA (DML)

        -- INSERT INTO
           INSERT INTO table_name VALUES (...);

        -- INSERT WITH COLUMNS
           INSERT INTO table_name (col1, col2)
           VALUES (...);
  ========================================================= */

INSERT INTO Divisions VALUES
(10, 'Information Technology'),
(20, 'Civil'),
(30, 'Electronics');

INSERT INTO Learners VALUES
(501, 'Aman Verma', 'aman@gmail.com', 10),
(502, 'Pooja Shah', 'pooja@gmail.com', 10),
(503, 'Rahul Mehta', 'rahul@gmail.com', 20);

INSERT INTO Subjects VALUES
(301, 'Computer Networks', 10),
(302, 'Software Engineering', 10),
(303, 'Structural Design', 20);

INSERT INTO Registrations VALUES
(501, 301, 'Term 1'),
(501, 302, 'Term 1'),
(502, 301, 'Term 1'),
(503, 303, 'Term 1');
GO


/* =========================================================
   SELECT QUERIES (DQL)

        -- SELECT ALL
           SELECT * FROM table_name;

        -- WHERE
           SELECT * FROM table_name WHERE condition;

        -- ORDER BY
           SELECT * FROM table_name ORDER BY column;

        -- GROUP BY
           SELECT column, COUNT(*)
           FROM table_name
           GROUP BY column;
  ========================================================= */

SELECT * FROM Learners;
SELECT * FROM Learners WHERE DivisionID = 10;
SELECT * FROM Learners ORDER BY LearnerFullName;

SELECT DivisionID, COUNT(*) AS TotalLearners
FROM Learners
GROUP BY DivisionID;
GO


/* =========================================================
   JOINS

        -- INNER JOIN
           SELECT *
           FROM A INNER JOIN B ON condition;

        -- LEFT JOIN / RIGHT JOIN / FULL JOIN
  ========================================================= */

SELECT l.LearnerFullName, s.SubjectTitle
FROM Learners l
INNER JOIN Registrations r ON l.LearnerID = r.LearnerID
INNER JOIN Subjects s ON r.SubjectID = s.SubjectID;

SELECT l.LearnerFullName, r.SubjectID
FROM Learners l
LEFT JOIN Registrations r ON l.LearnerID = r.LearnerID;
GO


/* =========================================================
   UPDATE & DELETE (DML)

        -- UPDATE
           UPDATE table_name SET column=value WHERE condition;

        -- DELETE
           DELETE FROM table_name WHERE condition;
  ========================================================= */

UPDATE Learners
SET ContactEmail = 'aman_new@gmail.com'
WHERE LearnerID = 501;

DELETE FROM Registrations
WHERE LearnerID = 502 AND SubjectID = 301;
GO


/* =========================================================
   TCL COMMANDS

        -- BEGIN TRANSACTION
           BEGIN TRANSACTION;

        -- COMMIT
           COMMIT;

        -- ROLLBACK
           ROLLBACK;
  ========================================================= */

BEGIN TRANSACTION;
INSERT INTO Learners VALUES (504, 'Neha Kapoor', 'neha@gmail.com', 30);
ROLLBACK;

BEGIN TRANSACTION;
INSERT INTO Learners VALUES (505, 'Karan Malhotra', 'karan@gmail.com', 20);
COMMIT;
GO


/* =========================================================
   NORMALIZATION

        -- 1NF : Atomic values
        -- 2NF : No partial dependency
        -- 3NF : No transitive dependency
        -- BCNF: Every determinant is a key
  ========================================================= */

CREATE TABLE Learner_1NF (
    LearnerID INT,
    LearnerName VARCHAR(50),
    Subject VARCHAR(50)
);

CREATE TABLE Learner_2NF (
    LearnerID INT PRIMARY KEY,
    LearnerName VARCHAR(50)
);

CREATE TABLE Division_3NF (
    DivisionID INT PRIMARY KEY,
    DivisionTitle VARCHAR(50)
);

CREATE TABLE Instructor_Subject_BCNF (
    Instructor VARCHAR(50) PRIMARY KEY,
    Subject VARCHAR(50)
);
GO
