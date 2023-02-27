CREATE TABLE [dbo].[SINHVIEN_BAIKIEMTRA] (
    [MaSV]           NVARCHAR (9) NOT NULL,
    [MaBaiKiemTra]   NVARCHAR (9) NOT NULL,
    [SoCauDung]      TINYINT      NULL,
    [Diem]           FLOAT (53)   NULL,
    [ThoiGianLamBai] TINYINT      NULL,
    [SoLanViPham]    TINYINT      NULL,
    PRIMARY KEY CLUSTERED ([MaSV] ASC, [MaBaiKiemTra] ASC),
    FOREIGN KEY ([MaBaiKiemTra]) REFERENCES [dbo].[BAI_KIEM_TRA] ([MaBaiKiemTra]),
    FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SINH_VIEN] ([MaSV])
);

