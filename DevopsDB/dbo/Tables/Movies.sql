CREATE TABLE [dbo].[Movies] (
    [MovieId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]   NVARCHAR (MAX) NULL,
    [GenreId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Movies] PRIMARY KEY CLUSTERED ([MovieId] ASC),
    CONSTRAINT [FK_dbo.Movies_dbo.Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([GenreId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_GenreId]
    ON [dbo].[Movies]([GenreId] ASC);

