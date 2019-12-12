IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191211231047_Initial')
BEGIN
    CREATE TABLE [Members] (
        [MemberID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Instrument] nvarchar(max) NULL,
        [DateJoined] nvarchar(max) NULL,
        [Board] bit NOT NULL,
        [SectionLeader] bit NOT NULL,
        CONSTRAINT [PK_Members] PRIMARY KEY ([MemberID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191211231047_Initial')
BEGIN
    CREATE TABLE [Messages] (
        [MessageInfoID] int NOT NULL IDENTITY,
        [Recipient] nvarchar(max) NOT NULL,
        [MessageText] nvarchar(max) NOT NULL,
        [Sender] nvarchar(max) NOT NULL,
        [MessageDate] datetime2 NOT NULL,
        [MessagePriority] nvarchar(max) NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageInfoID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191211231047_Initial')
BEGIN
    CREATE TABLE [PotentialMembers] (
        [PotentialMemberID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Instrument] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [RequestDate] datetime2 NOT NULL,
        CONSTRAINT [PK_PotentialMembers] PRIMARY KEY ([PotentialMemberID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191211231047_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191211231047_Initial', N'2.2.6-servicing-10079');
END;

GO

