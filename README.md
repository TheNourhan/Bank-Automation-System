# Bank-Automation-System

## Overview
The Bank Automation System is a comprehensive C# application designed to manage various banking operations. It includes functionality for managing branches, customers, accounts, employees, permissions, and transfers. The system ensures data integrity and supports CRUD operations. It connects to a SQL Server database to perform operations and utilizes stored procedures for efficient data management and transactional integrity.

## Features
1. **Branch Management:**
   - Create, update, and delete branch information.
   - Track branch locations by governorate.
2. **Customer Management:**
   - Manage customer profiles including names, email, and phone numbers.
3. **Account Management:**
   - Open and close accounts.
   - Track account types, statuses (active/closed), balances, and creation/closure dates.
   - Associate accounts with specific branches and customers.
4. **Employee Management:**
   - Maintain employee records including names, usernames, roles, and email addresses.
   - Establish hierarchical relationships with managers assigned to branches.
5. **Permission Management:**
   - Define various permissions such as 'Make Statement', 'Transfers', 'Close Account', 'New Account', and 'Login'.
   - Assign permissions to employees based on their roles and responsibilities.
6. **Transfer Transactions:**
   - Record transfer details including source and destination accounts, amount, and transfer dates.
   - Ensure transactional integrity using SQL Server transactions.

## Interfaces:
1. **Manager Interface**
  - Perform database backups and restores.
  - Add new users (Role) to the database.
  - Remove permissions from existing users.
  - Create accounts for new employees.

2. **Regular Employee Interface**
  - Make new bank transfers between accounts.
  - Create accounts for clients.
  - Generate and print account statements for clients.
  - Open new accounts for clients.
  - Close pre-existing client accounts.
 

