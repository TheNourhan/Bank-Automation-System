USE BANK;

CREATE TABLE Branches (
    BranchID INT PRIMARY KEY IDENTITY,
    BranchName VARCHAR(100),
    Governorate VARCHAR(50)
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PasswordHash VARCHAR(100),
    Phone VARCHAR(20)
);

CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY IDENTITY,
    BranchID INT,
    CustomerID INT,
    AccountType VARCHAR(50),
    Status VARCHAR(20),
    Balance DECIMAL(15, 2),
    CreatedDate DATE,
    ClosedDate DATE,
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY,
    BranchID INT,
    ManagerID INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Username VARCHAR(50),
    Role VARCHAR(50),
    Email VARCHAR(100),
    PasswordHash VARCHAR(100),
    FOREIGN KEY (BranchID) REFERENCES Branches(BranchID),
    FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID)
);

CREATE TABLE Permissions (
    PermissionID INT PRIMARY KEY IDENTITY,
    PermissionName VARCHAR(50)
);

CREATE TABLE EmployeesPermissions (
    PermissionID INT,
    EmployeeID INT,
    PRIMARY KEY (PermissionID, EmployeeID),
    FOREIGN KEY (PermissionID) REFERENCES Permissions(PermissionID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

CREATE TABLE Transfers (
    TransferID INT PRIMARY KEY IDENTITY,
    FromAccountID INT,
    ToAccountID INT,
    Amount DECIMAL(15, 2),
    TransferDate DATETIME,
    FOREIGN KEY (FromAccountID) REFERENCES Accounts(AccountID),
    FOREIGN KEY (ToAccountID) REFERENCES Accounts(AccountID)
);
