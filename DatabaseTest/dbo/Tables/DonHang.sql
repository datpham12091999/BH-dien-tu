CREATE TABLE [dbo].[DonHang] (
    [MaDonHang]        NCHAR (8)     NOT NULL,
    [MaKhachHang]      INT           NOT NULL,
    [NgayMuaHang]      DATE          NOT NULL,
    [ThanhTienDonHang] INT           NOT NULL,
    [DiaChiGiaoHang]   NVARCHAR (50) NULL,
    [Tinh/ThanhPho]    NVARCHAR (50) NULL,
    [Quan/Huyen]       NVARCHAR (50) NULL,
    CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED ([MaDonHang] ASC),
    CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang])
);

