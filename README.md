# Medical Clinic Management (C# / Windows Forms)

Desktop application for managing a small medical clinic: doctors, patients, appointments and prescriptions.
Built for the *Programming of Economic Applications (PAW)* course at the Bucharest University of Economic Studies.

## Features
- **CRUD** for doctors, patients, appointments and prescriptions, displayed in `DataGridView` tables
- **MDI interface**: a main window with a menu that opens each module only once
- **Input validation** with `ErrorProvider` (required fields, 13-digit CNP check, phone number)
- **Delete confirmation** dialogs and error handling for database exceptions
- Appointments linked to patients and doctors via `JOIN` queries; prescriptions linked to appointments

## Architecture
```
Models/         Plain classes: Medic, Pacient, Programare, Reteta
Repositories/   Data access with ADO.NET (SqlConnection, SqlCommand, parameterized queries)
Forms/          Windows Forms UI (list views + add/edit dialogs)
Helpers/        Connection string
Database/       SQL schema (tables, primary/foreign keys, constraints)
```

## Tech stack
C# · .NET Framework 4.8 · Windows Forms · ADO.NET · SQL Server LocalDB

## Running it
1. Open `CabinetMedical.sln` in Visual Studio (with the *.NET desktop development* workload).
2. The LocalDB database file `CabinetMedicalDB.mdf` is attached automatically on start.
   To recreate it from scratch, run `Database/schema.sql`.
3. Press **F5**.
