USE BANK;

GO
CREATE PROCEDURE CheckEmployeePermission
    @EmployeeID INT,
    @PermissionName VARCHAR(50)
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM EmployeesPermissions ep
        JOIN Permissions p ON ep.PermissionID = p.PermissionID
        WHERE ep.EmployeeID = @EmployeeID AND p.PermissionName = @PermissionName
    )
    BEGIN
        SELECT 1 AS HasPermission
    END
    ELSE
    BEGIN
        SELECT 0 AS HasPermission
    END
END
