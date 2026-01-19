# Functional Requirements Analysis

## 1. Authentication & Authorization

### 1.1 User Login
**FR-AUTH-001**: The system shall allow users to log in with a username and password.
- **Input**: Username, Password
- **Output**: Authentication token/session
- **Business Rules**:
  - Username is case-insensitive
  - Password must be encrypted in storage
  - Maximum 3 failed login attempts before temporary lockout (15 minutes)
  - Session timeout after 8 hours of inactivity

**FR-AUTH-002**: The system shall validate user credentials against the database.
- **Input**: User credentials
- **Output**: Authentication success/failure
- **Business Rules**:
  - Check username exists
  - Verify password hash matches
  - Log all login attempts (success and failure)

### 1.2 User Logout
**FR-AUTH-003**: The system shall allow authenticated users to log out.
- **Input**: Logout request
- **Output**: Session termination confirmation
- **Business Rules**:
  - Clear session data
  - Log logout event with timestamp
  - Redirect to login screen

### 1.3 Role-Based Access Control
**FR-AUTH-004**: The system shall support two user roles: Admin and Staff.
- **Roles**:
  - **Admin**: Full system access including user management, reports, system configuration
  - **Staff**: Limited access to POS, inventory viewing, customer management

**FR-AUTH-005**: The system shall restrict feature access based on user role.
- **Admin Permissions**:
  - Manage users (create, update, delete)
  - Access all reports
  - Configure system settings
  - Manage products and inventory
  - Process sales
  - Manage promotions and customers
  
- **Staff Permissions**:
  - Process sales (POS)
  - View product information
  - View inventory levels
  - Register customers
  - Apply promotions
  - View limited reports (own sales only)

### 1.4 Password Management
**FR-AUTH-006**: The system shall enforce password complexity requirements.
- **Requirements**:
  - Minimum 8 characters
  - At least one uppercase letter
  - At least one lowercase letter
  - At least one digit
  - At least one special character

**FR-AUTH-007**: Admins shall be able to reset user passwords.
- **Input**: User ID, New password
- **Output**: Password reset confirmation
- **Business Rules**:
  - Only admins can reset passwords
  - User must change password on next login after reset
  - Log password reset events

---

## 2. Product Management

### 2.1 Product CRUD Operations

**FR-PROD-001**: The system shall allow authorized users to create new products.
- **Input**: Product name, barcode, category, unit price, description, supplier
- **Output**: Product ID, creation confirmation
- **Business Rules**:
  - Barcode must be unique
  - Product name is required
  - Unit price must be positive
  - Category must exist in the system
  - Only Admin users can create products

**FR-PROD-002**: The system shall allow users to view product details.
- **Input**: Product ID or barcode
- **Output**: Complete product information
- **Business Rules**:
  - Display current stock level
  - Show product status (active/inactive)
  - Include pricing and category information

**FR-PROD-003**: The system shall allow authorized users to update product information.
- **Input**: Product ID, updated fields
- **Output**: Update confirmation
- **Business Rules**:
  - Cannot change barcode if product has transaction history
  - Price changes should be logged with timestamp
  - Only Admin users can update products

**FR-PROD-004**: The system shall allow authorized users to deactivate products.
- **Input**: Product ID
- **Output**: Deactivation confirmation
- **Business Rules**:
  - Products are deactivated, not deleted
  - Deactivated products cannot be sold
  - Historical data remains accessible
  - Only Admin users can deactivate products

### 2.2 Product Categories

**FR-PROD-005**: The system shall support product categorization.
- **Categories**: Beverages, Snacks, Groceries, Personal Care, Household, Frozen Foods, Dairy, Bakery, Others
- **Business Rules**:
  - Each product must belong to exactly one category
  - Categories can be managed by Admin users
  - Category-based filtering and reporting

### 2.3 Barcode Management

**FR-PROD-006**: The system shall support barcode scanning for product lookup.
- **Input**: Barcode (manual entry or scanner)
- **Output**: Product details
- **Business Rules**:
  - Support common barcode formats (EAN-13, UPC-A, Code-128)
  - Fast lookup by barcode index
  - Handle barcode not found scenarios

### 2.4 Product Search

**FR-PROD-007**: The system shall provide product search functionality.
- **Search Criteria**: Product name, barcode, category
- **Output**: List of matching products
- **Business Rules**:
  - Partial name matching supported
  - Case-insensitive search
  - Search results sorted by relevance

---

## 3. Inventory Management

### 3.1 Stock Tracking

**FR-INV-001**: The system shall track current stock levels for all products.
- **Data**: Product ID, quantity on hand, unit of measure
- **Business Rules**:
  - Stock quantity must be non-negative
  - Real-time updates when sales occur
  - Support for stock adjustments

**FR-INV-002**: The system shall automatically deduct inventory when sales are processed.
- **Trigger**: Sale transaction completion
- **Action**: Reduce stock by sold quantity
- **Business Rules**:
  - Atomic transaction (sale and inventory update together)
  - Prevent overselling (check stock availability)
  - Log inventory movements

### 3.2 Stock Adjustments

**FR-INV-003**: The system shall allow authorized users to perform manual stock adjustments.
- **Input**: Product ID, adjustment quantity, reason, reference
- **Output**: Updated stock level
- **Business Rules**:
  - Reasons: Damaged, Expired, Lost, Found, Supplier Return, Customer Return
  - Only Admin users can adjust inventory
  - All adjustments must be logged with user, timestamp, and reason

### 3.3 Stock Receiving

**FR-INV-004**: The system shall support stock receiving from suppliers.
- **Input**: Product ID, received quantity, supplier, purchase price, expiration date (if applicable)
- **Output**: Updated stock level, receipt record
- **Business Rules**:
  - Update stock on hand
  - Record purchase price for cost tracking
  - Track expiration dates for perishable items
  - Generate receiving report

### 3.4 Low Stock Alerts

**FR-INV-005**: The system shall generate alerts for low stock levels.
- **Input**: Minimum stock threshold per product
- **Output**: Low stock alert list
- **Business Rules**:
  - Admin can set minimum threshold per product
  - Default threshold: 10 units
  - Alert displayed on dashboard
  - Include reorder recommendations

**FR-INV-006**: The system shall provide a low stock report.
- **Output**: List of products below threshold
- **Information**: Product name, current stock, minimum threshold, suggested reorder quantity
- **Business Rules**:
  - Updated in real-time
  - Sortable by urgency (lowest stock first)

### 3.5 Expiration Date Management

**FR-INV-007**: The system shall track expiration dates for perishable products.
- **Input**: Product batch, expiration date
- **Output**: Expiration tracking record
- **Business Rules**:
  - FIFO (First In, First Out) recommended for sales
  - Support multiple batches with different expiration dates

**FR-INV-008**: The system shall generate alerts for products nearing expiration.
- **Threshold**: 7 days before expiration
- **Output**: Near-expiration alert list
- **Business Rules**:
  - Alert displayed on dashboard
  - Include product name, batch, quantity, expiration date
  - Suggest markdown/promotion actions

**FR-INV-009**: The system shall provide an expiring products report.
- **Output**: List of products expiring within specified period
- **Business Rules**:
  - Default period: 30 days
  - Sortable by expiration date
  - Include quantity and current value

---

## 4. Point of Sale (POS)

### 4.1 Invoice Creation

**FR-POS-001**: The system shall allow staff to create new sales invoices.
- **Input**: Customer (optional), products (barcode/search), quantities
- **Output**: Invoice with line items, total amount
- **Business Rules**:
  - Each invoice has unique invoice number
  - Invoice date and time automatically recorded
  - Cashier/staff user recorded on invoice

**FR-POS-002**: The system shall support adding multiple products to an invoice.
- **Input**: Product barcode/ID, quantity
- **Output**: Updated invoice line items
- **Business Rules**:
  - Validate product exists and is active
  - Check stock availability before adding
  - Calculate line total (quantity × unit price)
  - Support quantity modification

**FR-POS-003**: The system shall calculate invoice totals automatically.
- **Calculation**:
  - Subtotal = Sum of all line items
  - Discount amount (if applicable)
  - Tax (if applicable)
  - Total = Subtotal - Discount + Tax
- **Business Rules**:
  - Real-time calculation as items added/removed
  - Display breakdown clearly

### 4.2 Barcode Scanning

**FR-POS-004**: The system shall support barcode scanning during checkout.
- **Input**: Barcode from scanner or manual entry
- **Output**: Product added to invoice
- **Business Rules**:
  - Fast lookup and add to cart
  - Default quantity: 1 (adjustable)
  - Audio/visual feedback on successful scan

### 4.3 Payment Processing

**FR-POS-005**: The system shall support multiple payment methods.
- **Payment Methods**: Cash, Credit Card, Debit Card, E-Wallet
- **Input**: Payment method, amount tendered
- **Output**: Payment confirmation, change (if cash)
- **Business Rules**:
  - For cash: calculate and display change
  - For card/e-wallet: record transaction reference
  - Support partial payments (split payment)

**FR-POS-006**: The system shall validate sufficient payment before completing sale.
- **Business Rules**:
  - Total payment ≥ invoice total
  - Prevent completion if underpaid
  - Allow overpayment for cash (return change)

### 4.4 Inventory Integration

**FR-POS-007**: The system shall automatically deduct inventory upon sale completion.
- **Trigger**: Payment confirmation and invoice finalization
- **Action**: Reduce stock for all invoice line items
- **Business Rules**:
  - Atomic transaction
  - Handle batch/expiration tracking (FIFO)
  - Rollback on failure

### 4.5 Invoice Printing

**FR-POS-008**: The system shall generate printable receipts.
- **Receipt Content**:
  - Store name and address
  - Invoice number and date/time
  - Cashier name
  - Line items (product, quantity, price, total)
  - Subtotal, discount, tax, grand total
  - Payment method and amount
  - Change (if applicable)
  - Customer name (if member)
  - Points earned (if member)
  - Thank you message
- **Business Rules**:
  - Option to print or skip
  - Support thermal printer format
  - Save receipt as PDF option

### 4.6 Transaction Management

**FR-POS-009**: The system shall allow cancellation of incomplete invoices.
- **Input**: Cancel request
- **Output**: Invoice voided, items returned to selection
- **Business Rules**:
  - Only before payment completion
  - Require supervisor approval for completed invoices

**FR-POS-010**: The system shall support invoice holds.
- **Input**: Hold request, customer reference
- **Output**: Invoice saved as pending
- **Business Rules**:
  - Temporarily save incomplete invoices
  - Retrieve and complete later
  - Hold expires after 24 hours

---

## 5. Promotions & Discounts

### 5.1 Promotion Management

**FR-PROMO-001**: The system shall allow Admins to create promotions.
- **Input**: Promotion name, type, value, start date, end date, conditions
- **Output**: Promotion ID, confirmation
- **Promotion Types**:
  - Percentage discount (e.g., 10% off)
  - Fixed amount discount (e.g., $5 off)
  - Buy X Get Y free
  - Bundle discount (e.g., 3 for $10)
- **Business Rules**:
  - Start date ≤ End date
  - Promotion must be activated to apply
  - Cannot overlap conflicting promotions on same product

**FR-PROMO-002**: The system shall allow Admins to define promotion conditions.
- **Conditions**:
  - Minimum purchase amount
  - Specific products or categories
  - Customer membership tier
  - Quantity requirements
  - Time restrictions (e.g., happy hour)
- **Business Rules**:
  - Multiple conditions can be combined (AND/OR logic)
  - Conditions validated at checkout

**FR-PROMO-003**: The system shall allow Admins to activate/deactivate promotions.
- **Input**: Promotion ID, status
- **Output**: Status update confirmation
- **Business Rules**:
  - Only active promotions apply at POS
  - Expired promotions automatically deactivate
  - Manual override available

### 5.2 Discount Vouchers

**FR-PROMO-004**: The system shall support discount voucher codes.
- **Input**: Voucher code, value, usage limit, expiration
- **Output**: Voucher created
- **Business Rules**:
  - Voucher codes must be unique
  - Single-use or multi-use vouchers
  - Track usage count
  - Validate expiration date

**FR-PROMO-005**: The system shall allow voucher application during checkout.
- **Input**: Voucher code
- **Output**: Discount applied to invoice
- **Business Rules**:
  - Validate voucher is active and not expired
  - Check usage limit not exceeded
  - Apply discount per voucher rules
  - Mark voucher as used
  - One voucher per transaction

### 5.3 Automatic Promotion Application

**FR-PROMO-006**: The system shall automatically apply eligible promotions at checkout.
- **Process**:
  1. Check all active promotions
  2. Match promotion conditions with cart items
  3. Calculate and apply best discount
  4. Display promotion applied
- **Business Rules**:
  - Best discount logic (highest savings for customer)
  - Customer can decline promotion if needed
  - Display savings on receipt

---

## 6. Customer Membership

### 6.1 Customer Registration

**FR-CUST-001**: The system shall allow registration of new customers.
- **Input**: Name, phone number, email (optional), date of birth (optional)
- **Output**: Customer ID/membership number
- **Business Rules**:
  - Phone number must be unique
  - Auto-generate membership number
  - Default membership tier: Bronze
  - Starting points: 0

**FR-CUST-002**: The system shall allow updating customer information.
- **Input**: Customer ID, updated fields
- **Output**: Update confirmation
- **Business Rules**:
  - Phone number must remain unique
  - Track update history
  - Staff and Admin can update

### 6.2 Loyalty Points System

**FR-CUST-003**: The system shall award loyalty points for purchases.
- **Calculation**: 1 point per $1 spent (configurable)
- **Trigger**: Invoice completion with customer ID
- **Business Rules**:
  - Points rounded to nearest integer
  - Points awarded only for non-discounted amount
  - Points balance updated immediately
  - Points transaction logged

**FR-CUST-004**: The system shall support points redemption.
- **Input**: Points to redeem
- **Output**: Discount amount applied
- **Conversion Rate**: 100 points = $1 discount (configurable)
- **Business Rules**:
  - Minimum redemption: 100 points
  - Maximum redemption: 50% of invoice total
  - Points deducted upon invoice completion
  - Reversible if invoice cancelled

### 6.3 Membership Tiers

**FR-CUST-005**: The system shall support membership tier system.
- **Tiers**:
  - Bronze: 0-999 points, 1x point earning rate
  - Silver: 1000-4999 points, 1.2x point earning rate
  - Gold: 5000+ points, 1.5x point earning rate
- **Business Rules**:
  - Tier automatically upgraded based on total lifetime points
  - Tier benefits apply immediately
  - Display tier status on customer profile

**FR-CUST-006**: The system shall apply tier-based benefits.
- **Benefits**:
  - Enhanced point earning rate
  - Exclusive discounts
  - Birthday rewards
  - Priority customer service
- **Business Rules**:
  - Benefits calculated automatically
  - Visible to customer and staff

### 6.4 Customer Lookup

**FR-CUST-007**: The system shall support customer lookup during checkout.
- **Search Methods**: Phone number, membership number, name
- **Output**: Customer details, points balance, tier
- **Business Rules**:
  - Fast lookup by phone/membership number
  - Display current points balance
  - Option to add customer to invoice

---

## 7. Reporting

### 7.1 Sales Reports

**FR-REPORT-001**: The system shall generate daily sales reports.
- **Content**:
  - Total revenue
  - Number of transactions
  - Average transaction value
  - Payment method breakdown
  - Top selling products (quantity and revenue)
  - Hourly sales distribution
- **Business Rules**:
  - Data for selected date
  - Generated on-demand or scheduled
  - Exportable to PDF/Excel

**FR-REPORT-002**: The system shall generate monthly sales reports.
- **Content**:
  - Total revenue and comparison to previous month
  - Number of transactions
  - Average transaction value
  - Daily revenue trend
  - Category-wise sales breakdown
  - Top 10 products
  - Payment method distribution
- **Business Rules**:
  - Data for selected month
  - Graphical representation (charts)
  - Exportable to PDF/Excel

**FR-REPORT-003**: The system shall generate yearly sales reports.
- **Content**:
  - Annual revenue
  - Monthly revenue trend
  - Year-over-year growth
  - Seasonal patterns
  - Category performance
  - Customer acquisition trends
- **Business Rules**:
  - Data for selected year
  - Comparative analysis with previous years
  - Exportable to PDF/Excel

### 7.2 Product Reports

**FR-REPORT-004**: The system shall generate top-selling products report.
- **Content**:
  - Product ranking by quantity sold
  - Product ranking by revenue
  - Time period selector (daily, weekly, monthly)
  - Category filter
- **Business Rules**:
  - Top 10, 20, or custom limit
  - Include revenue and quantity metrics
  - Sortable by different criteria

**FR-REPORT-005**: The system shall generate slow-moving products report.
- **Content**:
  - Products with low sales velocity
  - Current stock value of slow-moving items
  - Days since last sale
  - Recommendations for action
- **Business Rules**:
  - Configurable threshold (e.g., no sales in 30 days)
  - Include stock quantity and value

### 7.3 Inventory Reports

**FR-REPORT-006**: The system shall generate current inventory report.
- **Content**:
  - All products with current stock levels
  - Stock value (quantity × purchase price)
  - Category breakdown
  - Low stock indicators
- **Business Rules**:
  - Real-time data
  - Filterable by category, stock status
  - Total inventory value calculation
  - Exportable to Excel

**FR-REPORT-007**: The system shall generate inventory movement report.
- **Content**:
  - Stock received
  - Stock sold
  - Stock adjustments
  - Current balance
  - Period selector
- **Business Rules**:
  - Date range selection
  - Product or category filter
  - Show reasons for adjustments

### 7.4 Customer Reports

**FR-REPORT-008**: The system shall generate customer activity report.
- **Content**:
  - Total customers
  - New customer registrations
  - Active customers (purchased in period)
  - Customer retention rate
  - Average purchase per customer
- **Business Rules**:
  - Period selection
  - Tier-based segmentation

**FR-REPORT-009**: The system shall generate loyalty points report.
- **Content**:
  - Points issued
  - Points redeemed
  - Outstanding points liability
  - Top point earners
- **Business Rules**:
  - Period selection
  - Financial impact analysis

### 7.5 Invoice History

**FR-REPORT-010**: The system shall provide invoice history search.
- **Search Criteria**: Invoice number, date range, customer, cashier, payment method
- **Output**: List of matching invoices
- **Details**: Invoice number, date, customer, total, payment method, cashier
- **Business Rules**:
  - Sortable by any field
  - Drill-down to full invoice detail
  - Reprint invoice capability

### 7.6 Report Access Control

**FR-REPORT-011**: The system shall restrict report access based on user role.
- **Admin Access**: All reports
- **Staff Access**: 
  - Own sales history
  - Daily sales summary (view only)
  - Product lookup
- **Business Rules**:
  - Enforce role-based permissions
  - Log report access
  - Prevent unauthorized data export

---

## Non-Functional Requirements

### Performance
- **NFR-001**: The system shall process POS transactions within 2 seconds under normal load
- **NFR-002**: Product search shall return results within 1 second
- **NFR-003**: Report generation shall complete within 10 seconds for standard reports

### Security
- **NFR-004**: All passwords shall be encrypted using industry-standard hashing (bcrypt/PBKDF2)
- **NFR-005**: User sessions shall expire after 8 hours of inactivity
- **NFR-006**: System shall log all security-relevant events (login, logout, access violations)

### Usability
- **NFR-007**: The POS interface shall support keyboard shortcuts for common operations
- **NFR-008**: Error messages shall be clear and actionable
- **NFR-009**: The system shall support both mouse and keyboard navigation

### Reliability
- **NFR-010**: The system shall maintain data integrity during power failures
- **NFR-011**: Database backups shall be performed daily
- **NFR-012**: The system shall handle concurrent POS operations without data corruption

### Maintainability
- **NFR-013**: The system shall follow MVC architecture pattern
- **NFR-014**: Code shall include inline documentation for complex logic
- **NFR-015**: Database schema shall be normalized to 3NF minimum

---

## Assumptions and Constraints

### Assumptions
1. The system operates in a single-store environment
2. Internet connectivity is not required for core operations
3. Users have basic computer literacy
4. Barcode scanners are compatible with Windows
5. Thermal printers follow standard ESC/POS commands

### Constraints
1. Windows operating system only (.NET WinForms)
2. SQL Server database required
3. No integration with external payment gateways
4. No integration with external hardware beyond barcode scanners and printers
5. Offline operation only (no cloud synchronization)
6. Single language support (English or Vietnamese)

---

## Future Enhancements (Out of Scope for Current Version)

1. Multi-store support with central reporting
2. Online payment gateway integration
3. Mobile app for customer loyalty program
4. Advanced analytics and business intelligence
5. Supplier management and purchase order system
6. Employee attendance and payroll integration
7. Cloud backup and synchronization
8. API for third-party integrations
9. Advanced inventory forecasting with AI/ML
10. Customer-facing display for POS
