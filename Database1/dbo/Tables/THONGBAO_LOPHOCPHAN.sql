﻿CREATE TABLE [dbo].[THONGBAO_LOPHOCPHAN] (
    [MaTB]    INT          NOT NULL,
    [MaLopHP] NVARCHAR (9) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaTB] ASC, [MaLopHP] ASC),
    FOREIGN KEY ([MaLopHP]) REFERENCES [dbo].[LOP_HOC_PHAN] ([MaLopHP]),
    FOREIGN KEY ([MaTB]) REFERENCES [dbo].[THONG_BAO] ([MaTB])
);

