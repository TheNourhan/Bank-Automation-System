USE BANK

GO
CREATE PROCEDURE AddDatabaseUser
    @Username NVARCHAR(128),
    @Password NVARCHAR(128),
    @IsBackupOperator BIT,
    @IsSecurityAdmin BIT,
    @IsDdlAdmin BIT,
    @IsAccessAdmin BIT,
    @IsDbOwner BIT,
    @IsDbReader BIT,
    @IsDbWriter BIT
AS
BEGIN
    SET NOCOUNT ON;

    -- Create the login
    IF NOT EXISTS (SELECT * FROM sys.sql_logins WHERE name = @Username)
    BEGIN
        EXEC sp_addlogin @loginame = @Username, @passwd = @Password;
    END

    -- Create the user
    IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = @Username)
    BEGIN
        CREATE USER [@Username] FOR LOGIN [@Username];
    END

    -- Assign roles based on the checkboxes
    IF @IsBackupOperator = 1
    BEGIN
        EXEC sp_addrolemember N'db_backupoperator', @Username;
    END

    IF @IsSecurityAdmin = 1
    BEGIN
        EXEC sp_addrolemember N'db_securityadmin', @Username;
    END

    IF @IsDdlAdmin = 1
    BEGIN
        EXEC sp_addrolemember N'db_ddladmin', @Username;
    END

    IF @IsAccessAdmin = 1
    BEGIN
        EXEC sp_addrolemember N'db_accessadmin', @Username;
    END

    IF @IsDbOwner = 1
    BEGIN
        EXEC sp_addrolemember N'db_owner', @Username;
    END

    IF @IsDbReader = 1
    BEGIN
        EXEC sp_addrolemember N'db_datareader', @Username;
    END

    IF @IsDbWriter = 1
    BEGIN
        EXEC sp_addrolemember N'db_datawriter', @Username;
    END
END
GO
