CREATE TABLE [dbo].[LoaiSP] (
    [MaLoaiSP]  INT            IDENTITY (1, 1) NOT NULL,
    [TenLoaiSP] NVARCHAR (50)  NULL,
    [MoTa]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED ([MaLoaiSP] ASC)
);

