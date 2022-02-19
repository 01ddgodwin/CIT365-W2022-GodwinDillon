CREATE TABLE [dbo].[Scripture] (
    [ID] INT IDENTITY (1, 1) NOT NULL,
    [Book] NCHAR(20) NOT NULL, 
    [Chapter] INT NOT NULL, 
    [Verse] INT NOT NULL, 
    CONSTRAINT [PK_Scripture] PRIMARY KEY CLUSTERED ([ID] ASC)
);

