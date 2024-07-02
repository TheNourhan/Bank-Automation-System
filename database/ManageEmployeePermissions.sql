USE BANK

GO
CREATE PROCEDURE ManageEmployeePermissions
    @EmployeeID INT,
    @StatementPermission BIT,
    @TransfersPermission BIT,
    @CloseAccPermission BIT,
    @NewAccPermission BIT,
    @LoginPermission BIT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @StatementPermissionID INT, @TransfersPermissionID INT, @CloseAccPermissionID INT,
                @NewAccPermissionID INT, @LoginPermissionID INT;

        -- Check and insert permissions as necessary
        IF @StatementPermission = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM Permissions WHERE PermissionName = 'Make Statement')
            BEGIN
                INSERT INTO Permissions (PermissionName) VALUES ('Make Statement');
            END
            SELECT @StatementPermissionID = PermissionID FROM Permissions WHERE PermissionName = 'Make Statement';
        END

        IF @TransfersPermission = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM Permissions WHERE PermissionName = 'Transfers')
            BEGIN
                INSERT INTO Permissions (PermissionName) VALUES ('Transfers');
            END
            SELECT @TransfersPermissionID = PermissionID FROM Permissions WHERE PermissionName = 'Transfers';
        END

        IF @CloseAccPermission = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM Permissions WHERE PermissionName = 'Close Account')
            BEGIN
                INSERT INTO Permissions (PermissionName) VALUES ('Close Account');
            END
            SELECT @CloseAccPermissionID = PermissionID FROM Permissions WHERE PermissionName = 'Close Account';
        END

        IF @NewAccPermission = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM Permissions WHERE PermissionName = 'New Account')
            BEGIN
                INSERT INTO Permissions (PermissionName) VALUES ('New Account');
            END
            SELECT @NewAccPermissionID = PermissionID FROM Permissions WHERE PermissionName = 'New Account';
        END

        IF @LoginPermission = 1
        BEGIN
            IF NOT EXISTS (SELECT 1 FROM Permissions WHERE PermissionName = 'Login')
            BEGIN
                INSERT INTO Permissions (PermissionName) VALUES ('Login');
            END
            SELECT @LoginPermissionID = PermissionID FROM Permissions WHERE PermissionName = 'Login';
        END

        -- Insert into EmployeesPermissions table for each selected permission
        IF @StatementPermission = 1
        BEGIN
            INSERT INTO EmployeesPermissions (PermissionID, EmployeeID)
            VALUES (@StatementPermissionID, @EmployeeID);
        END

        IF @TransfersPermission = 1
        BEGIN
            INSERT INTO EmployeesPermissions (PermissionID, EmployeeID)
            VALUES (@TransfersPermissionID, @EmployeeID);
        END

        IF @CloseAccPermission = 1
        BEGIN
            INSERT INTO EmployeesPermissions (PermissionID, EmployeeID)
            VALUES (@CloseAccPermissionID, @EmployeeID);
        END

        IF @NewAccPermission = 1
        BEGIN
            INSERT INTO EmployeesPermissions (PermissionID, EmployeeID)
            VALUES (@NewAccPermissionID, @EmployeeID);
        END

        IF @LoginPermission = 1
        BEGIN
            INSERT INTO EmployeesPermissions (PermissionID, EmployeeID)
            VALUES (@LoginPermissionID, @EmployeeID);
        END

        -- Commit the transaction
        COMMIT TRANSACTION;

        -- Success message
        PRINT 'Employee permissions managed successfully.';
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if an error occurs
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END

        -- Throw or handle the error
        DECLARE @ErrorMessage NVARCHAR(MAX) = ERROR_MESSAGE();
        THROW 50000, @ErrorMessage, 1;
    END CATCH;
END
GO
