CREATE TABLE [dbo].[Customers] (
    [Customer ID]   INT        IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR(50)       NOT NULL,
    [Address]       NVARCHAR(MAX)       NOT NULL,
    [Phone Number]  NVARCHAR(12) NOT NULL,
    [Email Address] NVARCHAR(50)       NULL,
    [Vehicle]       NVARCHAR(MAX)       NULL,
    [Invoices]      NVARCHAR(MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Customer ID] ASC)
);

