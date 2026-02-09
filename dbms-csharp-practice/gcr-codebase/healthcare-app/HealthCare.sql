/* =========================================================
   DATABASE CREATION (DDL)
  ========================================================= */

CREATE DATABASE HealthCare;
GO

USE HealthCare;
GO


/* =========================================================
   CREATE TABLE : Patient
  ========================================================= */

CREATE TABLE Patient (
    patient_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    dob DATE NOT NULL,
    phone VARCHAR(10) UNIQUE,
    address VARCHAR(200),
    blood_group VARCHAR(5)
);
GO


/* =========================================================
   INSERT DATA : Patient (DML)
  ========================================================= */

INSERT INTO Patient (name, dob, phone, address, blood_group) VALUES
('Suzanne Styles', '2004-04-10', '9876543210', 'Bangalore', 'O+'),
('Olly', '2004-03-13', '1234567890', 'Mumbai', 'A+'),
('Gurmehar Kaur', '2004-06-04', '8899776655', 'Delhi', 'B+'),
('Saumya Bansal', '2004-02-16', '9867452310', 'Jaipur', 'AB+');
GO


/* =========================================================
   CREATE TABLE : Specialization
  ========================================================= */

CREATE TABLE Specialization (
    specialist_id INT PRIMARY KEY IDENTITY(1,1),
    specialist_name VARCHAR(100) NOT NULL
);
GO


/* =========================================================
   INSERT DATA : Specialization
  ========================================================= */

INSERT INTO Specialization (specialist_name) VALUES
('Cardiologist'),
('Dermatologist'),
('Orthopedic'),
('Neurologist');
GO


/* =========================================================
   CREATE TABLE : Doctor
  ========================================================= */

CREATE TABLE Doctor (
    doctor_id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    contact VARCHAR(10),
    consultation_fee DECIMAL(10,2),
    specialist_id INT,
    FOREIGN KEY (specialist_id) REFERENCES Specialization(specialist_id)
);
GO


/* =========================================================
   INSERT DATA : Doctor
  ========================================================= */

INSERT INTO Doctor (name, contact, consultation_fee, specialist_id) VALUES
('Dr. Agarwal', '9988776655', 500, 1),
('Dr. Tarun', '8877665544', 400, 2),
('Dr. Sharma', '7766554433', 600, 3),
('Dr. Oberoi', '6655443322', 700, 4);
GO


/* =========================================================
   CREATE TABLE : Appointment
  ========================================================= */

CREATE TABLE Appointment (
    appointment_id INT PRIMARY KEY IDENTITY(1,1),
    patient_id INT,
    doctor_id INT,
    appointment_date DATE,
    appointment_time TIME,
    status VARCHAR(50),
    FOREIGN KEY (patient_id) REFERENCES Patient(patient_id),
    FOREIGN KEY (doctor_id) REFERENCES Doctor(doctor_id)
);
GO


/* =========================================================
   INSERT DATA : Appointment
  ========================================================= */

INSERT INTO Appointment VALUES
(1, 1, '2026-02-06', '10:00', 'Completed'),
(2, 2, '2026-02-07', '11:00', 'Completed'),
(3, 3, '2026-02-08', '12:00', 'Completed'),
(4, 1, '2026-02-09', '01:00', 'Scheduled');
GO


/* =========================================================
   CREATE TABLE : Visit
  ========================================================= */

CREATE TABLE Visit (
    visit_id INT PRIMARY KEY IDENTITY(1,1),
    appointment_id INT,
    diagnosis VARCHAR(200),
    notes VARCHAR(500),
    visit_date DATE,
    FOREIGN KEY (appointment_id) REFERENCES Appointment(appointment_id)
);
GO


/* =========================================================
   INSERT DATA : Visit
  ========================================================= */

INSERT INTO Visit VALUES
(1, 'Mild chest pain', 'ECG normal', '2026-02-06'),
(2, 'Skin allergy', 'Prescribed cream', '2026-02-07'),
(3, 'Knee pain', 'Minor ligament issue', '2026-02-08'),
(4, 'Routine checkup', 'BP slightly high', '2026-02-09');
GO


/* =========================================================
   CREATE TABLE : Prescription
  ========================================================= */

CREATE TABLE Prescription (
    prescription_id INT PRIMARY KEY IDENTITY(1,1),
    visit_id INT,
    medicine_name VARCHAR(100),
    dosage VARCHAR(50),
    duration VARCHAR(50),
    FOREIGN KEY (visit_id) REFERENCES Visit(visit_id)
);
GO


/* =========================================================
   INSERT DATA : Prescription
  ========================================================= */

INSERT INTO Prescription VALUES
(1, 'Paracetamol', '1 tablet daily', '5 days'),
(2, 'Cetirizine', 'Once at night', '3 days'),
(3, 'Pain Relief Gel', 'Apply thrice daily', '7 days'),
(4, 'BP Tablet', 'Evening after food', '10 days');
GO


/* =========================================================
   CREATE TABLE : Billing
  ========================================================= */

CREATE TABLE Billing (
    bill_id INT PRIMARY KEY IDENTITY(1,1),
    visit_id INT,
    total_amount DECIMAL(10,2),
    payment_status VARCHAR(20),
    FOREIGN KEY (visit_id) REFERENCES Visit(visit_id)
);
GO


/* =========================================================
   INSERT DATA : Billing
  ========================================================= */

INSERT INTO Billing VALUES
(1, 1500, 'Paid'),
(2, 1000, 'Paid'),
(3, 2000, 'Pending'),
(4, 1800, 'Pending');
GO


/* =========================================================
   STORED PROCEDURES
  ========================================================= */

CREATE PROCEDURE sp_SearchPatient @search VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Patient
    WHERE name LIKE '%' + @search + '%'
       OR phone = @search;
END;
GO

CREATE PROCEDURE sp_PatientVisitHistory @patient_id INT
AS
BEGIN
    SELECT v.visit_date, d.name AS doctor_name, v.diagnosis
    FROM Visit v
    JOIN Appointment a ON v.appointment_id = a.appointment_id
    JOIN Doctor d ON a.doctor_id = d.doctor_id
    WHERE a.patient_id = @patient_id
    ORDER BY v.visit_date DESC;
END;
GO


/* =========================================================
   AUDIT TABLE
  ========================================================= */

CREATE TABLE Audit_Log (
    log_id INT IDENTITY PRIMARY KEY,
    table_name VARCHAR(50),
    action VARCHAR(20),
    action_date DATETIME DEFAULT GETDATE()
);
GO


/* =========================================================
   TRIGGERS
  ========================================================= */

CREATE TRIGGER trg_Patient_Insert
ON Patient
AFTER INSERT
AS
BEGIN
    INSERT INTO Audit_Log VALUES ('Patient', 'INSERT', GETDATE());
END;
GO

CREATE TRIGGER trg_BlockDoctorDelete
ON Doctor
INSTEAD OF DELETE
AS
BEGIN
    PRINT 'Doctor deletion not allowed';
END;
GO

CREATE TRIGGER trg_BlockDropTable
ON DATABASE
FOR DROP_TABLE
AS
BEGIN
    PRINT 'Dropping tables is not allowed';
    ROLLBACK;
END;
GO


/* =========================================================
   INDEXES
  ========================================================= */

CREATE NONCLUSTERED INDEX idx_patient_phone ON Patient(phone);
CREATE NONCLUSTERED INDEX idx_appointment_date ON Appointment(appointment_date);
CREATE NONCLUSTERED INDEX idx_doctor_specialist ON Doctor(specialist_id);
GO


/* =========================================================
   REPORT QUERIES
  ========================================================= */

-- Pending payments per patient
SELECT p.name, SUM(b.total_amount) AS pending_amount
FROM Billing b
JOIN Visit v ON b.visit_id = v.visit_id
JOIN Appointment a ON v.appointment_id = a.appointment_id
JOIN Patient p ON a.patient_id = p.patient_id
WHERE b.payment_status = 'Pending'
GROUP BY p.name;
GO

-- Revenue per doctor
SELECT d.name, SUM(b.total_amount) AS revenue
FROM Billing b
JOIN Visit v ON b.visit_id = v.visit_id
JOIN Appointment a ON v.appointment_id = a.appointment_id
JOIN Doctor d ON a.doctor_id = d.doctor_id
WHERE b.payment_status = 'Paid'
GROUP BY d.name;
GO
