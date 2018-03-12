CREATE TABLE [dbo].[Invoices] (
    [Invoice ID] INT IDENTITY (1, 1) NOT NULL,
    [Customer] NVARCHAR(50) NOT NULL, 
    [Info] NVARCHAR(MAX) NOT NULL, 
    [Estimate] BIT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Invoice ID] ASC)
);

