Objective:
Build a simple Library Management Console Application using Entity Framework Core Code First approach. The app will allow users to manage books and authors in a local database.

Scenario:
You are developing a basic backend system for a library where books are stored along with their authors. Each book has a title, publication year, and author. Authors can have multiple books.

You need to implement this in a .NET Console Application using Entity Framework Core Code First approach.

Requirements:
Create Models

Author

AuthorId (int, Primary Key)

Name (string)

Email (string)

Book

BookId (int, Primary Key)

Title (string)

YearPublished (int)

AuthorId (Foreign Key)

Configure a DbContext:

Use DbContext to define Authors and Books as DbSet.

Implement Code First Migrations

Use the NugetPackageManager Console to create and apply the database migration.

CRUD Operations via Console Menu

Create new authors

Add books to authors

List all books with authors

Update a book’s title

Delete a book

Use SQLServer LocalDB for simple setup.
