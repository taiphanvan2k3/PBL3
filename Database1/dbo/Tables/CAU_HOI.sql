CREATE TABLE [dbo].[CAU_HOI] (
    [MaCauHoi]  NVARCHAR (9)    NOT NULL,
    [TenCauHoi] NVARCHAR (1000) NOT NULL,
    [DapAnA]    TEXT            NOT NULL,
    [DapAnB]    TEXT            NOT NULL,
    [DapAnC]    TEXT            NOT NULL,
    [DapAnD]    TEXT            NOT NULL,
    [DapAnDung] VARCHAR (4)     NOT NULL,
    [MaMH]      NVARCHAR (9)    NOT NULL,
    PRIMARY KEY CLUSTERED ([MaCauHoi] ASC),
    FOREIGN KEY ([MaMH]) REFERENCES [dbo].[MON_HOC] ([MaMH])
);

