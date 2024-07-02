USE BANK;

GO
CREATE PROCEDURE CheckEmpExists
    @IdentifierType VARCHAR(20),  -- 'Username', 'Email', or 'EmployeeID'
    @IdentifierValue VARCHAR(100), -- Value of the identifier (username, email, or ID)
    @Exists BIT OUTPUT
AS
BEGIN
    SET @Exists = 0;

    IF @IdentifierType = 'Username'
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM Employees
            WHERE Username = @IdentifierValue
        )
        BEGIN
            SET @Exists = 1;
        END
    END
    ELSE IF @IdentifierType = 'Email'
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM Employees
            WHERE Email = @IdentifierValue
        )
        BEGIN
            SET @Exists = 1;
        END
    END
    ELSE IF @IdentifierType = 'EmployeeID'
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM Employees
            WHERE EmployeeID = CAST(@IdentifierValue AS INT)
        )
        BEGIN
            SET @Exists = 1;
        END
    END
END
GO
