USE BANK

GO
CREATE PROCEDURE GetTransferDetails
    @AccountId INT,
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT 
        *
    FROM 
        V_TransferDetails
    WHERE 
        (FromAccount = @AccountId OR ToAccount = @AccountId)
        AND TransferDate BETWEEN @FromDate AND @ToDate;
END
GO
