USE BANK;

GO
CREATE PROCEDURE CheckBranchExists
    @BranchID INT,
    @IsExists BIT OUTPUT
AS
BEGIN
    SET @IsExists = 0;

    IF EXISTS (
        SELECT 1
        FROM Branches
        WHERE BranchID = @BranchID
    )
    BEGIN
        SET @IsExists = 1;
    END
END
GO
