USE BANK;

GO
CREATE PROCEDURE TransferFunds
    @FromAccountID INT,
    @ToAccountID INT,
    @Amount DECIMAL(15, 2)
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @ErrorMessage NVARCHAR(4000);
    DECLARE @ErrorSeverity INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if FromAccount has sufficient balance
        DECLARE @FromBalance DECIMAL(15, 2);
        SELECT @FromBalance = Balance FROM Accounts WHERE AccountID = @FromAccountID;

        IF @FromBalance < @Amount
        BEGIN
            THROW 50000, 'Insufficient funds in FromAccount.', 1;
        END

        -- Deduct amount from FromAccount
        UPDATE Accounts SET Balance = Balance - @Amount WHERE AccountID = @FromAccountID;

        -- Add amount to ToAccount
        UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = @ToAccountID;

        -- Insert transfer record
        INSERT INTO Transfers (FromAccountID, ToAccountID, Amount, TransferDate)
        VALUES (@FromAccountID, @ToAccountID, @Amount, GETDATE());

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        SET @ErrorMessage = ERROR_MESSAGE();
        SET @ErrorSeverity = ERROR_SEVERITY();

        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END

        RAISERROR(@ErrorMessage, @ErrorSeverity, 1);
    END CATCH
END
GO
