CREATE TABLE [dbo].[THOI_KHOA_BIEU] (
    [Thu]         NVARCHAR (8) NOT NULL,
    [TietBD]      NVARCHAR (5) NOT NULL,
    [MaPhongHoc]  NVARCHAR (9) NOT NULL,
    [TietKetThuc] NVARCHAR (5) NULL,
    [MaLopHP]     NVARCHAR (9) NULL,
    PRIMARY KEY CLUSTERED ([Thu] ASC, [TietBD] ASC, [MaPhongHoc] ASC),
    FOREIGN KEY ([MaLopHP]) REFERENCES [dbo].[LOP_HOC_PHAN] ([MaLopHP])
);

