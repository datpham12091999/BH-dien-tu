CREATE TABLE [dbo].[NhanVien] (
    [MaNhanVien]  INT            IDENTITY (1, 1) NOT NULL,
    [HoTenNV]     NVARCHAR (50)  NULL,
    [NgaySinh]    DATE           NULL,
    [DiaChi]      NVARCHAR (MAX) NOT NULL,
    [Email]       NVARCHAR (50)  NULL,
    [SoDienThoai] NCHAR (10)     NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([MaNhanVien] ASC)
);

