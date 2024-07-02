USE BANK;

GO
CREATE PROCEDURE dbo.CheckUserExists
    @Username NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserExists BIT = 0;

    -- Check if the user exists
    IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @Username)
        SET @UserExists = 1;

    SELECT @UserExists AS UserExists;
END;
GO
