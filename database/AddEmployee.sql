USE BANK;

GO
CREATE PROCEDURE AddEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Username VARCHAR(50),
    @Email VARCHAR(100),
    @Role VARCHAR(50),
    @PasswordHash VARCHAR(100),
    @BranchID INT,
    @ManagerID INT,
    @EmployeeID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Employees (BranchID, ManagerID, FirstName, LastName, Role, Email, PasswordHash, Username)
    VALUES (@BranchID, @ManagerID, @FirstName, @LastName, @Role, @Email, @PasswordHash, @Username);

    -- Set output parameter with the new EmployeeID
    SET @EmployeeID = SCOPE_IDENTITY();

    PRINT 'Employee added successfully.';
END
GO
