CREATE TABLE [dbo].[THONG_BAO] (
    [MaTB]         INT             IDENTITY (1, 1) NOT NULL,
    [TieuDe]       NVARCHAR (500)  NULL,
    [NDThongBao]   NVARCHAR (1000) NULL,
    [MaGVThongBao] NVARCHAR (9)    NULL,
    PRIMARY KEY CLUSTERED ([MaTB] ASC),
    FOREIGN KEY ([MaGVThongBao]) REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
);

