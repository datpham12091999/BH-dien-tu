CREATE TABLE [dbo].[SuaChua] (
    [MaDonSuaChua]  INT        IDENTITY (1, 1) NOT NULL,
    [TenSPSuaChua]  NCHAR (50) NOT NULL,
    [NgayDatLich]   DATE       NOT NULL,
    [MoTaTinhTrang] TEXT       NOT NULL,
    [Diachi]        NCHAR (50) NOT NULL,
    [SDT]           NCHAR (10) NOT NULL,
    CONSTRAINT [PK_DatLichSuaChua] PRIMARY KEY CLUSTERED ([MaDonSuaChua] ASC)
);

