# Build and Run Instructions

This guide explains how to build and run the Convenience Store Management System project.

## Prerequisites

Before building the project, ensure you have:

1. Completed the [Development Environment Setup](setup.md)
2. Installed all [Required Tools](tools.md)
3. Cloned the repository to your local machine
4. Set up the database

## Building the Project

### Using Visual Studio (Recommended)

#### First-Time Build

1. **Open the Solution**
   - Launch Visual Studio 2022
   - Click **File** > **Open** > **Project/Solution**
   - Navigate to the repository folder
   - Select the `.sln` file and click **Open**

2. **Restore NuGet Packages**
   - Visual Studio should automatically restore NuGet packages
   - If not, right-click on the solution in Solution Explorer
   - Select **Restore NuGet Packages**
   - Wait for the process to complete

3. **Set Build Configuration**
   - Select **Debug** or **Release** configuration from the toolbar
   - Select **Any CPU**, **x86**, or **x64** platform as appropriate
   - For development, use **Debug** configuration

4. **Build the Solution**
   - Click **Build** > **Build Solution** (or press `Ctrl+Shift+B`)
   - Check the **Output** window for build messages
   - Ensure build completes with 0 errors

#### Subsequent Builds

After making code changes:

1. **Clean the Solution** (optional, recommended after major changes)
   - Click **Build** > **Clean Solution**
   - This removes all compiled binaries

2. **Rebuild**
   - Click **Build** > **Rebuild Solution** (or press `Ctrl+Alt+F7`)
   - This performs a clean build of all projects

### Using Command Line (MSBuild)

#### Build with MSBuild

1. **Open Developer Command Prompt**
   - Search for "Developer Command Prompt for VS 2022" in Start menu
   - Or use "Developer PowerShell for VS 2022"

2. **Navigate to Project Directory**
   ```cmd
   cd C:\Projects\convenience-store-management-system
   ```

3. **Restore NuGet Packages**
   ```cmd
   nuget restore YourSolution.sln
   ```
   Or using .NET CLI:
   ```cmd
   dotnet restore
   ```

4. **Build the Solution**
   ```cmd
   msbuild YourSolution.sln /p:Configuration=Debug
   ```
   Or using .NET CLI:
   ```cmd
   dotnet build --configuration Debug
   ```

5. **For Release Build**
   ```cmd
   msbuild YourSolution.sln /p:Configuration=Release
   ```

## Running the Application

### From Visual Studio

1. **Set Startup Project**
   - In Solution Explorer, right-click on the main project
   - Select **Set as Startup Project**
   - The project name will appear in bold

2. **Run with Debugging**
   - Press `F5` or click the green **Start** button
   - Debugger will attach to the application
   - Breakpoints will be active

3. **Run without Debugging**
   - Press `Ctrl+F5` or click **Debug** > **Start Without Debugging**
   - Application runs faster without debugger overhead
   - Useful for testing performance

### From Command Line

1. **Navigate to Output Directory**
   ```cmd
   cd bin\Debug\net6.0
   ```
   Or for .NET Framework:
   ```cmd
   cd bin\Debug
   ```

2. **Run the Executable**
   ```cmd
   YourProjectName.exe
   ```
   
   Note: Replace `YourProjectName.exe` with the actual executable name once the project is created.

### First Run Configuration

On first run, you may need to:

1. **Configure Database Connection**
   - The application may prompt for database connection details
   - Enter the SQL Server instance name (e.g., `localhost\SQLEXPRESS`)
   - Provide database name: `ConvenienceStoreDB`
   - Use Windows Authentication (recommended) or SQL Server authentication

2. **Initialize Database**
   - The application may auto-create tables if using Code First approach
   - Or you may need to run database scripts manually

3. **Create Admin Account**
   - The system may prompt to create an initial administrator account
   - Provide username, password, and other required information

## Testing the Application

### Manual Testing

1. **Test Login**
   - Use the admin credentials created during setup
   - Verify successful login

2. **Test Core Features**
   - Navigate through main modules
   - Test CRUD operations
   - Verify data persistence

### Running Unit Tests

If unit tests exist in the solution:

1. **Open Test Explorer**
   - Click **Test** > **Test Explorer** (or press `Ctrl+E, T`)

2. **Run All Tests**
   - Click **Run All** in Test Explorer
   - Or right-click on test project > **Run Tests**

3. **Run Specific Tests**
   - Select individual tests or test classes
   - Right-click and select **Run**

4. **View Test Results**
   - Green checkmark indicates passed tests
   - Red X indicates failed tests
   - Click on failed tests to see error details

## Build Configurations

### Debug Configuration

**Purpose**: Development and debugging

**Characteristics**:
- Includes debug symbols (.pdb files)
- No code optimization
- Assertions enabled
- Larger executable size
- Slower runtime performance

**When to Use**: During development, debugging, and testing

### Release Configuration

**Purpose**: Production deployment

**Characteristics**:
- Optimized code
- No debug symbols (smaller size)
- Assertions disabled
- Better performance
- Harder to debug

**When to Use**: For production releases and performance testing

## Common Build Issues and Solutions

### Issue: Build Failed - Missing References

**Error**: "The type or namespace name 'X' could not be found"

**Solution**:
```cmd
# Restore NuGet packages
nuget restore
# Or
dotnet restore
```

### Issue: Database Connection Failed

**Error**: "Cannot connect to SQL Server"

**Solution**:
1. Verify SQL Server service is running
2. Check connection string in App.config
3. Test connection using SSMS
4. Verify firewall settings

### Issue: Missing DLL Files

**Error**: "Could not load file or assembly"

**Solution**:
1. Clean and rebuild the solution
2. Check that all dependencies are properly referenced
3. Verify NuGet packages are restored

### Issue: Build Succeeded but Runtime Error

**Error**: Application crashes on startup

**Solution**:
1. Check the Output window for exceptions
2. Review App.config settings
3. Verify database initialization
4. Check log files (if logging is implemented)

### Issue: Slow Build Times

**Solution**:
1. Disable antivirus scanning for project folder (temporarily)
2. Exclude bin and obj folders from Windows Indexing
3. Use an SSD for the project directory
4. Close unnecessary Visual Studio extensions

## Deployment

### Creating a Release Build

1. **Set to Release Configuration**
   ```cmd
   msbuild /p:Configuration=Release
   ```

2. **Locate Output Files**
   - Navigate to `bin\Release\` folder
   - All required DLLs and EXE will be present

3. **Test Release Build**
   - Run the application from the Release folder
   - Verify all features work correctly

### Packaging for Distribution

1. **Collect Dependencies**
   - Copy all files from `bin\Release\` folder
   - Include App.config (or appsettings.json)
   - Include any required resources, images, or templates

2. **Create Installer** (optional)
   - Use Visual Studio Installer Projects extension
   - Or use WiX Toolset for advanced installers
   - Or use ClickOnce deployment

3. **Database Scripts**
   - Include SQL scripts for database creation
   - Document database setup steps
   - Consider including sample data

## Performance Optimization

### Optimize Build Performance

1. **Use Parallel Builds**
   ```cmd
   msbuild /m
   ```

2. **Disable Unnecessary Code Analysis**
   - Temporarily disable code analyzers during development
   - Enable before committing code

3. **Reduce IntelliSense Database Size**
   - Tools > Options > Text Editor > C# > IntelliSense
   - Adjust settings as needed

### Optimize Runtime Performance

1. **Profile the Application**
   - Use Visual Studio Performance Profiler
   - Identify bottlenecks

2. **Database Optimization**
   - Add proper indexes
   - Optimize queries
   - Use compiled queries for Entity Framework

3. **UI Optimization**
   - Implement virtual scrolling for large datasets
   - Use asynchronous operations
   - Minimize UI thread blocking

## Continuous Integration (Future)

For future CI/CD implementation:

1. **GitHub Actions**
   - Automate builds on every commit
   - Run automated tests
   - Deploy to staging environment

2. **Build Pipeline**
   - Checkout code
   - Restore dependencies
   - Build solution
   - Run tests
   - Publish artifacts

## Getting Help

If you encounter build or runtime issues:

1. Check the **Error List** window in Visual Studio
2. Review the **Output** window for detailed messages
3. Search for error codes online
4. Check GitHub Issues for similar problems
5. Create a new issue with:
   - Error message
   - Stack trace
   - Steps to reproduce
   - Environment details (OS, VS version, etc.)

## Next Steps

After successfully building and running the application:

1. Review the [Contributing Guidelines](../CONTRIBUTING.md)
2. Explore the codebase and understand the architecture
3. Start working on assigned issues or features
4. Follow coding standards and best practices
