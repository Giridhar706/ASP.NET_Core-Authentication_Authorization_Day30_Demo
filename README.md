# Secure E-Commerce Portal 🛡️

A lightweight **ASP.NET Core MVC** prototype demonstrating enterprise-grade authentication, strict role-based access control (RBAC), and dynamic UI rendering.

---

## 📌 Overview

This project provides secure, isolated environments for three distinct user types:

* **Administrators**
* **Sellers**
* **Customers**

It leverages **ASP.NET Core Identity** for authentication/security and **Entity Framework Core** for database management and automated data seeding.

---

## ✨ Key Features

* 🔐 **Authentication**

  * Secure user registration and login
  * Encrypted credential management using ASP.NET Core Identity

* 🛡️ **Role-Based Authorization**

  * Strict controller-level access control
  * Separate authorization policies for Admin, Seller, and Customer roles

* ⚙️ **Automated Data Seeding**

  * Automatically creates:

    * Core roles
    * Default master Admin account

* 🎨 **Dynamic UI Rendering**

  * Navigation menus adapt based on:

    * Authentication state
    * User roles

---

## 🛠️ Tech Stack

| Technology            | Usage                     |
| --------------------- | ------------------------- |
| ASP.NET Core MVC      | Web Framework             |
| C#                    | Backend Language          |
| Entity Framework Core | ORM & Database Management |
| SQL Server            | Database                  |
| ASP.NET Core Identity | Authentication & Security |
| Razor Views           | Frontend Templating       |
| Bootstrap             | UI Styling                |

---

## 🚀 Quick Start

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/DibyaGit/SecureEcommerceApp.git
```

---

### 2️⃣ Open the Project

Open the solution file in **Visual Studio**:

```text
SecureEcommerceApp.sln
```

---

### 3️⃣ Build the Database

Open:

```text
Tools → NuGet Package Manager → Package Manager Console
```

Run:

```powershell
Update-Database
```

---

### 4️⃣ Run the Application

Press:

```text
F5
```

This will:

* Build the application
* Seed the database
* Launch the portal

---

## 🔐 Default Test Credentials

The database seeding mechanism automatically creates the following Admin account:

| Role  | Email             | Password    | Access               |
| ----- | ----------------- | ----------- | -------------------- |
| Admin | `admin@admin.com` | `Admin@123` | Full `/Admin` Access |

> Seller and Customer accounts can be created using the standard registration flow.

---

## 🏗️ Core Architecture

### 📂 Data Layer

#### `/Data/DbSeeder.cs`

Responsible for:

* Creating default roles
* Seeding the master Admin account

---

### 📂 Controllers

| Controller          | Authorization                   |
| ------------------- | ------------------------------- |
| `AdminController`   | `[Authorize(Roles = "Admin")]`  |
| `SellerController`  | `[Authorize(Roles = "Seller")]` |
| `ProductController` | `[Authorize]`                   |

---

### 📂 Shared Layout

#### `/Views/Shared/_Layout.cshtml`

Contains dynamic role-aware UI rendering logic:

```cshtml
@if (User.IsInRole("Admin"))
{
    // Render admin navigation
}
```

---

## 🔒 Security Highlights

* ASP.NET Core Identity integration
* Secure password hashing
* Authentication cookies
* Role-based route protection
* Authorization attributes for controller isolation

---

## 📸 Future Improvements

* Product management dashboard
* Shopping cart & checkout flow
* JWT Authentication API
* Order tracking system
* Payment gateway integration
* Email verification & password recovery

---

## 👨‍💻 Author

### Giridhar Gopal
