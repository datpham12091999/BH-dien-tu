CREATE TABLE [dbo].[HoTroKhachHang] (
    [MaPhieuHoTro] INT            IDENTITY (1, 1) NOT NULL,
    [HoTenKH]      NVARCHAR (50)  NOT NULL,
    [SĐT]          NCHAR (10)     NOT NULL,
    [NgayGio]      DATETIME       NOT NULL,
    [DichVu]       NVARCHAR (50)  NOT NULL,
    [LoiNhan]      NVARCHAR (MAX) NOT NULL,
    [TinhTrang]    NCHAR (10)     NOT NULL,
    CONSTRAINT [PK_HoTroKhachHang] PRIMARY KEY CLUSTERED ([MaPhieuHoTro] ASC)
);

