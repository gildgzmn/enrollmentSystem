# Enrollment System (VB.NET + MySQL)

This is a Student and Faculty Management System built with **Visual Basic .NET (Windows Forms)** and **MySQL**. 
It allows admin/faculty to register, enroll, manage subjects, and view assessments for students.

---

## Features

- Student enrollment and profile management
- Faculty encoding and class handling
- Curriculum and subject listings
- MySQL database integration

---

## Requirements

- [Visual Studio 2019/2022](https://visualstudio.microsoft.com/)
  - With **.NET Desktop Development** workload
- [MySQL Server 8+](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) *(optional for importing)*
- MySQL .NET Connector (Connector/NET)

---

## 🗂 Folder Structure Overview
```bash
MyProject/
├── backend/ ' DAO, Controller, and Model (Admin, Student, Faculty)
├── frontend/ ' Form Designer
├── assets/ ' Images used
├── resx/ ' .resx resource files (UI text, styles)
├── ProjectFiles/ ' .vbproj and solution config
├── README.md
```


---

## Setup Instructions

### 1. Clone or Extract the Project

```bash
git clone https://github.com/your-username/enrollmentSystem.git
```
Or download and extract the .zip from GitHub


### 2.  Import the MySQL Database (https://drive.google.com/drive/folders/1XJl2mBZduivi-pr-DGwOu_QwroyXmpam?usp=sharing)

Using MySQL Workbench

1. Launch MySQL Workbench
2. Connect to your local MySQL server (localhost)
3. Create a new schema: enrollment
4. Go to File > Run SQL Script
5. Select the .sql files from the google drive
6. Click Run


### 3.  Open the Project in Visual Studio

1. Launch Visual Studio
2. Open the solution file: enrollment sys.sln
3. Let it load and restore references


### 4.  Set Up MySQL Connection String

In your database connection file (e.g., DB.vb or MySQLHelper.vb), make sure to update:
```bash
Dim connString As String = "server=localhost;user id=root;password=yourpassword;database=enrollment;"
```
Replace yourpassword with your actual MySQL user password.

### 5.   Run the App

- Press F5 or click the green Start button in Visual Studio.
- The main form will launch.
- Navigate through the app using buttons and menus.




👤 Author
Developed by Gildgzmn
For academic and portfolio purposes


