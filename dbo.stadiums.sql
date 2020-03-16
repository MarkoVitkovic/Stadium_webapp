CREATE TABLE [dbo].[stadiums] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [ClubName]    NVARCHAR (MAX) NULL,
    [TicketPrice] DECIMAL          NOT NULL,
    [Capacity]    INT            NOT NULL,
    CONSTRAINT [PK_stadiums] PRIMARY KEY CLUSTERED ([Id] ASC)
);

