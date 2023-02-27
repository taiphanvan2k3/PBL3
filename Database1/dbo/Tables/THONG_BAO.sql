CREATE TABLE [dbo].[THONG_BAO] (
    [MaTB]         INT             IDENTITY (1, 1) NOT NULL,
    [TieuDe]       NVARCHAR (500)  NOT NULL,
    [NDThongBao]   NVARCHAR (1000) NOT NULL,
    [MaGVThongBao] NVARCHAR (9)    NOT NULL,
    PRIMARY KEY CLUSTERED ([MaTB] ASC),
    FOREIGN KEY ([MaGVThongBao]) REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
);

