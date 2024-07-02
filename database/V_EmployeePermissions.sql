USE BANK;

GO
CREATE VIEW V_EmployeePermissions AS
SELECT 
    e.EmployeeID,
    e.FirstName + ' ' + e.LastName AS FullName,
    p.PermissionID,
    p.PermissionName
FROM 
    Employees e
JOIN 
    EmployeesPermissions ep ON e.EmployeeID = ep.EmployeeID
JOIN 
    Permissions p ON ep.PermissionID = p.PermissionID;
