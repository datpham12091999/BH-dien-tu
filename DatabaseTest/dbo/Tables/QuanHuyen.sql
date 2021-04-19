CREATE TABLE [dbo].[QuanHuyen] (
    [MaQuanHuyen]  INT           NOT NULL,
    [MaTinh]       INT           NOT NULL,
    [TenQuanHuyen] NVARCHAR (50) NULL,
    CONSTRAINT [PK_QuanHuyen] PRIMARY KEY CLUSTERED ([MaQuanHuyen] ASC, [MaTinh] ASC),
    CONSTRAINT [FK_QuanHuyen_Tinh1] FOREIGN KEY ([MaTinh]) REFERENCES [dbo].[Tinh] ([MaTinh])
);

