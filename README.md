# Lumi Library Management System

**Lumi Library Management System** is a modern web application built with ASP.NET Core MVC that simplifies library management by handling books and authors through an intuitive interface. Designed with object-oriented programming (OOP) principles, this system provides efficient CRUD operations for managing library records and features a clean, responsive design.

---

![LUMİ Library Management System](./assets/MVCLibraryManagementSystem.gif)



## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Architecture & Technologies](#architecture--technologies)
- [Project Structure](#project-structure)
- [Contribution](#contribution)
- [License](#license)

---

## Features

- **Book Management**
  - Create, Read, Update, and Delete (CRUD) operations for books.
  - Manage book details including Title, Genre, ISBN, Publish Date, and Available Copies.
  
- **Author Management**
  - CRUD operations for authors.
  - Manage author details such as First Name, Last Name, Date of Birth, and view their associated books.

- **User-Friendly Interface**
  - Modern, minimalistic design with a responsive layout.
  - Intuitive navigation featuring a full-screen hero section, custom forms, and interactive tables.
  
- **Dynamic Data Management**
  - Efficient handling of data using well-defined models and view models.
  - Supports search and filtering functionalities for quick record retrieval.

---

## Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/halenurincedere/MVCLibraryManagementSystem.git
   cd MVCLibraryManagementSystem

## Usage

- **Home Page:**
    - The home page features a full-screen hero section with a bold call-to-action button. Users are greeted with a modern design that clearly directs them to explore the system.
- **Books:**
    - Use the Books page (accessible via the navigation bar) to view, add, edit, or delete book records.
- **Authors:**
    - The Authors page allows you to manage author details and view the books associated with each author.
- **About:**
    - The About page provides detailed information about the project, its purpose, and future enhancements.
- **User Operations:**
    - Additional user functionalities such as login and registration can be integrated as needed.

---

## Architecture & Technologies

- **ASP.NET MVC:**
    - Provides the framework for building the application with Controllers, Views, and Routing.
- **.NET 9:**
    - Utilized for modern, high-performance web development.
- **C# & OOP Principles:**
    - The project is structured using object-oriented programming best practices, with clearly defined models and view models.
- **Razor View Engine:**
    - Uses Layouts, Partial Views, and Tag Helpers to create a dynamic and modular UI.
- **Bootstrap:**
    - Ensures a responsive and modern user interface with a mobile-first approach.
- **Custom CSS/SCSS:**
    - Implements a minimalistic design with a custom color scheme and modern UI elements.

--- 

## Project Structure
```bash
LibraryManagementSystem/
├─ Controllers/
│  ├─ BookController.cs
│  ├─ AuthorController.cs
│  ├─ HomeController.cs
│  └─ AccountController.cs (optional)
├─ Models/
│  ├─ Book.cs
│  ├─ Author.cs
│  ├─ BookViewModel.cs
│  └─ AuthorViewModel.cs
├─ Views/
│  ├─ Shared/
│  │  ├─ _Layout.cshtml
│  │  ├─ _NavbarPartial.cshtml
│  │  └─ _FooterPartial.cshtml
│  ├─ Home/
│  │  ├─ Index.cshtml
│  │  └─ About.cshtml
│  ├─ Book/
│  │  ├─ List.cshtml
│  │  ├─ Create.cshtml
│  │  ├─ Edit.cshtml
│  │  └─ Details.cshtml
│  └─ Author/
│     ├─ List.cshtml
│     ├─ Create.cshtml
│     ├─ Edit.cshtml
│     └─ Details.cshtml
├─ wwwroot/
│  ├─ css/
│  ├─ lib/
│  └─ images/
├─ appsettings.json
├─ Program.cs
└─ README.md
```

# Contribution

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch:

    ```bash git checkout -b feature/YourFeature```

3. Commit your changes:

    ```bash git commit -m "Add feature description"```
4. Push to your branch:

    ```bash git push origin feature/YourFeature```
5. Open a pull request for review.

    Please ensure your code follows the project’s coding standards and includes proper documentation.

---
## License

This project is licensed under the MIT License. See the LICENSE file for details.
