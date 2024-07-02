CREATE PROCEDURE CheckAccountStatus
    @AccountID INT,
    @AccountExists BIT OUTPUT,
    @IsActive BIT OUTPUT
AS
BEGIN
    SET @AccountExists = 0;
    SET @IsActive = 0;

    -- Check if the account exists
    IF EXISTS (SELECT 1 FROM Accounts WHERE AccountID = @AccountID)
    BEGIN
        SET @AccountExists = 1;

        -- Check if the account is active
        IF EXISTS (SELECT 1 FROM Accounts WHERE AccountID = @AccountID AND Status = 'Active')
        BEGIN
            SET @IsActive = 1;
        END
    END
END
GO
