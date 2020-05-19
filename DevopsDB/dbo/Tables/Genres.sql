CREATE TABLE [dbo].[Genres] (
    [GenreId]  INT            IDENTITY (1, 1) NOT NULL,
    [Category] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Genres] PRIMARY KEY CLUSTERED ([GenreId] ASC)
);

