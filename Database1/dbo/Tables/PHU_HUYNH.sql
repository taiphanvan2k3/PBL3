CREATE TABLE [dbo].[PHU_HUYNH] (
    [MaSV]      NVARCHAR (9)   NOT NULL,
    [TenPH]     NVARCHAR (30)  NOT NULL,
    [GioiTinh]  NVARCHAR (3)   NULL,
    [Sdt]       NVARCHAR (9)   NULL,
    [NgaySinh]  DATE           NULL,
    [DiaChi]    NVARCHAR (100) NULL,
    [MoiQuanHe] NVARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([MaSV] ASC, [TenPH] ASC),
    FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SINH_VIEN] ([MaSV])
);

