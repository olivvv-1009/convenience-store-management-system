# Contributing to Convenience Store Management System

Thank you for your interest in contributing to this project! This document provides guidelines and instructions for contributing to the Convenience Store Management System.

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [Development Workflow](#development-workflow)
- [Coding Standards](#coding-standards)
- [Commit Guidelines](#commit-guidelines)
- [Pull Request Process](#pull-request-process)
- [Issue Guidelines](#issue-guidelines)
- [Testing Guidelines](#testing-guidelines)

## Code of Conduct

### Our Pledge

We are committed to providing a welcoming and inspiring community for all. Please be respectful and constructive in all interactions.

### Expected Behavior

- Use welcoming and inclusive language
- Be respectful of differing viewpoints and experiences
- Gracefully accept constructive criticism
- Focus on what is best for the project and community
- Show empathy towards other community members

### Unacceptable Behavior

- Harassment, discriminatory jokes, or personal attacks
- Trolling, insulting/derogatory comments
- Public or private harassment
- Publishing others' private information without permission
- Other conduct which could reasonably be considered inappropriate

## Getting Started

### Prerequisites

Before contributing, ensure you have:

1. Read and understood the project [README](README.md)
2. Set up your [development environment](docs/setup.md)
3. Familiarized yourself with the [tools and dependencies](docs/tools.md)
4. Reviewed the [build and run instructions](docs/build.md)

### Setting Up Your Development Environment

1. **Fork the Repository**
   ```bash
   # Click the "Fork" button on GitHub
   ```

2. **Clone Your Fork**
   ```bash
   git clone https://github.com/YOUR-USERNAME/convenience-store-management-system.git
   cd convenience-store-management-system
   ```

3. **Add Upstream Remote**
   ```bash
   git remote add upstream https://github.com/olivvv-1009/convenience-store-management-system.git
   ```

4. **Install Dependencies**
   - Open the solution in Visual Studio
   - Restore NuGet packages
   - Build the solution to verify setup

## Development Workflow

### Agile/Scrum Process

This project follows the Agile Scrum methodology:

- **Sprints**: 2-week iterations
- **Planning**: Sprint planning at the start of each sprint
- **Daily Standups**: Brief team synchronization (if applicable)
- **Sprint Review**: Demo completed features at sprint end
- **Retrospective**: Reflect on the sprint and identify improvements

### Working on Issues

1. **Choose an Issue**
   - Check the [GitHub Issues](https://github.com/olivvv-1009/convenience-store-management-system/issues)
   - Look for issues tagged with `good first issue` or `help wanted`
   - Comment on the issue to claim it

2. **Create a Branch**
   ```bash
   git checkout -b feature/issue-number-short-description
   # Examples:
   # git checkout -b feature/23-add-login-page
   # git checkout -b bugfix/45-fix-inventory-calculation
   # git checkout -b docs/56-update-readme
   ```

3. **Make Changes**
   - Write clean, readable code
   - Follow the coding standards (see below)
   - Add comments where necessary
   - Update documentation if needed

4. **Commit Your Changes**
   - Make small, focused commits
   - Write clear commit messages (see Commit Guidelines)

5. **Push to Your Fork**
   ```bash
   git push origin feature/issue-number-short-description
   ```

6. **Create a Pull Request**
   - Go to GitHub and create a PR from your fork
   - Fill in the PR template
   - Link related issues

### Keeping Your Fork Updated

```bash
# Fetch latest changes from upstream
git fetch upstream

# Switch to main branch
git checkout main

# Merge upstream changes
git merge upstream/main

# Push to your fork
git push origin main
```

## Coding Standards

### C# Coding Conventions

Follow the [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions):

#### Naming Conventions

```csharp
// PascalCase for classes, methods, properties, and public fields
public class ProductManager { }
public void CalculateTotal() { }
public string ProductName { get; set; }

// camelCase for local variables and private fields
private string userName;
private int totalCount;

// Prefix interfaces with 'I'
public interface IProductRepository { }

// Use meaningful, descriptive names
// Good
public decimal CalculateTotalPrice(List<Product> products)

// Bad
public decimal Calc(List<Product> p)
```

#### Code Organization

```csharp
// Order of elements in a class:
// 1. Fields (private, then public)
// 2. Constructors
// 3. Properties
// 4. Methods (public, then private)
// 5. Events

public class Product
{
    // Fields
    private int _id;
    private string _name;

    // Constructors
    public Product(int id, string name)
    {
        _id = id;
        _name = name;
    }

    // Properties
    public int Id => _id;
    public string Name => _name;

    // Methods
    public void UpdateName(string newName)
    {
        _name = newName;
    }
}
```

#### Formatting

- Use 4 spaces for indentation (configured in `.editorconfig`)
- Place opening braces on new line (Allman style)
- Use single blank line to separate logical sections
- Limit line length to 120 characters when possible

```csharp
// Good formatting
public void ProcessOrder(Order order)
{
    if (order == null)
    {
        throw new ArgumentNullException(nameof(order));
    }

    ValidateOrder(order);
    CalculateTotal(order);
    SaveOrder(order);
}
```

#### Comments

```csharp
// Use XML documentation comments for public APIs
/// <summary>
/// Calculates the total price including tax.
/// </summary>
/// <param name="subtotal">The subtotal before tax</param>
/// <param name="taxRate">The tax rate as a decimal (e.g., 0.10 for 10%)</param>
/// <returns>The total price including tax</returns>
public decimal CalculateTotalWithTax(decimal subtotal, decimal taxRate)
{
    return subtotal * (1 + taxRate);
}

// Use inline comments sparingly, only when necessary
// Calculate discount based on customer tier
decimal discount = CalculateDiscountForTier(customer.Tier);
```

### Database Conventions

- Use PascalCase for table names (e.g., `Products`, `Customers`)
- Use PascalCase for column names (e.g., `ProductId`, `FirstName`)
- Always define primary keys
- Use foreign key constraints
- Add indexes on frequently queried columns

### SQL Conventions

```sql
-- Use UPPERCASE for SQL keywords
SELECT ProductId, ProductName, Price
FROM Products
WHERE CategoryId = 1
ORDER BY ProductName;

-- Use meaningful aliases
SELECT p.ProductName, c.CategoryName
FROM Products p
INNER JOIN Categories c ON p.CategoryId = c.CategoryId;
```

## Commit Guidelines

### Commit Message Format

```
<type>(<scope>): <subject>

<body>

<footer>
```

#### Type

- **feat**: New feature
- **fix**: Bug fix
- **docs**: Documentation changes
- **style**: Code style changes (formatting, no code change)
- **refactor**: Code refactoring
- **test**: Adding or updating tests
- **chore**: Maintenance tasks

#### Examples

```
feat(auth): add login functionality

Implement user authentication with username and password.
Includes password hashing and session management.

Closes #23

---

fix(inventory): correct stock calculation

Fixed issue where stock was incorrectly decremented twice
during sales transaction.

Fixes #45

---

docs(readme): update installation instructions

Added section on database setup and configuration.
```

### Commit Best Practices

- Keep commits small and focused
- Commit early and often
- Write meaningful commit messages
- Reference issue numbers when applicable
- Don't commit commented-out code
- Don't commit generated files or binaries

## Pull Request Process

### Before Submitting

1. **Update Your Branch**
   ```bash
   git fetch upstream
   git rebase upstream/main
   ```

2. **Run Tests**
   - Ensure all tests pass
   - Add tests for new features

3. **Check Code Quality**
   - Build succeeds without warnings
   - Code follows style guidelines
   - No commented-out code

4. **Update Documentation**
   - Update README if needed
   - Add XML comments for public APIs
   - Update relevant documentation files

### PR Template

When creating a PR, include:

```markdown
## Description
Brief description of changes

## Related Issue
Closes #issue-number

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Breaking change
- [ ] Documentation update

## Testing
Describe testing done

## Screenshots (if applicable)
Add screenshots for UI changes

## Checklist
- [ ] Code follows style guidelines
- [ ] Self-review completed
- [ ] Comments added where needed
- [ ] Documentation updated
- [ ] Tests added/updated
- [ ] All tests passing
- [ ] No merge conflicts
```

### PR Review Process

1. **Submit PR**: Create PR with clear description
2. **Automated Checks**: Wait for CI builds to pass (if configured)
3. **Code Review**: Team members review your code
4. **Address Feedback**: Make requested changes
5. **Approval**: Get approval from reviewers
6. **Merge**: Maintainer will merge the PR

### Review Guidelines

When reviewing PRs:

- Be respectful and constructive
- Ask questions rather than making demands
- Suggest alternatives with explanations
- Approve when satisfied with changes
- Test the changes locally if needed

## Issue Guidelines

### Creating Issues

Use issue templates when available:

- **Bug Report**: For reporting bugs
- **Feature Request**: For suggesting new features
- **Documentation**: For documentation improvements

### Issue Labels

- `bug`: Something isn't working
- `enhancement`: New feature or request
- `documentation`: Documentation improvements
- `good first issue`: Good for newcomers
- `help wanted`: Extra attention needed
- `sprint-X`: Assigned to specific sprint

## Testing Guidelines

### Unit Tests

```csharp
[TestClass]
public class ProductServiceTests
{
    [TestMethod]
    public void CalculateTotal_WithValidProducts_ReturnsCorrectSum()
    {
        // Arrange
        var products = new List<Product>
        {
            new Product { Price = 10.00m },
            new Product { Price = 20.00m }
        };
        var service = new ProductService();

        // Act
        var total = service.CalculateTotal(products);

        // Assert
        Assert.AreEqual(30.00m, total);
    }
}
```

### Test Naming Convention

```
MethodName_Scenario_ExpectedBehavior
```

Examples:
- `AddProduct_WithValidData_ReturnsSuccess`
- `DeleteProduct_WithInvalidId_ThrowsException`
- `UpdateInventory_WithNegativeQuantity_ReturnsFalse`

### Test Coverage

- Aim for at least 70% code coverage
- Focus on critical business logic
- Test edge cases and error conditions
- Don't test framework code

## Questions?

If you have questions:

1. Check existing documentation
2. Search closed issues for similar questions
3. Ask in issue comments
4. Create a new issue with the `question` label

## Recognition

Contributors will be recognized in:

- README.md contributors section
- Release notes
- Project documentation

Thank you for contributing to the Convenience Store Management System! 🎉
