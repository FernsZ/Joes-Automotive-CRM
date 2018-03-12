CREATE TABLE [dbo].[Vehicle] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [Model]         NVARCHAR (50) NOT NULL,
    [Year]          NCHAR (10)    NULL,
    [Mileage]       NCHAR (10)    NULL,
    [Date Recieved] DATE          NOT NULL,
    [Date Return]   DATE          NULL,
    [Owner]         NVARCHAR (50) NOT NULL,
    [Make] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

