USE BANK

GO
CREATE VIEW V_TransferDetails AS
SELECT 
    t.TransferID,
    t.FromAccountID AS FromAccount,
    fc.FirstName AS FromFirstName,
    fc.LastName AS FromLastName,
    t.ToAccountID AS ToAccount,
    tc.FirstName AS ToFirstName,
    tc.LastName AS ToLastName,
    t.Amount AS TransferAmount,
    t.TransferDate
FROM 
    Transfers t
JOIN 
    Accounts fa ON t.FromAccountID = fa.AccountID
JOIN 
    Customers fc ON fa.CustomerID = fc.CustomerID
JOIN 
    Accounts ta ON t.ToAccountID = ta.AccountID
JOIN 
    Customers tc ON ta.CustomerID = tc.CustomerID;
GO