# Use Cases

This document describes the main use cases for the Convenience Store Management System.

---

## Actors

### 1. Admin
System administrator with full access rights
- Manages users and system configuration
- Manages products and inventory
- Access to all reports
- Can perform all Staff operations

### 2. Staff (Cashier)
Regular employee with limited access
- Processes sales transactions
- Views product and inventory information
- Registers customers
- Access to limited reports

### 3. Customer (Implicit)
End customer making purchases
- Represented in the system through Customer records
- Interacts indirectly through Staff at POS

---

## Authentication & Authorization Use Cases

### UC-AUTH-01: Login
**Actor**: Admin, Staff  
**Precondition**: User has valid credentials  
**Main Flow**:
1. User enters username and password
2. System validates credentials
3. System creates user session
4. System displays dashboard based on user role

**Alternative Flow**:
- 3a. Invalid credentials: Display error, increment failed attempt counter
- 3b. Account locked: Display lockout message with remaining time

**Postcondition**: User is authenticated and authorized

---

### UC-AUTH-02: Logout
**Actor**: Admin, Staff  
**Precondition**: User is logged in  
**Main Flow**:
1. User clicks logout
2. System terminates session
3. System redirects to login screen

**Postcondition**: User session is terminated

---

### UC-AUTH-03: Reset Password
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin selects user to reset
2. Admin enters new password
3. System validates password complexity
4. System updates password (hashed)
5. System flags user for password change on next login

**Alternative Flow**:
- 3a. Password doesn't meet requirements: Display error, prompt for valid password

**Postcondition**: User password is reset

---

## Product Management Use Cases

### UC-PROD-01: Create Product
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to product management
2. Admin clicks "Add New Product"
3. Admin enters product details (name, barcode, category, price, description)
4. System validates barcode uniqueness
5. System creates product record
6. System displays success confirmation

**Alternative Flow**:
- 4a. Barcode already exists: Display error, prompt for different barcode
- 4b. Required field missing: Display validation error

**Postcondition**: New product is created and available in system

---

### UC-PROD-02: Search Product
**Actor**: Admin, Staff  
**Precondition**: User is logged in  
**Main Flow**:
1. User enters search criteria (name, barcode, or category)
2. System searches product database
3. System displays matching products
4. User selects product to view details

**Alternative Flow**:
- 2a. No matches found: Display "no results" message

**Postcondition**: Product information is displayed

---

### UC-PROD-03: Update Product
**Actor**: Admin  
**Precondition**: Admin is logged in, product exists  
**Main Flow**:
1. Admin searches and selects product
2. Admin modifies product details
3. System validates changes
4. System updates product record
5. System logs price change (if price modified)
6. System displays success confirmation

**Postcondition**: Product information is updated

---

### UC-PROD-04: Deactivate Product
**Actor**: Admin  
**Precondition**: Admin is logged in, product exists and is active  
**Main Flow**:
1. Admin searches and selects product
2. Admin clicks "Deactivate"
3. System confirms deactivation
4. System sets product status to inactive
5. System displays success confirmation

**Postcondition**: Product is deactivated and unavailable for sale

---

## Inventory Management Use Cases

### UC-INV-01: Receive Stock
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to stock receiving
2. Admin scans/selects product
3. Admin enters received quantity, supplier, purchase price
4. Admin enters expiration date (if perishable)
5. System updates stock quantity
6. System creates receiving record
7. System displays updated stock level

**Postcondition**: Stock is updated, receiving is recorded

---

### UC-INV-02: Adjust Inventory
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to inventory adjustment
2. Admin selects product
3. Admin enters adjustment quantity and reason
4. System validates adjustment
5. System updates stock quantity
6. System logs adjustment with user, timestamp, reason
7. System displays updated stock level

**Alternative Flow**:
- 4a. Adjustment would result in negative stock: Display error

**Postcondition**: Inventory is adjusted and logged

---

### UC-INV-03: View Low Stock Alert
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin views dashboard or navigates to alerts
2. System displays products below minimum threshold
3. Admin reviews low stock items
4. Admin takes action (create purchase order, adjust threshold)

**Postcondition**: Low stock items are reviewed

---

### UC-INV-04: View Expiration Alert
**Actor**: Admin  
**Precondition**: Admin is logged in, perishable products exist  
**Main Flow**:
1. Admin views dashboard or navigates to alerts
2. System displays products expiring within threshold
3. Admin reviews expiring items
4. Admin takes action (create promotion, adjust price, remove stock)

**Postcondition**: Expiring items are reviewed

---

## Point of Sale Use Cases

### UC-POS-01: Process Sale
**Actor**: Staff  
**Precondition**: Staff is logged in, products are available  
**Main Flow**:
1. Staff creates new invoice
2. Staff scans/selects products and enters quantities
3. System validates stock availability
4. System adds items to invoice
5. Staff applies customer (optional)
6. System applies eligible promotions automatically
7. Staff enters payment details
8. System validates payment amount
9. System completes transaction
10. System deducts inventory
11. System updates customer points (if member)
12. System prints receipt
13. System displays success confirmation

**Alternative Flow**:
- 3a. Insufficient stock: Display error, prevent adding item
- 8a. Insufficient payment: Prompt for additional payment
- 9a. Transaction fails: Rollback inventory changes

**Postcondition**: Sale is completed, inventory updated, receipt printed

---

### UC-POS-02: Apply Discount Voucher
**Actor**: Staff  
**Precondition**: Staff is processing sale, voucher exists  
**Main Flow**:
1. Staff enters voucher code during checkout
2. System validates voucher (active, not expired, usage limit)
3. System applies discount to invoice
4. System displays updated total
5. System marks voucher as used (on transaction completion)

**Alternative Flow**:
- 2a. Invalid voucher: Display error message
- 2b. Voucher expired: Display error message
- 2c. Usage limit exceeded: Display error message

**Postcondition**: Discount applied to invoice

---

### UC-POS-03: Hold Transaction
**Actor**: Staff  
**Precondition**: Staff is creating invoice  
**Main Flow**:
1. Staff clicks "Hold Transaction"
2. Staff enters customer reference (optional)
3. System saves invoice as pending
4. System generates hold ID
5. System displays hold confirmation

**Postcondition**: Transaction is held for later completion

---

### UC-POS-04: Retrieve Held Transaction
**Actor**: Staff  
**Precondition**: Held transaction exists  
**Main Flow**:
1. Staff navigates to held transactions
2. Staff selects transaction to retrieve
3. System loads invoice details
4. Staff continues with transaction

**Postcondition**: Held transaction is resumed

---

### UC-POS-05: Cancel Transaction
**Actor**: Staff  
**Precondition**: Transaction is in progress, not yet completed  
**Main Flow**:
1. Staff clicks "Cancel"
2. System confirms cancellation
3. System voids invoice
4. System returns to new transaction screen

**Alternative Flow**:
- For completed transactions: Requires supervisor approval and creates return/refund

**Postcondition**: Transaction is cancelled

---

## Promotions & Discounts Use Cases

### UC-PROMO-01: Create Promotion
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to promotion management
2. Admin clicks "Create Promotion"
3. Admin enters promotion details (name, type, value, dates, conditions)
4. System validates promotion rules
5. System creates promotion record
6. System displays success confirmation

**Postcondition**: New promotion is created

---

### UC-PROMO-02: Activate/Deactivate Promotion
**Actor**: Admin  
**Precondition**: Admin is logged in, promotion exists  
**Main Flow**:
1. Admin selects promotion
2. Admin toggles activation status
3. System updates promotion status
4. System displays confirmation

**Postcondition**: Promotion status is updated

---

### UC-PROMO-03: Generate Voucher
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to voucher management
2. Admin clicks "Create Voucher"
3. Admin enters voucher details (code, value, usage limit, expiration)
4. System validates voucher code uniqueness
5. System creates voucher
6. System displays voucher code

**Alternative Flow**:
- 4a. Voucher code exists: Display error, prompt for different code

**Postcondition**: Voucher is created and ready for use

---

## Customer Membership Use Cases

### UC-CUST-01: Register Customer
**Actor**: Staff  
**Precondition**: Staff is logged in  
**Main Flow**:
1. Staff navigates to customer registration
2. Staff enters customer details (name, phone, email, DOB)
3. System validates phone number uniqueness
4. System generates membership number
5. System creates customer record with Bronze tier
6. System displays membership details

**Alternative Flow**:
- 3a. Phone number exists: Display error or load existing customer

**Postcondition**: Customer is registered with membership

---

### UC-CUST-02: Lookup Customer
**Actor**: Staff  
**Precondition**: Staff is logged in  
**Main Flow**:
1. Staff enters search criteria (phone, membership number, or name)
2. System searches customer database
3. System displays matching customers
4. Staff selects customer
5. System displays customer details (name, tier, points balance)

**Alternative Flow**:
- 2a. No matches: Display "customer not found" message

**Postcondition**: Customer information is displayed

---

### UC-CUST-03: Redeem Points
**Actor**: Staff  
**Precondition**: Staff is processing sale, customer has sufficient points  
**Main Flow**:
1. Staff adds customer to invoice
2. Staff enters points to redeem
3. System validates redemption rules (minimum, maximum)
4. System calculates discount
5. System applies discount to invoice
6. System deducts points on transaction completion

**Alternative Flow**:
- 3a. Insufficient points: Display error
- 3b. Exceeds maximum: Display error, suggest maximum amount

**Postcondition**: Points redeemed, discount applied

---

### UC-CUST-04: View Customer Purchase History
**Actor**: Admin, Staff  
**Precondition**: User is logged in, customer exists  
**Main Flow**:
1. User searches and selects customer
2. User clicks "Purchase History"
3. System displays list of customer's invoices
4. User can view invoice details

**Postcondition**: Purchase history is displayed

---

## Reporting Use Cases

### UC-REPORT-01: Generate Daily Sales Report
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to reports
2. Admin selects "Daily Sales Report"
3. Admin selects date
4. System retrieves sales data for date
5. System calculates metrics (revenue, transactions, average)
6. System displays report
7. Admin exports to PDF/Excel (optional)

**Postcondition**: Daily sales report is generated

---

### UC-REPORT-02: Generate Monthly Sales Report
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to reports
2. Admin selects "Monthly Sales Report"
3. Admin selects month and year
4. System retrieves sales data for month
5. System calculates metrics and trends
6. System generates charts
7. System displays report
8. Admin exports to PDF/Excel (optional)

**Postcondition**: Monthly sales report is generated

---

### UC-REPORT-03: View Top Selling Products
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to reports
2. Admin selects "Top Selling Products"
3. Admin selects time period and limit
4. System retrieves product sales data
5. System ranks products by quantity/revenue
6. System displays top products
7. Admin exports to Excel (optional)

**Postcondition**: Top selling products report is displayed

---

### UC-REPORT-04: View Inventory Report
**Actor**: Admin  
**Precondition**: Admin is logged in  
**Main Flow**:
1. Admin navigates to reports
2. Admin selects "Current Inventory"
3. Admin applies filters (optional)
4. System retrieves current stock data
5. System calculates inventory value
6. System displays report
7. Admin exports to Excel (optional)

**Postcondition**: Inventory report is generated

---

### UC-REPORT-05: Search Invoice History
**Actor**: Admin, Staff  
**Precondition**: User is logged in  
**Main Flow**:
1. User navigates to invoice history
2. User enters search criteria (invoice number, date, customer)
3. System searches invoice database
4. System displays matching invoices
5. User selects invoice to view details
6. User can reprint invoice (optional)

**Alternative Flow**:
- 3a. No matches: Display "no results" message

**Postcondition**: Invoice history is displayed

---

## Use Case Diagram (Text Representation)

```
                    Convenience Store Management System
                              
┌─────────────────────────────────────────────────────────────────────┐
│                                                                     │
│  [Admin]                                                            │
│     │                                                               │
│     ├──→ Login/Logout                                              │
│     ├──→ Manage Users                                              │
│     ├──→ Manage Products (Create, Update, Deactivate, Search)      │
│     ├──→ Manage Inventory (Receive, Adjust, View Alerts)           │
│     ├──→ Manage Promotions (Create, Activate, Deactivate)          │
│     ├──→ Generate Vouchers                                         │
│     ├──→ Register Customers                                        │
│     ├──→ Process Sales (POS)                                       │
│     ├──→ Generate Reports (All)                                    │
│     └──→ View Invoice History                                      │
│                                                                     │
│  [Staff]                                                            │
│     │                                                               │
│     ├──→ Login/Logout                                              │
│     ├──→ Search Products                                           │
│     ├──→ View Inventory                                            │
│     ├──→ Process Sales (POS)                                       │
│     │    ├──→ Scan Barcode                                         │
│     │    ├──→ Apply Voucher                                        │
│     │    ├──→ Apply Promotions (automatic)                         │
│     │    ├──→ Hold/Retrieve Transactions                           │
│     │    └──→ Cancel Transaction                                   │
│     ├──→ Register Customers                                        │
│     ├──→ Lookup Customers                                          │
│     ├──→ Redeem Points                                             │
│     └──→ View Own Sales History                                    │
│                                                                     │
│  [System]                                                           │
│     │                                                               │
│     ├──→ Validate Stock Availability                               │
│     ├──→ Update Inventory (on sale)                                │
│     ├──→ Calculate Totals                                          │
│     ├──→ Apply Promotions (automatic)                              │
│     ├──→ Award Loyalty Points                                      │
│     ├──→ Generate Alerts (Low Stock, Expiration)                   │
│     ├──→ Print Receipt                                             │
│     └──→ Log Audit Trail                                           │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
```

---

## Use Case Relationships

### Include Relationships
- **Process Sale** includes:
  - Validate Stock Availability
  - Calculate Totals
  - Update Inventory
  - Print Receipt
  
- **Apply Promotion** includes:
  - Validate Promotion Rules
  - Calculate Discount

### Extend Relationships
- **Process Sale** extends to:
  - Apply Voucher (optional)
  - Redeem Points (optional)
  - Register New Customer (optional)

---

## Use Case Priority

### Critical (Must Have)
- UC-AUTH-01: Login
- UC-PROD-01, 02, 03: Product Management
- UC-INV-01, 02: Inventory Management
- UC-POS-01: Process Sale
- UC-REPORT-01: Daily Sales Report

### High Priority (Should Have)
- UC-AUTH-03: Reset Password
- UC-INV-03, 04: View Alerts
- UC-POS-02, 03, 04: Voucher, Hold, Retrieve
- UC-CUST-01, 02: Customer Registration, Lookup
- UC-REPORT-02, 03, 04: Monthly Sales, Top Products, Inventory

### Medium Priority (Could Have)
- UC-PROMO-01, 02, 03: Promotion Management
- UC-CUST-03, 04: Redeem Points, History
- UC-REPORT-05: Invoice History

---

## Traceability Matrix

| Use Case | Functional Requirements | Priority |
|----------|------------------------|----------|
| UC-AUTH-01 | FR-AUTH-001, FR-AUTH-002 | Critical |
| UC-AUTH-02 | FR-AUTH-003 | Critical |
| UC-AUTH-03 | FR-AUTH-007 | High |
| UC-PROD-01 | FR-PROD-001 | Critical |
| UC-PROD-02 | FR-PROD-002, FR-PROD-007 | Critical |
| UC-PROD-03 | FR-PROD-003 | Critical |
| UC-PROD-04 | FR-PROD-004 | High |
| UC-INV-01 | FR-INV-004 | Critical |
| UC-INV-02 | FR-INV-003 | Critical |
| UC-INV-03 | FR-INV-005, FR-INV-006 | High |
| UC-INV-04 | FR-INV-008, FR-INV-009 | High |
| UC-POS-01 | FR-POS-001 to FR-POS-008 | Critical |
| UC-POS-02 | FR-PROMO-005 | High |
| UC-POS-03 | FR-POS-010 | Medium |
| UC-POS-04 | FR-POS-010 | Medium |
| UC-POS-05 | FR-POS-009 | High |
| UC-PROMO-01 | FR-PROMO-001, FR-PROMO-002 | Medium |
| UC-PROMO-02 | FR-PROMO-003 | Medium |
| UC-PROMO-03 | FR-PROMO-004 | Medium |
| UC-CUST-01 | FR-CUST-001 | High |
| UC-CUST-02 | FR-CUST-007 | High |
| UC-CUST-03 | FR-CUST-004 | Medium |
| UC-CUST-04 | FR-CUST-001, FR-CUST-002 | Medium |
| UC-REPORT-01 | FR-REPORT-001 | Critical |
| UC-REPORT-02 | FR-REPORT-002 | High |
| UC-REPORT-03 | FR-REPORT-004 | High |
| UC-REPORT-04 | FR-REPORT-006 | High |
| UC-REPORT-05 | FR-REPORT-010 | Medium |

---

**Document Version**: 1.0  
**Last Updated**: 2026-01-19  
**Status**: ✅ Complete
