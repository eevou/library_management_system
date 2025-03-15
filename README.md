# Library Management System (LMS)

This is a simple Library Management System (LMS) implemented in C#. The system allows librarians to manage books in the library and users to borrow books. The project is structured using object-oriented programming principles and includes classes for books, library operations, users, and librarians.

## Table of Contents
- [Features](#features)
- [Classes Overview](#classes-overview)
- [Principles Used](#principles-used)
- [How to Run](#how-to-run)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Add Books**: Librarians can add new books to the library.
- **Remove Books**: Librarians can remove books from the library.
- **Display Books**: Both librarians and users can view the list of available books.
- **Borrow Books**: Users can borrow books from the library.
- **User Management**: Different roles for librarians and regular users.

## Classes Overview

### 1. `Book`
- Represents a book with properties: `Title`, `Author`, and `Year`.

### 2. `Library`
- Manages the collection of books.
- Methods:
  - `Add(Book book)`: Adds a book to the library.
  - `Remove(Book book)`: Removes a book from the library.
  - `Display()`: Displays all books in the library.
  - `borrow(Book book)`: Allows users to borrow a book.

### 3. `LibraryCard`
- Represents a library card with a unique `number`.

### 4. `LibraryUser`
- Inherits from `User`.
- Represents a regular user who can borrow books.
- Methods:
  - `BorrowBook(Book book, Library library)`: Allows the user to borrow a book.

### 5. `Librarian`
- Inherits from `User`.
- Represents a librarian who can manage books.
- Methods:
  - `AddBook(Book book, Library library)`: Adds a book to the library.
  - `RemoveBook(Book book, Library library)`: Removes a book from the library.
  - `UpdateBook(Book book)`: (Not implemented) Updates book details.

### 6. `User`
- Abstract class representing a generic user.
- Properties:
  - `Name`: Name of the user.
- Methods:
  - `DisplayBooks(Library library)`: Displays all books in the library.

### 7. `Program`
- Entry point of the application.
- Provides a simple console-based interface for librarians and users to interact with the library system.

## Principles Used

This project is designed using several **Object-Oriented Programming (OOP)** principles to ensure modularity, reusability, and maintainability. Below are the key principles applied:

### 1. **Encapsulation**
- Encapsulation is achieved by using **access modifiers** (e.g., `private`, `public`) to control access to class members.
- For example:
  - The `Library` class encapsulates the `books` array and related methods (`Add`, `Remove`, `Display`, `borrow`).
  - The `Book` class encapsulates properties like `Title`, `Author`, and `Year`.

### 2. **Inheritance**
- Inheritance is used to create a hierarchy of classes, promoting code reuse.
- For example:
  - The `Librarian` and `LibraryUser` classes inherit from the abstract `User` class, sharing common properties like `Name` and methods like `DisplayBooks`.

### 3. **Abstraction**
- Abstraction is achieved by defining abstract classes and methods that provide a blueprint for derived classes.
- For example:
  - The `User` class is an abstract class that defines the `DisplayBooks` method, which is implemented by both `Librarian` and `LibraryUser`.

### 4. **Polymorphism**
- Polymorphism allows objects of different classes to be treated as objects of a common superclass.
- For example:
  - Both `Librarian` and `LibraryUser` can use the `DisplayBooks` method defined in the `User` class, but they can have different implementations if needed.

### 5. **Single Responsibility Principle (SRP)**
- Each class has a single responsibility:
  - `Book` represents a book.
  - `Library` manages the collection of books.
  - `Librarian` handles librarian-specific operations.
  - `LibraryUser` handles user-specific operations.
  - `User` provides a common base for all users.

### 6. **Separation of Concerns**
- The project separates concerns by dividing functionality into different classes:
  - The `Library` class handles book management.
  - The `Librarian` and `LibraryUser` classes handle user-specific actions.
  - The `Program` class handles the user interface and interaction.

### 7. **Modularity**
- The project is divided into multiple files (`Book.cs`, `Library.cs`, `Librarian.cs`, etc.), making it easier to maintain and extend.
