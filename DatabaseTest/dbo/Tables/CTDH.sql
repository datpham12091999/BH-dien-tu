CREATE TABLE [dbo].[CTDH] (
    [MaDonHang] NCHAR (8) NOT NULL,
    [MaSanPham] INT       NOT NULL,
    [Gia]       INT       NULL,
    [SoLuong]   INT       NULL,
    [KhuyenMai] REAL      NULL,
    CONSTRAINT [PK_CTDH] PRIMARY KEY CLUSTERED ([MaDonHang] ASC, [MaSanPham] ASC),
    CONSTRAINT [FK_CTDH_DonHang] FOREIGN KEY ([MaDonHang]) REFERENCES [dbo].[DonHang] ([MaDonHang]),
    CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY ([MaSanPham]) REFERENCES [dbo].[SanPham] ([MaSP])
);

