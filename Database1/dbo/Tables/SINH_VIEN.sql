CREATE TABLE [dbo].[SINH_VIEN] (
    [MaSV]        NVARCHAR (9)   NOT NULL,
    [HoSV]        NVARCHAR (10)  NOT NULL,
    [TenSV]       NVARCHAR (20)  NOT NULL,
    [AnhCaNhan]   IMAGE          NULL,
    [NgaySinh]    DATE           NULL,
    [GioiTinh]    NVARCHAR (3)   NULL,
    [DiaChi]      NVARCHAR (100) NULL,
    [Sdt]         NVARCHAR (11)  NULL,
    [EmailCaNhan] NVARCHAR (30)  NULL,
    [MaCTDT]      NVARCHAR (9)   NULL,
    [MaKhoa]      NVARCHAR (9)   NULL,
    [MaLopSH]     NVARCHAR (9)   NULL,
    PRIMARY KEY CLUSTERED ([MaSV] ASC),
    FOREIGN KEY ([MaCTDT]) REFERENCES [dbo].[CHUONG_TRINH_DAO_TAO] ([MaCTDT]),
    FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[KHOA] ([MaKhoa]),
    FOREIGN KEY ([MaLopSH]) REFERENCES [dbo].[LOP_SINH_HOAT] ([MaLopSH])
);

