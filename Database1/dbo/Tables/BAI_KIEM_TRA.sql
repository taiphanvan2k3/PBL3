CREATE TABLE [dbo].[BAI_KIEM_TRA] (
    [MaBaiKiemTra]     NVARCHAR (9)   NOT NULL,
    [TenBaiKiemTra]    NVARCHAR (200) NOT NULL,
    [TieuDeBaiKiemTra] NVARCHAR (100) NOT NULL,
    [NgayKiemTra]      DATE           NOT NULL,
    [ThoiGianBatDau]   TIME (7)       NOT NULL,
    [ThoiGianLamBai]   TIME (7)       NOT NULL,
    [SoCauHoi]         TINYINT        NOT NULL,
    [MaGV]             NVARCHAR (9)   NOT NULL,
    PRIMARY KEY CLUSTERED ([MaBaiKiemTra] ASC),
    FOREIGN KEY ([MaGV]) REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
);

