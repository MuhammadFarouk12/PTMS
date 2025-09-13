# Online Quiz & Examination System

## Overview  
This project is an online quiz and examination system designed to manage student assessments, track payments, and organize quizzes by levels. The system allows students to take quizzes, record their performance, and enables administrators to manage content, levels, and financial transactions.

---

## System Features

### 1. **Student Management**
- Store student details including first name, last name, and unique student ID (`std_id`).
- Each student can participate in multiple examinations.

### 2. **Quiz & Question Management**
- Create and manage quizzes with a unique `quiz_id`.
- Each quiz contains multiple questions.
- Questions are stored with text and associated with a specific quiz.

### 3. **Multiple Choice Questions**
- Support for multiple-choice questions via the `Choice` table.
- Each choice includes the text and a flag indicating whether it's correct (`is_true`).

### 4. **Level-Based Progression**
- Quizzes are organized into levels (e.g., Beginner, Intermediate, Advanced).
- Levels have a defined order and may be locked until prerequisites are met.
- Students must progress through levels sequentially.

### 5. **Examination Tracking**
- Record each examination attempt with:
  - Student ID
  - Quiz taken
  - Start and end times
  - Final mark achieved
  - Associated level

### 6. **Payment Integration**
- Track payment details for students using the `Payment` table.
- Includes fields like:
  - Payment ID
  - Amount paid
  - Payment method
  - Transaction ID
  - Date of transaction
- Links to student records to ensure only paid users can access certain content.

### 7. **Data Integrity & Relationships**
- Fully normalized relational schema ensures data consistency.
- Foreign key constraints maintain referential integrity between tables.

---

## Technologies Used

### Programming Language & Framework
 **C#** – Primary language used for application logic and backend development.
- **.NET Framework** – Provides the runtime environment and libraries for building robust desktop or web applications.

### Database
- **MySQL** – Relational database management system used to store all application data.
- **MySQL Workbench** – Used for designing the database schema (ERD), creating tables, and managing relationships.

### Version Control
- **Git & GitHub** – Used for version control and collaborative development. Enables tracking changes, branching, and deployment workflows.

---

## Technologies Used for Linking: MySQL Driver for C#

To connect C# applications to the MySQL database, we use the **MySQL Connector/NET**, which is a .NET driver developed by Oracle that enables communication between C# applications and MySQL databases.

### Key Points:
- **MySQL Connector/NET** allows developers to execute SQL queries, retrieve results, and manage transactions directly from C# code.
- It supports both synchronous and asynchronous operations, making it suitable for scalable applications.
- The connector uses ADO.NET patterns, meaning it integrates seamlessly with existing .NET data access practices such as `MySqlConnection`, `MySqlCommand`, and `MySqlDataReader`.

### Benefits:
- High performance and reliability.
- Full support for MySQL features like stored procedures, transactions, and prepared statements.
- Easy integration with .NET applications using standard ADO.NET interfaces.

### How To Run The Project
> ⚠️ Note: Ensure the MySQL Connector/NET package is installed via NuGet (`Install-Package MySql.Data`) before running the application.
> ⚠️ Note: Ensure the Guna UI package is installed via NuGet (Install-Package Guna.UI.WinForms) before running the application. Additionally, make sure your project targets .NET Framework 4.5.2 or higher, and enable "Allow NuGet to download missing packages" to ensure proper dependency resolution. 

---

## Schema Design (Based on ERD)

The system consists of the following core tables:

| Table          | Purpose |
|----------------|--------|
| `Student`      | Stores student information |
| `Payment`      | Tracks payment history |
| `Level`        | Defines quiz difficulty levels |
| `Quiz`         | Contains quiz metadata |
| `Question`     | Holds individual quiz questions |
| `Choice`       | Stores answer options for questions |
| `Examination`  | Logs exam attempts and results |

### Relationships:
- One student can have many payments and exams.
- One quiz has many questions.
- Each question has multiple choices.
- An exam is tied to one student, one quiz, and one level.
- Levels are ordered and can be locked based on progression rules.

1. Clone the repository from GitHub.
2. Install MySQL and create the database using the provided schema.
3. Configure the connection string in your C# application.
4. Install the MySQL Connector/NET via NuGet.
5. Build and run the application.
---
