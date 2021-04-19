CREATE TABLE [dbo].[TKNhanVien] (
    [MaNV]    INT           NOT NULL,
    [TenTK]   NVARCHAR (50) NOT NULL,
    [MatKhau] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_TKNhanVien] PRIMARY KEY CLUSTERED ([MaNV] ASC),
    CONSTRAINT [FK_TKNhanVien_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNhanVien])
);

