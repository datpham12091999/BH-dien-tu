CREATE TABLE [dbo].[DangNhap] (
    [MaKhachHang] INT         NOT NULL,
    [DangNhap]    NCHAR (50)  NOT NULL,
    [MatKhau]     NCHAR (255) NOT NULL,
    CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED ([MaKhachHang] ASC, [DangNhap] ASC),
    CONSTRAINT [FK_DangNhap_KhachHang1] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang])
);

