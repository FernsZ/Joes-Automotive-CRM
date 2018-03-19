CREATE TABLE [dbo].[Customers] (
    [Customer ID]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (MAX)  NOT NULL,
    [Address]        NVARCHAR (MAX) NOT NULL,
    [Phone Number]   NCHAR (12)     NOT NULL,
    [Phone Number 2] NCHAR (12)     NULL,
    [Email Address]  NVARCHAR (50)  NULL,
    [Vehicle]        NVARCHAR (MAX) NULL,
    [Invoices]       ROWVERSION     NULL,
    [Image]          IMAGE          NULL,
    PRIMARY KEY CLUSTERED ([Customer ID] ASC)
);

