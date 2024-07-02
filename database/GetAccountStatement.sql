USE BANK;

GO
CREATE PROCEDURE GetAccountStatement
    @AccountId INT
AS
BEGIN
    SELECT 
        c.FirstName,
        c.LastName,
        a.AccountID,
        a.Status,
        a.Balance,
        b.BranchName,
        a.CreatedDate,
        (SELECT COUNT(*) 
         FROM Transfers 
         WHERE FromAccountID = @AccountId OR ToAccountID = @AccountId) AS NumberOfTransfers
    FROM 
        Accounts a
    JOIN 
        Customers c ON a.CustomerID = c.CustomerID
    JOIN 
        Branches b ON a.BranchID = b.BranchID
    WHERE 
        a.AccountID = @AccountId;
END
GO
