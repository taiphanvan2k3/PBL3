CREATE TABLE [dbo].[BAI_KIEM_TRA] (
    [MaBaiKiemTra]     NVARCHAR (9)   NOT NULL,
    [TenBaiKiemTra]    NVARCHAR (200) NULL,
    [TieuDeBaiKiemTra] NVARCHAR (100) NULL,
    [NgayKiemTra]      DATE           NULL,
    [ThoiGianBatDau]   TIME (7)       NULL,
    [ThoiGianLamBai]   TIME (7)       NULL,
    [SoCauHoi]         TINYINT        NULL,
    [MaGV]             NVARCHAR (9)   NULL,
    PRIMARY KEY CLUSTERED ([MaBaiKiemTra] ASC),
    FOREIGN KEY ([MaGV]) REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
);

