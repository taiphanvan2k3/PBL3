CREATE TABLE [dbo].[MON_HOC] (
    [MaMH]       NVARCHAR (9)  NOT NULL,
    [TenMH]      NVARCHAR (30) NULL,
    [SoTC]       TINYINT       NULL,
    [CtTinhDiem] NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([MaMH] ASC)
);

