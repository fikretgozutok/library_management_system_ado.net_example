# Library Management System

## Project Overview
This is a simple Windows Forms application demonstrating basic CRUD operations using ADO.NET. The application is designed to manage a small library system, focusing on managing books and authors. It uses ADO.NET to interact with a SQL Server database and showcases how to join two tables (Books and Authors) to display meaningful data.

---

## Features

- **CRUD Operations:**
  - Add, update, delete, and list books.
  - Add, update, delete, and list authors.
- **JOIN Example:**
  - Display books with their respective authors using an INNER JOIN query.
- **Search and Filter (Optional):**
  - Search books by title or author.
  - Filter books by publication date.
- **Report (Optional):**
  - Display the total count of books and authors.

---

## Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Database:** SQL Server
- **ADO.NET Components:**
  - `SqlConnection` for establishing database connections.
  - `SqlCommand` for executing SQL queries.
  - `SqlDataReader` and `SqlDataAdapter` for retrieving data.
  - `DataTable` for managing in-memory data.

---

## Database Design

### Tables:

1. **Books**
   - `BookID` (Primary Key, int, Auto Increment)
   - `Title` (nvarchar(255))
   - `AuthorID` (Foreign Key, int)
   - `PublishedDate` (date)

2. **Authors**
   - `AuthorID` (Primary Key, int, Auto Increment)
   - `Name` (nvarchar(255))
   - `Surname` (nvarchar(255))

### Sample Query (INNER JOIN):
```sql
SELECT Books.Title, Authors.Name, Authors.Surname, Books.PublishedDate
FROM Books
INNER JOIN Authors ON Books.AuthorID = Authors.AuthorID;
```

---

## How to Run the Project

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/fikretgozutok/library_management_system_ado.net_example.git
   ```

2. **Set Up the Database:**
   - Create a database in SQL Server.
   - Run the SQL script (provided in the `DatabaseScripts` folder) to create tables and insert sample data.

3. **Configure Connection String:**
   - Update the `connectionString` in the application’s configuration file (`App.config`) with your SQL Server credentials.

4. **Run the Application:**
   - Open the solution file in Visual Studio.
   - Build and run the project.

---

## Learning Objectives

By completing this project, you will learn:

1. How to use ADO.NET to connect to a database.
2. Implementing CRUD operations in a Windows Forms application.
3. Using SQL queries, including `JOIN`, to manipulate and retrieve data.
4. Designing a user-friendly interface for database operations.

---

## Contributing

If you would like to contribute to this project, feel free to fork the repository and submit a pull request.

---

## Author

[Fikret GÖZÜTOK](https://github.com/fikretgozutok)

