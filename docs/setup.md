# Development Environment Setup

This guide will help you set up your development environment for the Convenience Store Management System project.

## Prerequisites

Before you begin, ensure you have the following installed on your system:

### Required Software

1. **Operating System**: Windows 10/11 (recommended) or Windows Server 2016+
   
2. **Visual Studio 2022** (Community, Professional, or Enterprise)
   - Download from: https://visualstudio.microsoft.com/downloads/
   - Required workloads during installation:
     - .NET desktop development
     - Data storage and processing

3. **.NET Framework**
   - .NET Framework 4.7.2 or higher (included with Visual Studio)
   - Or .NET 6.0+ if using modern .NET

4. **SQL Server**
   - SQL Server 2019 or later (Express, Developer, or Enterprise)
   - Download SQL Server Express: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
   - SQL Server Management Studio (SSMS) - recommended for database management
   - Download SSMS: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms

### Optional Tools

1. **Git for Windows**
   - Download from: https://git-scm.com/download/win
   - Required for version control

2. **Visual Studio Extensions** (recommended)
   - ReSharper (optional, for advanced refactoring)
   - Code Maid (for code cleanup)
   - GitExtensions or GitHub Extension for Visual Studio

## Installation Steps

### Step 1: Install Visual Studio 2022

1. Download Visual Studio 2022 installer
2. Run the installer
3. Select the following workloads:
   - **.NET desktop development**
   - **Data storage and processing**
4. In the Individual components tab, ensure these are selected:
   - .NET Framework 4.7.2 targeting pack (or higher)
   - SQL Server Data Tools
   - Entity Framework 6 tools (if using EF)
5. Click Install and wait for completion

### Step 2: Install SQL Server

1. Download SQL Server (Express edition is sufficient for development)
2. Run the installer
3. Choose "Basic" installation type
4. Accept the license terms
5. Note the server name (usually `localhost\SQLEXPRESS` or `.\SQLEXPRESS`)
6. Install SQL Server Management Studio (SSMS) for easier database management

### Step 3: Install Git

1. Download Git for Windows
2. Run the installer with default settings
3. Verify installation by opening Command Prompt and typing:
   ```cmd
   git --version
   ```

### Step 4: Clone the Repository

1. Open Command Prompt or Git Bash
2. Navigate to your desired workspace directory:
   ```
   cd C:\Projects
   ```
3. Clone the repository:
   ```
   git clone https://github.com/olivvv-1009/convenience-store-management-system.git
   ```
4. Navigate to the project directory:
   ```
   cd convenience-store-management-system
   ```

### Step 5: Database Setup

1. Open SQL Server Management Studio (SSMS)
2. Connect to your SQL Server instance (e.g., `localhost\SQLEXPRESS`)
3. Create a new database:
   ```sql
   CREATE DATABASE ConvenienceStoreDB;
   ```
4. Run the database schema scripts located in `/database` folder (if available)
5. Update the connection string in the application configuration file

### Step 6: Open the Project in Visual Studio

1. Launch Visual Studio 2022
2. Click "Open a project or solution"
3. Navigate to the cloned repository folder
4. Select the `.sln` solution file
5. Wait for Visual Studio to restore NuGet packages

### Step 7: Configure the Application

1. Locate the application configuration file (usually `App.config` or `appsettings.json`)
2. Update the database connection string:
   ```xml
   <connectionStrings>
     <add name="ConvenienceStoreDB" 
          connectionString="Data Source=localhost\SQLEXPRESS;Initial Catalog=ConvenienceStoreDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
3. Adjust other settings as needed

### Step 8: Build the Project

1. In Visual Studio, go to **Build** > **Build Solution** (or press `Ctrl+Shift+B`)
2. Check the Output window for any errors
3. Resolve any missing dependencies or build errors

### Step 9: Run the Application

1. Set the startup project (right-click on the main project and select "Set as Startup Project")
2. Press `F5` to run with debugging or `Ctrl+F5` to run without debugging
3. The application should launch successfully

## Troubleshooting

### Common Issues

**Issue**: NuGet package restore failed
- **Solution**: Go to Tools > NuGet Package Manager > Package Manager Settings, and ensure package sources include nuget.org

**Issue**: Cannot connect to SQL Server
- **Solution**: 
  - Verify SQL Server service is running (check Services in Windows)
  - Verify the server name in connection string
  - Enable TCP/IP protocol in SQL Server Configuration Manager
  - Check Windows Firewall settings

**Issue**: Build errors related to missing references
- **Solution**: Right-click on the solution > Restore NuGet Packages

**Issue**: Application crashes on startup
- **Solution**: Check that the database is accessible and connection string is correct

## Next Steps

Once your environment is set up:

1. Review the [Build and Run Instructions](build.md)
2. Check the [Required Tools](tools.md) documentation
3. Read the [Contributing Guidelines](../CONTRIBUTING.md)
4. Explore the project structure and codebase

## Getting Help

If you encounter issues not covered in this guide:

1. Check existing GitHub Issues
2. Create a new issue with detailed error information
3. Contact team members for assistance
