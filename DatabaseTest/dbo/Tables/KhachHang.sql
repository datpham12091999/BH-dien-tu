CREATE TABLE [dbo].[KhachHang] (
    [MaKhachHang] INT            IDENTITY (1, 1) NOT NULL,
    [HoTen]       NVARCHAR (50)  NULL,
    [DiaChi]      NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (50)  NULL,
    [SDT]         NCHAR (10)     NULL,
    [NgaySinh]    DATE           NOT NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED ([MaKhachHang] ASC)
);

