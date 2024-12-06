# Bakery Management System

## Overview

The Bakery Management System is a web application built with **ASP.NET Core Razor Pages**, **Entity Framework Core**, and **SQL Server**. This application allows bakery owners to manage products and orders efficiently, while customers can browse products, add them to a cart, and place orders. The system also integrates email notifications using **SMTP4Dev** for testing purposes.

---

## Features

- **Product Management:**
  - Add, update, read, and delete products.
  - Manage product details such as name, price, and description.

- **Customer Shopping Experience:**
  - Browse products available in the bakery.
  - Add items to the shopping cart.
  - Maintain shopping cart state using **cookies**.
  - Proceed to a **checkout page** to finalize the order.

- **Email Integration:**
  - Email notifications are sent upon order placement using **SMTP4Dev** for local email testing.

- **Admin Dashboard:**
  - View and manage the products and orders from the admin dashboard.

- **Responsive Design:**
  - Built using **Bootstrap** for a responsive, mobile-friendly interface.

- **Real-time cart handling with JavaScript** for dynamic updates.

---

## Technologies Used

- **Frontend:**
  - **ASP.NET Core Razor Pages** (MVC framework)
  - **Bootstrap** for responsive design
  - **JavaScript** for dynamic content management

- **Backend:**
  - **ASP.NET Core** for server-side logic
  - **Entity Framework Core** (EF Core) for database interaction
  - **SQL Server** for data storage

- **Email Integration:**
  - **SMTP4Dev** for local email integration and testing

- **Cookies:**
  - Cart state is stored using **cookies** for a persistent user experience.

---

## Setup and Installation

### Prerequisites

Ensure that the following are installed on your system:

- **.NET SDK 6.0 or higher**
- **SQL Server** (or SQL Server Express)
- **Visual Studio** or **Visual Studio Code**

### Cloning the Repository

1. Clone the repository:
   ```bash
   git clone https://github.com/Rajan-Shr/Bakery-Shop.git
