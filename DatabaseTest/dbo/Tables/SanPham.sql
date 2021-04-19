CREATE TABLE [dbo].[SanPham] (
    [MaSP]      INT           NOT NULL,
    [TenSP]     NVARCHAR (50) NULL,
    [LoaiSP]    INT           NULL,
    [SoLuong]   INT           NULL,
    [GiaNhap]   INT           NULL,
    [GiaBan]    INT           NULL,
    [ConHang]   BIT           NULL,
    [HinhAnhSP] IMAGE         NULL,
    CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED ([MaSP] ASC),
    CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY ([LoaiSP]) REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
);

