# CRUD Operations Using C# and MySQL Server Database 🛠️

Welcome to the **CRUD Operations Using C# and MySQL Server Database** project! 🌐 This repository demonstrates how to perform **Create**, **Read**, **Update**, and **Delete** operations on a MySQL database using C#. In this project, we use a **Student Management System** as an example.

---

## Features 🔧
- **Create**: Add new student records to the database ➕
- **Read**: View all student details in a structured format 📊
- **Update**: Modify existing student records ✏️
- **Delete**: Remove unwanted student records from the database ❌

---

## Prerequisites 🛠️

Before running this project, ensure you have the following installed:

1. **MySQL Server**: Set up and running on your machine.
2. **C# Development Environment**: Visual Studio or any IDE supporting C#.
3. **.NET Framework**: Compatible with the project.

---

## Database Setup 🏛️

1. Create a database named `student_db` in MySQL.
2. Use the following SQL script to create the `students` table:

```sql
CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    age INT NOT NULL,
    grade VARCHAR(10) NOT NULL
);
```

3. Insert sample data (optional):

```sql
INSERT INTO students (name, age, grade) VALUES
('John Doe', 20, 'A'),
('Jane Smith', 22, 'B');
```

---

## Project Structure 🌈

- **Program.cs**: Entry point for the application.
- **DatabaseHandler.cs**: Contains methods for interacting with the MySQL database.
- **Models/Student.cs**: Defines the `Student` model.
- **UI**: Handles user input and displays output.

---

## How to Run 🚀

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/CRUD-operations-using-C-sharp-and-MySQL-Server-database.git
   ```

2. Open the project in Visual Studio.

3. Update the database connection string in `DatabaseHandler.cs`:

   ```csharp
   private const string connectionString = "Server=localhost;Database=student_db;Uid=root;Pwd=your_password;";
   ```

4. Build and run the project.

---

## Screenshots 🖼️

### Main Menu
![Main Menu Screenshot](link-to-screenshot)

### Add Student
![Add Student Screenshot](link-to-screenshot)

### View Students
![View Students Screenshot](link-to-screenshot)

---

## Contribution Guidelines 🙌

We welcome contributions! Feel free to submit a pull request or open an issue for suggestions or bugs.

---

## License 🔒

This project is licensed under the [MIT License](LICENSE).

---

## Contact 📢

If you have any questions, feel free to reach out:
- **Email**: [your-email@example.com](mailto:your-email@example.com)
- **GitHub**: [your-username](https://github.com/your-username)

