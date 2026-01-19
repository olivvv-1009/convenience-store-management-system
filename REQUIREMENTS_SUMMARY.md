# Functional Requirements Summary

This document provides a high-level summary of the functional requirements for the Convenience Store Management System. For detailed requirements, see [FUNCTIONAL_REQUIREMENTS.md](FUNCTIONAL_REQUIREMENTS.md).

---

## Requirements Overview

| Module | Total Requirements | Priority |
|--------|-------------------|----------|
| Authentication & Authorization | 7 | High |
| Product Management | 7 | High |
| Inventory Management | 9 | High |
| Point of Sale (POS) | 10 | Critical |
| Promotions & Discounts | 6 | Medium |
| Customer Membership | 7 | Medium |
| Reporting | 11 | High |
| **TOTAL** | **57** | - |

---

## 1. Authentication & Authorization (7 Requirements)

### Core Features
- User login/logout with session management
- Role-based access control (Admin/Staff)
- Password complexity enforcement
- Password reset capability
- Account lockout after failed attempts

### User Roles & Permissions

| Feature | Admin | Staff |
|---------|-------|-------|
| User Management | ✓ | ✗ |
| All Reports | ✓ | ✗ |
| System Configuration | ✓ | ✗ |
| Product Management | ✓ | ✗ |
| Inventory Adjustments | ✓ | ✗ |
| Process Sales (POS) | ✓ | ✓ |
| View Products | ✓ | ✓ |
| Customer Management | ✓ | ✓ |
| Apply Promotions | ✓ | ✓ |
| Own Sales Reports | ✓ | ✓ |

---

## 2. Product Management (7 Requirements)

### Core Features
- Create, Read, Update, Deactivate products (CRUD)
- Product categorization (9 categories)
- Barcode support and scanning
- Product search (by name, barcode, category)
- Unique barcode validation

### Product Categories
1. Beverages
2. Snacks
3. Groceries
4. Personal Care
5. Household
6. Frozen Foods
7. Dairy
8. Bakery
9. Others

### Key Business Rules
- Barcode must be unique across all products
- Products are deactivated, not deleted
- Price changes are logged
- Only active products can be sold

---

## 3. Inventory Management (9 Requirements)

### Core Features
- Real-time stock tracking
- Automatic inventory deduction on sales
- Manual stock adjustments with reasons
- Stock receiving from suppliers
- Low stock alerts and reports
- Expiration date tracking (FIFO)
- Near-expiration alerts
- Inventory movement logging

### Stock Adjustment Reasons
- Damaged
- Expired
- Lost
- Found
- Supplier Return
- Customer Return

### Alert Thresholds
- **Low Stock**: When quantity falls below configurable threshold (default: 10 units)
- **Near Expiration**: 7 days before expiration date

---

## 4. Point of Sale (POS) - 10 Requirements

### Core Features
- Invoice creation with multiple line items
- Barcode scanning support
- Multiple payment methods (Cash, Credit, Debit, E-Wallet)
- Automatic inventory deduction
- Receipt printing (thermal printer support)
- Invoice hold and retrieval
- Transaction cancellation

### Invoice Calculation Flow
```
Subtotal = Sum of (Quantity × Unit Price) for all items
Discount = Applied promotions + vouchers + membership
Tax = Subtotal × Tax Rate (if applicable)
Total = Subtotal - Discount + Tax
```

### Payment Methods
1. Cash (with change calculation)
2. Credit Card
3. Debit Card
4. E-Wallet

### Key Features
- Real-time stock availability check
- Automatic promotion application
- Atomic transactions (sale + inventory update)
- Split payment support
- Hold transactions for later completion

---

## 5. Promotions & Discounts (6 Requirements)

### Core Features
- Create and manage promotions
- Multiple promotion types
- Condition-based promotion rules
- Discount voucher codes
- Automatic promotion application at checkout
- Best discount logic

### Promotion Types
1. **Percentage Discount**: X% off (e.g., 10% off)
2. **Fixed Amount**: $X off (e.g., $5 off)
3. **Buy X Get Y**: Buy X items, get Y free
4. **Bundle Discount**: Multiple items for fixed price (e.g., 3 for $10)

### Promotion Conditions
- Minimum purchase amount
- Specific products or categories
- Customer membership tier
- Quantity requirements
- Time restrictions (e.g., happy hour)

### Voucher Features
- Unique voucher codes
- Single-use or multi-use options
- Usage tracking
- Expiration dates
- One voucher per transaction

---

## 6. Customer Membership (7 Requirements)

### Core Features
- Customer registration and profile management
- Loyalty points earning and redemption
- Three-tier membership system
- Tier-based benefits
- Customer lookup (phone, membership number, name)
- Purchase history tracking

### Membership Tiers

| Tier | Points Required | Earning Rate | Benefits |
|------|----------------|--------------|----------|
| Bronze | 0-999 | 1.0x | Standard |
| Silver | 1,000-4,999 | 1.2x | Enhanced points, exclusive discounts |
| Gold | 5,000+ | 1.5x | Best points rate, birthday rewards |

### Loyalty Points System
- **Earning**: 1 point per $1 spent (configurable, multiplied by tier rate)
- **Redemption**: 100 points = $1 discount
- **Minimum Redemption**: 100 points
- **Maximum Redemption**: 50% of invoice total

### Key Business Rules
- Phone number must be unique
- Tier upgrades are automatic based on lifetime points
- Points awarded on non-discounted amount
- Points balance updated immediately

---

## 7. Reporting (11 Requirements)

### Sales Reports
1. **Daily Sales Report**
   - Total revenue, transaction count
   - Average transaction value
   - Payment method breakdown
   - Top selling products
   - Hourly distribution

2. **Monthly Sales Report**
   - Monthly revenue with trend
   - Category-wise breakdown
   - Top 10 products
   - Comparative analysis

3. **Yearly Sales Report**
   - Annual revenue
   - Monthly trends
   - Year-over-year growth
   - Seasonal patterns

### Product Reports
4. **Top-Selling Products**
   - Ranking by quantity and revenue
   - Time period selector
   - Category filtering

5. **Slow-Moving Products**
   - Products with low sales velocity
   - Stock value analysis
   - Days since last sale

### Inventory Reports
6. **Current Inventory**
   - All products with stock levels
   - Stock value calculation
   - Category breakdown

7. **Inventory Movement**
   - Received, sold, adjusted
   - Period selection
   - Balance tracking

### Customer Reports
8. **Customer Activity**
   - Total and new customers
   - Active customer count
   - Retention metrics

9. **Loyalty Points**
   - Points issued and redeemed
   - Outstanding points liability
   - Top earners

### Transaction Reports
10. **Invoice History**
    - Search by multiple criteria
    - Full detail view
    - Reprint capability

### Access Control
11. **Report Permissions**
    - Role-based access restrictions
    - Audit logging

---

## Non-Functional Requirements Summary

### Performance Targets
- POS transaction processing: < 2 seconds
- Product search: < 1 second
- Report generation: < 10 seconds

### Security Requirements
- Password encryption (bcrypt/PBKDF2)
- Session timeout: 8 hours
- Account lockout: 3 failed attempts
- Comprehensive audit logging

### Data Integrity
- Atomic transactions
- Daily backups
- Power failure protection
- Concurrent operation support

---

## Implementation Priority

### Phase 1 - Critical (Sprint 1-2)
- Authentication & Authorization
- Product Management (basic CRUD)
- Inventory Management (stock tracking)

### Phase 2 - Core Operations (Sprint 3)
- Point of Sale (POS)
- Basic reporting (daily sales)

### Phase 3 - Customer Engagement (Sprint 4)
- Customer Membership
- Promotions & Discounts
- Loyalty Points

### Phase 4 - Analytics (Sprint 5)
- Comprehensive Reporting
- Advanced Analytics
- System Testing & Finalization

---

## Technical Architecture

### System Architecture
- **Pattern**: Model-View-Controller (MVC)
- **Platform**: .NET Framework (WinForms)
- **Database**: Microsoft SQL Server
- **Deployment**: Windows Desktop Application

### Database Design Principles
- Normalization: 3NF minimum
- Referential integrity enforced
- Audit trails for critical operations
- Optimized indexes for performance

### Integration Points
- Barcode scanners (USB/Serial)
- Thermal receipt printers (ESC/POS)
- Local file system (reports export)

---

## Glossary

| Term | Definition |
|------|------------|
| **POS** | Point of Sale - the system interface where sales transactions are processed |
| **SKU** | Stock Keeping Unit - unique identifier for a product |
| **FIFO** | First In, First Out - inventory method for perishables |
| **Invoice** | Sales receipt/bill for a transaction |
| **Cashier** | Staff member operating the POS |
| **Member** | Registered customer with loyalty account |
| **Voucher** | Discount code that can be applied to purchase |
| **Tier** | Customer membership level (Bronze/Silver/Gold) |
| **Stock Adjustment** | Manual change to inventory quantity |
| **Expiration Alert** | Notification for products nearing expiry |

---

## Change Log

| Version | Date | Author | Changes |
|---------|------|--------|---------|
| 1.0 | 2026-01-19 | System Analyst | Initial functional requirements analysis |

---

## Document References

- [Detailed Functional Requirements](FUNCTIONAL_REQUIREMENTS.md)
- [Project README](README.md)

---

**Document Status**: ✅ Complete  
**Review Status**: ⏳ Pending Review  
**Approval Status**: ⏳ Pending Approval
