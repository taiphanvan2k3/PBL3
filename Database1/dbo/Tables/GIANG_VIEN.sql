CREATE TABLE [dbo].[GIANG_VIEN] (
    [MaGV]        NVARCHAR (9)  NOT NULL,
    [HoGV]        NVARCHAR (10) NOT NULL,
    [TenGV]       NVARCHAR (20) NOT NULL,
    [NgaySinh]    DATE      NOT NULL,
    [GioiTinh]    NVARCHAR (3)  NOT NULL,
    [DiaChi]      NVARCHAR (30) NULL,
    [TrinhDo]     NVARCHAR (20) NULL,
    [EmailCaNhan] NVARCHAR (30) NULL,
    [Luong]       INT           NULL,
    [Sdt]         NVARCHAR (11) NULL,
    [MaKhoa]      NVARCHAR (9)  NOT NULL,
    [TaiKhoan]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaGV] ASC),
    FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[KHOA] ([MaKhoa]),
    FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[THONG_TIN_DANG_NHAP] ([TaiKhoan])
);

