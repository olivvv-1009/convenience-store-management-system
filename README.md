# Convenience Store Management System

## Overview
This project is a **Convenience Store Management System** developed to support daily operations such as sales (POS), product and inventory management, employee management, customer membership, promotions, and reporting.  
The project is implemented as part of the **Software Engineering** course and follows the **Agile (Scrum)** methodology.

---

## Features
- **Authentication & Authorization**
  - Login / Logout
  - Role-based access control (Admin, Staff)

- **Product & Inventory Management**
  - Product CRUD
  - Category and expiration date management
  - Inventory tracking and low-stock/expiration alerts

- **Sales (POS)**
  - Invoice creation
  - Barcode scanning
  - Multiple payment methods
  - Automatic inventory deduction
  - Invoice printing

- **Customer & Promotion**
  - Customer membership and loyalty points
  - Promotions and discount vouchers

- **Reporting**
  - Revenue reports (daily/monthly/yearly)
  - Top-selling products
  - Invoice history

---

## Technology Stack
- **Programming Language**: C#
- **Framework**: .NET (WinForms)
- **Database**: SQL Server
- **Architecture**: MVC
- **Project Management**: GitHub Projects, Agile (Scrum)

---

## Development Process
The project is developed using **Agile – Scrum**, organized into multiple sprints:
- Sprint 0: Project setup & planning
- Sprint 1: Authentication & user management
- Sprint 2: Product & inventory management
- Sprint 3: POS & invoice processing
- Sprint 4: Promotion & customer management
- Sprint 5: Reporting, testing & finalization

Progress is tracked using **GitHub Issues, Milestones, Project Board, and Roadmap**.

---

## Project Scope
- Single convenience store
- Offline sales management
- No integration with external payment gateways or hardware devices

---

## Getting Started

### Documentation

- **[Development Environment Setup](docs/setup.md)** - Complete guide to set up your development environment
- **[Required Tools & Dependencies](docs/tools.md)** - List of all tools and software needed
- **[Build & Run Instructions](docs/build.md)** - How to build and run the application
- **[Contributing Guidelines](CONTRIBUTING.md)** - How to contribute to this project

### Quick Start

1. **Prerequisites**: Install Visual Studio 2022, SQL Server, and Git
2. **Clone the repository**:
   ```bash
   git clone https://github.com/olivvv-1009/convenience-store-management-system.git
   cd convenience-store-management-system
   ```
3. **Set up the database**: Create a database named `ConvenienceStoreDB` in SQL Server
4. **Open in Visual Studio**: Open the `.sln` file
5. **Update connection string**: Configure the database connection in `App.config`
6. **Build and Run**: Press `F5` to build and run the application

For detailed instructions, see the [Setup Guide](docs/setup.md).

---

## Contributing

We welcome contributions from all team members! Please read our [Contributing Guidelines](CONTRIBUTING.md) before submitting pull requests.

### Development Workflow

1. Pick an issue from the [GitHub Issues](https://github.com/olivvv-1009/convenience-store-management-system/issues)
2. Create a feature branch
3. Make your changes following our coding standards
4. Submit a pull request

---

## Team Members
- Le Minh Anh
- Dinh Thi Anh Thu 
- Nguyen Dinh Thao Nhi
- Nguyen Huu Thong

---

## License

This project is developed as part of a Software Engineering course.
