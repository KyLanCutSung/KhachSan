CREATE TABLE [dbo].[tblkhachhang] (
    [makhachhang]  NVARCHAR (20) NOT NULL,
    [tenkhachhang] NVARCHAR (50) NOT NULL,
    [diachikh]     NVARCHAR (50) NOT NULL,
    [dienthoaikh]  NVARCHAR (50) NOT NULL,
    [hangkh]       NVARCHAR (50) NOT NULL,
    [ngaysinhkh]   DATETIME      NOT NULL,
    [cccd]         INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([makhachhang] ASC)
);
CREATE TABLE [dbo].[tblloaiphong] (
    [maloai]  NVARCHAR (20) NOT NULL,
    [tenloai] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([maloai] ASC)
);

CREATE TABLE [dbo].[tblbophan] (
    [mabophan]  NVARCHAR (10) NOT NULL,
    [tenbophan] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([mabophan] ASC)
);
CREATE TABLE [dbo].[tblnhanvien] (
    [manhanvien]        NVARCHAR (10) NOT NULL,
    [tennhanvien] NVARCHAR (50) NOT NULL,
    [mabophan]    NVARCHAR (10) NOT NULL,
    [diachinv]    NVARCHAR (50) NOT NULL,
    [dienthoainv] NVARCHAR (50) NOT NULL,
    [ngaysinhnv]  DATETIME      NOT NULL,
    [gioitinhnv]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([manhanvien] ASC),
    FOREIGN KEY ([mabophan]) REFERENCES [dbo].[tblbophan] ([mabophan])
);
CREATE TABLE [dbo].[tbldaynha] (
    [madaynha]  NVARCHAR (20) NOT NULL,
    [tendaynha] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([madaynha] ASC)
);
CREATE TABLE [dbo].[tbldichvu] (
    [madichvu]  NVARCHAR (20) NOT NULL,
    [tendichvu] NVARCHAR (50) NOT NULL,
    [dongia]    FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([madichvu] ASC)
);
CREATE TABLE [dbo].[tblgiuong] (
    [magiuong]  NVARCHAR (20) NOT NULL,
    [tengiuong] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([magiuong] ASC)
);
CREATE TABLE [dbo].[tblphong] (
    [maphong]    NVARCHAR (20) NOT NULL,
    [tenphong]   NVARCHAR (50) NOT NULL,
    [madaynha]   NVARCHAR (20) NOT NULL,
    [maloai]     NVARCHAR (20) NOT NULL,
    [dongiangay] FLOAT (53)    NOT NULL,
    [tinhtrang]  NVARCHAR (50) NOT NULL,
    [ghichu]     NVARCHAR (50) NULL,
    [magiuong]   NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([maphong] ASC),
    FOREIGN KEY ([magiuong]) REFERENCES [dbo].[tblgiuong] ([magiuong]),
    FOREIGN KEY ([madaynha]) REFERENCES [dbo].[tbldaynha] ([madaynha]),
    FOREIGN KEY ([maloai]) REFERENCES [dbo].[tblloaiphong] ([maloai])
);
CREATE TABLE [dbo].[tblhoadonthuedv] (
    [maHD]        NVARCHAR (50) NOT NULL,
    [makhachhang] NVARCHAR (20) NOT NULL,
    [ngayban]     DATETIME      NOT NULL,
    [tongtien]    FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([maHD] ASC),
    FOREIGN KEY ([makhachhang]) REFERENCES [dbo].[tblkhachhang] ([makhachhang])
);
CREATE TABLE [dbo].[tblchitiethddv] (
    [maHD]      NVARCHAR (50) NOT NULL,
    [madichvu]  NVARCHAR (20) NOT NULL,
    [soluong]   FLOAT (53)    NOT NULL,
    [dongia]    FLOAT (53)    NOT NULL,
    [thanhtien] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([maHD] ASC, [madichvu] ASC),
    FOREIGN KEY ([madichvu]) REFERENCES [dbo].[tbldichvu] ([madichvu]),
    FOREIGN KEY ([maHD]) REFERENCES [dbo].[tblhoadonthuedv] ([maHD])
);
CREATE TABLE [dbo].[tblthuephong] (
    [masothue]    NVARCHAR (20) NOT NULL,
    [makhachhang] NVARCHAR (20) NOT NULL,
    [maphong]     NVARCHAR (20) NOT NULL,
    [ngayden]     DATE          NOT NULL,
    [tiendatcoc]  FLOAT (53)    NOT NULL,
    [manhanvien]  NVARCHAR (10) NOT NULL,
    [tinhtrang]   NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([masothue] ASC),
    FOREIGN KEY ([makhachhang]) REFERENCES [dbo].[tblkhachhang] ([makhachhang]),
    FOREIGN KEY ([maphong]) REFERENCES [dbo].[tblphong] ([maphong]),
    FOREIGN KEY ([manhanvien]) REFERENCES [dbo].[tblnhanvien] ([manhanvien])
);
CREATE TABLE [dbo].[tbltraphong] (
    [masothue]      NVARCHAR (20) NOT NULL,
    [ngaytraphong]  DATE          NOT NULL,
    [manhanvien]    NVARCHAR (20) NOT NULL,
    [tienthuephong] INT           NOT NULL,
    [cantra]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([masothue] ASC),
    FOREIGN KEY ([masothue]) REFERENCES [dbo].[tblthuephong] ([masothue]),
);

CREATE TABLE [dbo].[tbltaikhoan] (
    [taikhoan] NVARCHAR (50) NOT NULL,
    [matkhau]  NVARCHAR (50) NOT NULL,
    [email]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([taikhoan] ASC)
);
