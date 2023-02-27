CREATE TABLE [dbo].[CAU_HOI] (
    [MaCauHoi]  NVARCHAR (9)    NOT NULL,
    [TenCauHoi] NVARCHAR (1000) NULL,
    [DapAnA]    TEXT            NULL,
    [DapAnB]    TEXT            NULL,
    [DapAnC]    TEXT            NULL,
    [DapAnD]    TEXT            NULL,
    [DapAnDung] VARCHAR (4)     NULL,
    [MaMH]      NVARCHAR (9)    NULL,
    PRIMARY KEY CLUSTERED ([MaCauHoi] ASC),
    FOREIGN KEY ([MaMH]) REFERENCES [dbo].[MON_HOC] ([MaMH])
);

