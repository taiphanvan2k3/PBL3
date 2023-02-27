CREATE TABLE [dbo].[THONG_TIN_DANG_NHAP] (
    [TaiKhoan]       NVARCHAR (50) NOT NULL,
    [MkUngDung]      NVARCHAR (50) NULL,
    [EmailTruongCap] NVARCHAR (30) NULL,
    [MkEmail]        NVARCHAR (50) NULL,
    [VaiTro]         NVARCHAR (30) NULL,
    [LuuMatKhau]     BIT           NULL,
    PRIMARY KEY CLUSTERED ([TaiKhoan] ASC)
);

