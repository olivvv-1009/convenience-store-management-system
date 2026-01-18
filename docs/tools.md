# Required Tools and Dependencies

This document lists all the tools, software, and dependencies required for developing the Convenience Store Management System.

## Development Tools

### 1. Visual Studio 2022

**Purpose**: Primary IDE for C# development

**Version**: Visual Studio 2022 (any edition: Community, Professional, Enterprise)

**Download**: https://visualstudio.microsoft.com/downloads/

**Required Workloads**:
- .NET desktop development
- Data storage and processing

**Recommended Extensions**:
- GitHub Extension for Visual Studio
- Code Maid (code cleanup and organization)
- ReSharper (optional, advanced code analysis)
- Productivity Power Tools

### 2. .NET Framework / .NET SDK

**Purpose**: Application runtime and development framework

**Version**: 
- .NET Framework 4.7.2 or higher (Windows Forms)
- Note: The specific version will be determined during project setup

**Installation**: Included with Visual Studio 2022

### 3. SQL Server

**Purpose**: Database management system

**Recommended Version**: SQL Server 2019 or later

**Editions** (choose one):
- **SQL Server Express** (free, recommended for development)
  - Download: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
  - Limitations: 10 GB max database size, uses max 1 processor, 1 GB memory
- **SQL Server Developer** (free, full-featured for non-production)
- **SQL Server Standard/Enterprise** (licensed, for production)

**Instance Name**: Default is `SQLEXPRESS` or `MSSQLSERVER`

### 4. SQL Server Management Studio (SSMS)

**Purpose**: GUI tool for SQL Server database administration

**Version**: Latest version (19.x or higher)

**Download**: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms

**Features Used**:
- Database creation and management
- Query execution
- Schema design
- Data import/export
- Backup and restore

### 5. Git

**Purpose**: Version control system

**Version**: Latest stable version (2.40+)

**Download**: https://git-scm.com/download/win

**GUI Clients** (optional):
- GitHub Desktop
- GitKraken
- SourceTree
- Git Extensions

## Runtime Dependencies

### NuGet Packages

The following NuGet packages may be required (check the `.csproj` files):

#### Core Packages
- **System.Data.SqlClient** - SQL Server database connectivity
- **EntityFramework** (or **Microsoft.EntityFrameworkCore**) - ORM for database operations
- **Newtonsoft.Json** - JSON serialization/deserialization

#### UI Components (if used)
- **MetroFramework** - Modern UI framework for WinForms
- **Bunifu.UI.WinForms** - UI component library
- **DevExpress.WinForms** - Advanced UI controls (commercial)

#### Reporting (if used)
- **CrystalReports** - Report generation
- **Microsoft.Reporting.WinForms** - RDLC reports

#### Barcode Support (if used)
- **ZXing.Net** - Barcode scanning and generation
- **BarcodeLib** - Barcode generation

#### Utilities
- **Dapper** - Lightweight ORM (alternative to EF)
- **AutoMapper** - Object-to-object mapping
- **Serilog** or **NLog** - Logging framework

## Database Tools

### 1. Database Schema Management
- SQL Server Management Studio (SSMS)
- Azure Data Studio (alternative to SSMS)

### 2. Database Migration Tools (if used)
- Entity Framework Migrations
- DbUp
- FluentMigrator

## Testing Tools

### Unit Testing
- **MSTest** - Microsoft's testing framework (built into Visual Studio)
- **NUnit** - Popular .NET testing framework
- **xUnit** - Modern testing framework

### Test Coverage
- **Code Coverage** (built into Visual Studio Enterprise)
- **OpenCover** + **ReportGenerator** (free alternative)

### UI Testing (optional)
- **TestStack.White** - UI automation
- **FlaUI** - WinForms UI automation

## Code Quality Tools

### Static Analysis
- **StyleCop** - Code style analyzer
- **FxCop** / **Code Analysis** - Built into Visual Studio
- **SonarLint** - Real-time code quality feedback

### Code Formatting
- **.editorconfig** - Code style configuration (included in repository)
- **Code Maid** - Code cleanup extension

## Design and Documentation Tools

### Database Design
- **SQL Server Management Studio** - ER diagram designer
- **dbdiagram.io** - Online database diagram tool
- **Lucidchart** - Professional diagramming tool

### UML and Architecture Diagrams
- **Visual Studio Class Designer** - Built-in UML tool
- **draw.io** (diagrams.net) - Free diagramming tool
- **Microsoft Visio** - Professional diagramming
- **PlantUML** - Text-based UML diagrams

### Documentation
- **Markdown** - For README and documentation files
- **Sandcastle** / **DocFX** - API documentation generation
- **Swagger** / **OpenAPI** - API documentation (if applicable)

## Version Control and Collaboration

### Repository Hosting
- **GitHub** - https://github.com/olivvv-1009/convenience-store-management-system

### Project Management
- **GitHub Issues** - Issue tracking
- **GitHub Projects** - Kanban board
- **GitHub Milestones** - Sprint planning

## System Requirements

### Minimum Hardware Requirements
- **CPU**: Dual-core processor, 1.8 GHz or faster
- **RAM**: 4 GB (8 GB recommended)
- **Disk Space**: 10 GB free space
- **Display**: 1280 x 720 resolution

### Recommended Hardware Requirements
- **CPU**: Quad-core processor, 2.6 GHz or faster
- **RAM**: 16 GB or more
- **Disk Space**: 20 GB free space (SSD recommended)
- **Display**: 1920 x 1080 resolution or higher

### Operating System
- **Windows 10** (version 1809 or higher)
- **Windows 11**
- **Windows Server 2016** or later

## Installation Order

To set up the development environment, install tools in this order:

1. **Visual Studio 2022** (with required workloads)
2. **SQL Server** (Express or Developer edition)
3. **SQL Server Management Studio (SSMS)**
4. **Git for Windows**
5. Clone the repository
6. Open solution in Visual Studio
7. Restore NuGet packages
8. Configure database connection
9. Build and run

## Keeping Tools Updated

### Visual Studio
- Check for updates: Help > Check for Updates
- Install updates regularly for bug fixes and new features

### SQL Server
- Apply cumulative updates and service packs
- Check Microsoft Update or download from Microsoft website

### NuGet Packages
- Update packages cautiously to avoid breaking changes
- Test thoroughly after updating major versions

## License Information

### Free Tools
- Visual Studio Community (free for individual developers, open-source projects, academic research)
- SQL Server Express (free with limitations)
- SQL Server Developer (free for non-production use)
- Git (open-source)
- SSMS (free)

### Commercial Tools (Optional)
- Visual Studio Professional/Enterprise (paid)
- SQL Server Standard/Enterprise (paid)
- DevExpress components (paid)
- ReSharper (paid)

## Support and Resources

- **Visual Studio Documentation**: https://docs.microsoft.com/en-us/visualstudio/
- **C# Documentation**: https://docs.microsoft.com/en-us/dotnet/csharp/
- **.NET Documentation**: https://docs.microsoft.com/en-us/dotnet/
- **SQL Server Documentation**: https://docs.microsoft.com/en-us/sql/
- **Entity Framework Documentation**: https://docs.microsoft.com/en-us/ef/
- **Git Documentation**: https://git-scm.com/doc

## Next Steps

After installing all required tools:

1. Follow the [Development Environment Setup Guide](setup.md)
2. Review the [Build and Run Instructions](build.md)
3. Read the [Contributing Guidelines](../CONTRIBUTING.md)
