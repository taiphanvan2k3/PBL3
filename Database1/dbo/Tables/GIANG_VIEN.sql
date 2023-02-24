CREATE TABLE [dbo].[GIANG_VIEN] (
    [MaGV]        NVARCHAR (9)  NOT NULL,
    [HoGV]        NVARCHAR (10) NOT NULL,
    [TenGV]       NVARCHAR (20) NOT NULL,
    [NgaySinh]    DATETIME      NULL,
    [GioiTinh]    NVARCHAR (3)  NULL,
    [DiaChi]      NVARCHAR (30) NULL,
    [TrinhDo]     NVARCHAR (20) NULL,
    [EmailCaNhan] NVARCHAR (30) NULL,
    [Luong]       INT           NULL,
    [Sdt]         NVARCHAR (11) NULL,
    [MaKhoa]      NVARCHAR (9)  NULL,
    [TaiKhoan]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([MaGV] ASC),
    FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[KHOA] ([MaKhoa]),
    FOREIGN KEY ([TaiKhoan]) REFERENCES [dbo].[THONG_TIN_DANG_NHAP] ([TaiKhoan])
);

