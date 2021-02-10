CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [CarName]     VARCHAR (320) NOT NULL,
    [ModelYear]   TEXT          NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [Description] TEXT          NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]),
    CONSTRAINT [MIN_CAR_NAME_LENGTH] CHECK (len([CarName])>=(5)),
    CONSTRAINT [MIN_DAILY_PRICE] CHECK ([DailyPrice]>=(0))
);

