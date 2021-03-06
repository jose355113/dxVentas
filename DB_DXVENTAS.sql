USE [master]
GO
/****** Object:  Database [DXVENTAS]    Script Date: 02/03/2019 13:02:19 ******/
CREATE DATABASE [DXVENTAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDVENTAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDVENTAS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BDVENTAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BDVENTAS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DXVENTAS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DXVENTAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DXVENTAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DXVENTAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DXVENTAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DXVENTAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DXVENTAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DXVENTAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DXVENTAS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DXVENTAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DXVENTAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DXVENTAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DXVENTAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DXVENTAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DXVENTAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DXVENTAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DXVENTAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DXVENTAS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DXVENTAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DXVENTAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DXVENTAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DXVENTAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DXVENTAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DXVENTAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DXVENTAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DXVENTAS] SET RECOVERY FULL 
GO
ALTER DATABASE [DXVENTAS] SET  MULTI_USER 
GO
ALTER DATABASE [DXVENTAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DXVENTAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DXVENTAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DXVENTAS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DXVENTAS]

GO
/****** Object:  Table [dbo].[CnAnexosContables]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[CnAnexosContables](
	[Cod_TipAnEX] [char](1) NOT NULL,
	[Cod_Anxo] [char](4) NOT NULL,
	[Des_Anexo] [varchar](100) NOT NULL,
	[Num_Ruc] [char](24) NOT NULL,
	[Dir_Anexo] [varchar](200) NOT NULL,
	[Cod_TipIte] [char](3) NOT NULL,
	[Apellido_Paterno] [varchar](40) NULL,
	[Apellido_Materno] [varchar](40) NULL,
	[Nombres] [char](40) NULL,
	[Origen] [char](1) NULL,
	[Cod_Pais] [char](4) NULL,
	[Telefono] [varchar](100) NULL,
	[Cod_Zona] [char](3) NULL,
	[Codigo_Postal] [char](2) NULL,
	[Contacto_Pago] [varchar](50) NULL,
	[COD_CLIENTE] [char](5) NULL,
	[Fec_Alta] [datetime] NULL,
	[Cod_TipoDocIde] [char](2) NULL,
	[Nro_DocIde] [varchar](20) NULL,
	[Fec_Nacimiento] [datetime] NULL,
	[Fec_Creacion] [datetime] NULL,
	[Cod_Ubigeo] [char](6) NULL,
	[Fec_Baja] [datetime] NULL,
	[Cod_Usuario_Baja] [char](15) NULL,
	[Cod_Motivo_Baja] [char](3) NULL,
	[Observaciones_Baja] [varchar](300) NULL,
	[Flg_Activo] [char](1) NULL,
 CONSTRAINT [PK_CN_AnexosContables] PRIMARY KEY CLUSTERED 
(
	[Cod_TipAnEX] ASC,
	[Cod_Anxo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CnTiposDocum]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CnTiposDocum](
	[Cod_TipDoc] [char](2) NOT NULL,
	[Des_TipDoc] [char](50) NULL,
	[Flg_ClaDoc] [char](1) NULL,
	[Flg_Aplica] [char](1) NULL,
 CONSTRAINT [PK_CN_TiposDocum] PRIMARY KEY CLUSTERED 
(
	[Cod_TipDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CnTiposVenta]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CnTiposVenta](
	[Cod_Tipo_Venta] [char](3) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Cn_Tipos_Venta] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CnVentas]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CnVentas](
	[Cod_TipDoc] [char](2) NOT NULL,
	[Ser_Docum] [char](4) NOT NULL,
	[Num_Docum_Ventas] [char](8) NOT NULL,
	[Num_Corre] [char](12) NOT NULL,
	[Cod_Tipanex] [char](1) NOT NULL,
	[Cod_Anxo] [char](4) NOT NULL,
	[Cod_CondVent] [char](3) NOT NULL,
	[Cod_Tip_Pago] [int] NOT NULL,
	[Fec_EmiDoc] [datetime] NULL,
	[Fec_RegDoc] [datetime] NULL,
	[Fec_VenDoc] [datetime] NULL,
	[Fec_Cancelacion] [datetime] NULL,
	[Cod_Moneda] [char](3) NOT NULL,
	[Imp_Neto] [numeric](13, 3) NOT NULL,
	[Imp_IGV] [numeric](13, 2) NOT NULL,
	[Imp_Total] [numeric](13, 3) NOT NULL,
	[Tipo_Cambio] [numeric](10, 3) NOT NULL,
	[Porc_IGV] [numeric](5, 2) NOT NULL,
	[Cod_Usuario_Registro] [char](50) NOT NULL,
	[Cod_Tipo_Venta] [char](3) NOT NULL,
	[Por_Descuento] [numeric](5, 2) NOT NULL,
	[Num_Corre_Referencia] [char](12) NOT NULL,
 CONSTRAINT [PK_Cn_Ventas] PRIMARY KEY CLUSTERED 
(
	[Cod_TipDoc] ASC,
	[Ser_Docum] ASC,
	[Num_Docum_Ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY],
 CONSTRAINT [IX_Cn_Ventas] UNIQUE NONCLUSTERED 
(
	[Num_Corre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CnVentasItems]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[CnVentasItems](
	[Num_Corre] [char](12) NOT NULL,
	[Secuencia] [int] NOT NULL,
	[Tipo_Item] [char](1) NOT NULL,
	[Codigo_Item] [varchar](25) NOT NULL,
	[Cod_Color] [char](6) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[Cantidad] [numeric](18, 2) NOT NULL,
	[Unidad_Medida] [char](3) NOT NULL,
	[Imp_Unitario] [numeric](18, 5) NOT NULL,
	[Imp_Total] [numeric](18, 2) NOT NULL,
	[Imp_Descuento] [numeric](18, 2) NOT NULL,
	[Num_Corre_Original_NCND] [char](12) NOT NULL,
	[Num_Secuencia_OriginalNCND] [int] NOT NULL,
	[Cantidad_Item_NC_ND] [numeric](18, 2) NOT NULL,
	[Cod_TipDoc_NCND] [char](2) NULL,
	[Ser_Docum_NCND] [char](4) NULL,
	[Num_Docum_NCND] [char](8) NULL,
 CONSTRAINT [PK_Cn_Ventas_Items] PRIMARY KEY CLUSTERED 
(
	[Num_Corre] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgAlmacen]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgAlmacen](
	[Cod_almacen] [char](2) NOT NULL,
	[Nom_Almacen] [varchar](200) NOT NULL,
	[Tip_Item] [char](1) NOT NULL,
	[Flg_status] [char](1) NOT NULL,
	[Anio_Cierre] [char](4) NULL,
	[Mes_Cierre] [char](2) NULL,
	[Tip_Presentacion] [char](1) NULL,
 CONSTRAINT [PK_Lg_Almacen] PRIMARY KEY CLUSTERED 
(
	[Cod_almacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgFamIte]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgFamIte](
	[cod_famitem] [char](2) NOT NULL,
	[des_famitem] [varchar](500) NOT NULL,
 CONSTRAINT [PK__LG_FamIte__5FB337D6] PRIMARY KEY CLUSTERED 
(
	[cod_famitem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgItem]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgItem](
	[Cod_Item] [char](8) NOT NULL,
	[Cod_FamItem] [char](2) NOT NULL,
	[Cod_UniMed] [char](2) NOT NULL,
	[Des_Item] [varchar](200) NULL,
	[Fec_Creacion] [datetime] NOT NULL,
	[Can_PtoReor] [numeric](18, 2) NOT NULL,
	[Can_LotPed] [numeric](18, 2) NOT NULL,
	[Flg_Status] [char](1) NOT NULL,
 CONSTRAINT [PK_Lg_Item] PRIMARY KEY CLUSTERED 
(
	[Cod_Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgItemComb]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgItemComb](
	[Cod_Item] [char](8) NOT NULL,
	[Cod_Comb] [char](3) NOT NULL,
	[Des_Comb] [varchar](500) NOT NULL,
	[Observaciones] [varchar](100) NOT NULL,
	[Flg_Status] [char](1) NULL,
 CONSTRAINT [PK_Lg_ItemComb] PRIMARY KEY CLUSTERED 
(
	[Cod_Item] ASC,
	[Cod_Comb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgItemCombDet]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgItemCombDet](
	[Cod_Item] [char](8) NOT NULL,
	[Cod_Comb] [char](3) NOT NULL,
	[Num_Secuencia] [char](2) NOT NULL,
	[Cod_Item_Detalle] [char](8) NULL,
	[Cod_Comb_Detalle] [char](8) NULL,
	[Cod_Color] [char](6) NULL,
	[Can_Consumo] [numeric](12, 5) NULL,
	[Observaciones] [varchar](100) NULL,
	[Des_Combdet] [char](20) NOT NULL,
 CONSTRAINT [PK_Lg_ItemCombDet] PRIMARY KEY CLUSTERED 
(
	[Cod_Item] ASC,
	[Cod_Comb] ASC,
	[Num_Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgMoviStk]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgMoviStk](
	[Cod_Almacen] [char](2) NOT NULL,
	[Num_MovStk] [char](6) NOT NULL,
	[Fec_Creacion] [datetime] NOT NULL,
	[Fec_MovStk] [datetime] NOT NULL,
	[Cod_Usuario] [char](50) NULL,
	[Cod_Proveedor] [char](12) NULL,
	[Cod_TipMov] [char](3) NOT NULL,
	[Ser_OrdComp] [char](3) NULL,
	[Cod_OrdComp] [char](6) NULL,
	[Cod_Cliente] [char](5) NULL,
	[Ser_Guia_Propia] [char](3) NULL,
	[Nro_Guia_Propia] [char](8) NULL,
	[Cod_MotTra] [char](3) NULL,
	[Ser_Factura] [varchar](4) NULL,
	[Num_Factura] [char](8) NULL,
	[Cod_CondVent] [char](3) NULL,
	[Num_Corre_Ventas] [char](12) NULL,
	[fecha_facturacion] [datetime] NULL,
	[Cod_Moneda] [char](3) NULL,
	[Ser_Docum_Ventas] [varchar](4) NULL,
	[Num_Docum_Ventas] [char](15) NULL,
 CONSTRAINT [PK_Lg_MoviStk] PRIMARY KEY CLUSTERED 
(
	[Cod_Almacen] ASC,
	[Num_MovStk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgMoviStkItem]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgMoviStkItem](
	[Cod_Almacen] [char](2) NOT NULL,
	[Num_MovStk] [char](6) NOT NULL,
	[Num_Secuencia] [char](3) NOT NULL,
	[Cod_Item] [char](8) NULL,
	[Cod_Comb] [char](3) NULL,
	[Cod_Color] [char](6) NULL,
	[Cod_Talla] [char](10) NULL,
	[Can_Movimiento] [numeric](13, 4) NULL,
	[Ser_OrdComp] [char](3) NULL,
	[Cod_OrdComp] [char](6) NULL,
	[Sec_OrdComp] [char](3) NULL,
	[Fec_MOVsTK] [datetime] NOT NULL,
 CONSTRAINT [PK_Lg_MoviStkItem] PRIMARY KEY CLUSTERED 
(
	[Cod_Almacen] ASC,
	[Num_MovStk] ASC,
	[Num_Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgOrdComp]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgOrdComp](
	[Ser_OrdComp] [char](3) NOT NULL,
	[Cod_OrdComp] [char](6) NOT NULL,
	[Cod_Proveedor] [char](12) NULL,
	[Cod_CondVent] [char](3) NULL,
	[Cod_Descuento] [char](3) NULL,
	[Porc_IGV] [numeric](9, 2) NULL,
	[Cod_Moneda] [char](3) NULL,
	[Cod_LugEntr] [char](3) NULL,
	[Observaciones] [varchar](2000) NULL,
	[Cod_StaOrdComp] [char](1) NULL,
	[Fec_Creacion] [datetime] NULL,
	[Fec_1raEmision] [datetime] NULL,
	[Fec_UltaEmision] [datetime] NULL,
	[Fec_1raAutoriz] [datetime] NULL,
	[Fec_UltAutoriz] [datetime] NULL,
	[Fec_Cierre] [datetime] NULL,
	[Cod_ClaOrdComp] [char](2) NULL,
	[Fec_Entrega_Inicio] [datetime] NULL,
	[Fec_Entrega_Fin] [datetime] NULL,
 CONSTRAINT [PK_Lg_OrdComp] PRIMARY KEY CLUSTERED 
(
	[Ser_OrdComp] ASC,
	[Cod_OrdComp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgOrdCompItem]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgOrdCompItem](
	[Ser_OrdComp] [char](3) NOT NULL,
	[Cod_OrdComp] [char](6) NOT NULL,
	[Sec_OrdComp] [char](3) NOT NULL,
	[Cod_Item] [char](8) NULL,
	[Cod_Comb] [char](3) NULL,
	[Cod_Color] [char](6) NULL,
	[Cod_Talla] [char](10) NULL,
	[Cod_Descuento] [char](3) NULL,
	[Porc_IGV] [numeric](9, 2) NULL,
	[Fec_Entrega_Inicio] [datetime] NULL,
	[Fec_Entrega_Fin] [datetime] NULL,
	[Fec_Cierre] [datetime] NULL,
	[Pre_Unitario] [numeric](13, 5) NULL,
	[Can_Requerida] [numeric](13, 3) NULL,
	[Can_Comprada] [numeric](14, 3) NULL,
	[Can_Recibida] [numeric](14, 3) NULL,
	[Fac_EquiProv] [numeric](13, 6) NULL,
	[Cod_ItemProv] [char](15) NULL,
	[Fec_1RA_Entrega] [datetime] NULL,
	[Fec_Ult_Entrega] [datetime] NULL,
 CONSTRAINT [PK_Lg_OrdCompItem] PRIMARY KEY CLUSTERED 
(
	[Ser_OrdComp] ASC,
	[Cod_OrdComp] ASC,
	[Sec_OrdComp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgProveedor]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgProveedor](
	[Cod_Proveedor] [char](12) NOT NULL,
	[Des_Proveedor] [varchar](70) NOT NULL,
	[Dom_Proveedor] [char](100) NOT NULL,
	[Num_Ruc] [char](24) NULL,
	[Num_Tel] [char](15) NULL,
	[Cod_CondVENT] [char](3) NULL,
	[Cod_ANXO] [char](4) NULL,
	[Cod_Descuento] [char](3) NULL,
	[Origen] [char](1) NULL,
 CONSTRAINT [PK_Lg_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgStocksItem]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgStocksItem](
	[Cod_Almacen] [char](2) NOT NULL,
	[Cod_Item] [char](8) NOT NULL,
	[Cod_Comb] [char](3) NOT NULL,
	[Cod_Color] [char](6) NOT NULL,
	[Cod_Talla] [char](10) NOT NULL,
	[Can_Stock] [numeric](13, 4) NULL,
	[Fec_1er_Entrada] [datetime] NULL,
	[Fec_Ult_Entrada] [datetime] NULL,
	[Fec_1er_Salida] [datetime] NULL,
	[Fec_Ult_Salida] [datetime] NULL,
 CONSTRAINT [PK_Lg_StocksItem] PRIMARY KEY CLUSTERED 
(
	[Cod_Almacen] ASC,
	[Cod_Item] ASC,
	[Cod_Comb] ASC,
	[Cod_Color] ASC,
	[Cod_Talla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgTipMoviAlm]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgTipMoviAlm](
	[Cod_Almacen] [char](2) NOT NULL,
	[Cod_TipMov] [char](3) NOT NULL,
	[Flg_Status] [char](1) NULL,
 CONSTRAINT [PK_LG_TipMoviAlm] PRIMARY KEY CLUSTERED 
(
	[Cod_Almacen] ASC,
	[Cod_TipMov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LgTiposMov]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LgTiposMov](
	[Cod_TipMov] [char](3) NOT NULL,
	[Cod_ClaMov] [char](1) NOT NULL,
	[Des_TipMov] [varchar](80) NOT NULL,
	[Tip_Item] [char](1) NOT NULL,
	[Cod_ClaOrdComp] [char](2) NULL,
	[Tip_Accion] [char](1) NULL,
	[Cod_TipAnx] [char](1) NULL,
	[Cod_Calidad] [char](1) NULL,
 CONSTRAINT [PK_Lg_TiposMov] PRIMARY KEY CLUSTERED 
(
	[Cod_TipMov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TxCliente]    Script Date: 02/03/2019 13:02:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TxCliente](
	[Cod_Cliente_Tex] [char](5) NOT NULL,
	[Nom_Cliente] [varchar](500) NOT NULL,
	[Abr_Cliente] [char](5) NOT NULL,
	[Res_Cliente] [varchar](500) NOT NULL,
	[Num_Ruc] [varchar](20) NOT NULL,
	[Cod_CondVent] [char](3) NOT NULL,
	[Lug_Entrega] [varchar](100) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[EMail] [varchar](500) NOT NULL,
	[Origen] [char](1) NOT NULL,
	[Cod_Via_Domicilio] [char](4) NULL,
	[Nombre_Domicilio] [char](100) NULL,
	[Numero_Domicilio] [char](4) NULL,
	[Interior_Domicilio] [char](4) NULL,
	[Cod_Zona_Domicilio] [char](2) NULL,
	[Nom_Zona_Domicilio] [char](100) NULL,
	[Cod_Ubigeo_Domicilio] [char](6) NULL,
 CONSTRAINT [PK_Tx_Cliente_Textiles] PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente_Tex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY],
 CONSTRAINT [IX_Tx_Cliente] UNIQUE NONCLUSTERED 
(
	[Abr_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CnTiposDocum] ADD  CONSTRAINT [default_CN_TiposDocum_Des_TipDoc]  DEFAULT ('') FOR [Des_TipDoc]
GO
ALTER TABLE [dbo].[CnTiposDocum] ADD  CONSTRAINT [default_CN_TiposDocum_Flg_ClaDoc]  DEFAULT ('') FOR [Flg_ClaDoc]
GO
ALTER TABLE [dbo].[CnTiposDocum] ADD  CONSTRAINT [default_CN_TiposDocum_Flg_Aplica]  DEFAULT ('') FOR [Flg_Aplica]
GO
ALTER TABLE [dbo].[CnTiposVenta] ADD  CONSTRAINT [default_Cn_TiposVenta_Descripcion]  DEFAULT ('') FOR [Descripcion]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Tipanex]  DEFAULT ('') FOR [Cod_Tipanex]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Anxo]  DEFAULT ('') FOR [Cod_Anxo]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_CondVent]  DEFAULT ('') FOR [Cod_CondVent]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Tip_Pago]  DEFAULT ('') FOR [Cod_Tip_Pago]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Moneda]  DEFAULT ('') FOR [Cod_Moneda]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Imp_Neto]  DEFAULT ('') FOR [Imp_Neto]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Imp_IGV]  DEFAULT ('') FOR [Imp_IGV]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Imp_Total]  DEFAULT ('') FOR [Imp_Total]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Tipo_Cambio]  DEFAULT ('') FOR [Tipo_Cambio]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Porc_IGV]  DEFAULT ('') FOR [Porc_IGV]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Usuario_Registro]  DEFAULT ('') FOR [Cod_Usuario_Registro]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Cod_Tipo_Venta]  DEFAULT ('') FOR [Cod_Tipo_Venta]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Por_Descuento]  DEFAULT ('') FOR [Por_Descuento]
GO
ALTER TABLE [dbo].[CnVentas] ADD  CONSTRAINT [default_Cn_Ventas_Num_Corre_Referencia]  DEFAULT ('') FOR [Num_Corre_Referencia]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Num_Corre]  DEFAULT ('') FOR [Num_Corre]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Secuencia]  DEFAULT ('') FOR [Secuencia]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Tipo_Item]  DEFAULT ('') FOR [Tipo_Item]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Codigo_Item]  DEFAULT ('') FOR [Codigo_Item]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Cod_Color]  DEFAULT ('') FOR [Cod_Color]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Descripcion]  DEFAULT ('') FOR [Descripcion]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Cantidad]  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Unidad_Medida]  DEFAULT ('') FOR [Unidad_Medida]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Imp_Unitario]  DEFAULT ((0)) FOR [Imp_Unitario]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Imp_Total]  DEFAULT ((0)) FOR [Imp_Total]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Imp_Descuento]  DEFAULT ((0)) FOR [Imp_Descuento]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Num_Corre_Original_NCND]  DEFAULT ('') FOR [Num_Corre_Original_NCND]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Num_Secuencia_OriginalNCND]  DEFAULT ('') FOR [Num_Secuencia_OriginalNCND]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Cantidad_Item_NC_ND]  DEFAULT ((0)) FOR [Cantidad_Item_NC_ND]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Cod_TipDoc_NCND]  DEFAULT ('') FOR [Cod_TipDoc_NCND]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Ser_Docum_NCND]  DEFAULT ('') FOR [Ser_Docum_NCND]
GO
ALTER TABLE [dbo].[CnVentasItems] ADD  CONSTRAINT [default_Cn_Ventas_Items_Num_Docum_NCND]  DEFAULT ('') FOR [Num_Docum_NCND]
GO
ALTER TABLE [dbo].[LgFamIte] ADD  CONSTRAINT [default_LG_FamIte_des_famitem]  DEFAULT ('') FOR [des_famitem]
GO
ALTER TABLE [dbo].[LgItem] ADD  CONSTRAINT [default_LG_ITEM_Cod_UniMed]  DEFAULT ('') FOR [Cod_UniMed]
GO
ALTER TABLE [dbo].[LgItem] ADD  CONSTRAINT [default_LG_ITEM_Des_Item]  DEFAULT ('') FOR [Des_Item]
GO
ALTER TABLE [dbo].[LgItem] ADD  CONSTRAINT [default_LG_ITEM_Can_PtoReor]  DEFAULT ((0)) FOR [Can_PtoReor]
GO
ALTER TABLE [dbo].[LgItem] ADD  CONSTRAINT [default_LG_ITEM_Can_LotPed]  DEFAULT ((0)) FOR [Can_LotPed]
GO
ALTER TABLE [dbo].[LgItem] ADD  CONSTRAINT [default_LG_ITEM_Flg_Status]  DEFAULT ('') FOR [Flg_Status]
GO
ALTER TABLE [dbo].[LgItemComb] ADD  CONSTRAINT [default_Lg_ItemComb_Des_Comb]  DEFAULT ('') FOR [Des_Comb]
GO
ALTER TABLE [dbo].[LgItemComb] ADD  CONSTRAINT [default_Lg_ItemComb_Observaciones]  DEFAULT ('') FOR [Observaciones]
GO
ALTER TABLE [dbo].[LgItemComb] ADD  CONSTRAINT [default_Lg_ItemComb_Flg_Status]  DEFAULT ('') FOR [Flg_Status]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Cod_Item_Detalle]  DEFAULT ('') FOR [Cod_Item_Detalle]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Cod_Comb_Detalle]  DEFAULT ('') FOR [Cod_Comb_Detalle]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Cod_Color]  DEFAULT ('') FOR [Cod_Color]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Can_Consumo]  DEFAULT ((0)) FOR [Can_Consumo]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Observaciones]  DEFAULT ('') FOR [Observaciones]
GO
ALTER TABLE [dbo].[LgItemCombDet] ADD  CONSTRAINT [defalut_Lg_ItemCombDet_Des_Combdet]  DEFAULT ('') FOR [Des_Combdet]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_Usuario]  DEFAULT ('') FOR [Cod_Usuario]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_Proveedor]  DEFAULT ('') FOR [Cod_Proveedor]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_TipMov]  DEFAULT ('') FOR [Cod_TipMov]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Ser_OrdComp]  DEFAULT ('') FOR [Ser_OrdComp]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_OrdComp]  DEFAULT ('') FOR [Cod_OrdComp]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_Cliente]  DEFAULT ('') FOR [Cod_Cliente]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Ser_Guia_Propia]  DEFAULT ('') FOR [Ser_Guia_Propia]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Nro_Guia_Propia]  DEFAULT ('') FOR [Nro_Guia_Propia]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_MotTra]  DEFAULT ('') FOR [Cod_MotTra]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Ser_Factura]  DEFAULT ('') FOR [Ser_Factura]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Num_Factura]  DEFAULT ('') FOR [Num_Factura]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_CondVent]  DEFAULT ('') FOR [Cod_CondVent]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Num_Corre_Ventas]  DEFAULT ('') FOR [Num_Corre_Ventas]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Cod_Moneda]  DEFAULT ('') FOR [Cod_Moneda]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Ser_Docum_Ventas]  DEFAULT ('') FOR [Ser_Docum_Ventas]
GO
ALTER TABLE [dbo].[LgMoviStk] ADD  CONSTRAINT [default_Lg_MoviStk_Num_Docum_Ventas]  DEFAULT ('') FOR [Num_Docum_Ventas]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_Cod_Item]  DEFAULT ('') FOR [Cod_Item]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_Cod_Comb]  DEFAULT ('') FOR [Cod_Comb]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_Cod_Color]  DEFAULT ('') FOR [Cod_Color]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_Cod_Talla]  DEFAULT ('') FOR [Cod_Talla]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_Can_Movimiento]  DEFAULT ((0)) FOR [Can_Movimiento]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_LG_MOVISTKITEM_Ser_OrdComp]  DEFAULT ('') FOR [Ser_OrdComp]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_LG_MOVISTKITEM_Cod_OrdComp]  DEFAULT ('') FOR [Cod_OrdComp]
GO
ALTER TABLE [dbo].[LgMoviStkItem] ADD  CONSTRAINT [default_LG_MOVISTKITEM_Sec_OrdComp]  DEFAULT ('') FOR [Sec_OrdComp]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [default_Ser_OrdComp]  DEFAULT ('') FOR [Ser_OrdComp]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [default_Cod_OrdComp]  DEFAULT ('') FOR [Cod_OrdComp]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [default_Cod_Proveedor]  DEFAULT ('') FOR [Cod_Proveedor]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Porc_IGV]  DEFAULT ((0)) FOR [Porc_IGV]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Cod_Moneda]  DEFAULT ('') FOR [Cod_Moneda]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Cod_LugEntr]  DEFAULT ('') FOR [Cod_LugEntr]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Observaciones]  DEFAULT ('') FOR [Observaciones]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Cod_StaOrdComp]  DEFAULT ('') FOR [Cod_StaOrdComp]
GO
ALTER TABLE [dbo].[LgOrdComp] ADD  CONSTRAINT [LG_ORDCOMP_default_Cod_ClaOrdComp]  DEFAULT ('') FOR [Cod_ClaOrdComp]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_Item]  DEFAULT ('') FOR [Cod_Item]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_Comb]  DEFAULT ('') FOR [Cod_Comb]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_Color]  DEFAULT ('') FOR [Cod_Color]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_Talla]  DEFAULT ('') FOR [Cod_Talla]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_Descuento]  DEFAULT ('') FOR [Cod_Descuento]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Porc_IGV]  DEFAULT ((0)) FOR [Porc_IGV]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Pre_Unitario]  DEFAULT ((0)) FOR [Pre_Unitario]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Can_Requerida]  DEFAULT ((0)) FOR [Can_Requerida]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Can_Comprada]  DEFAULT ((0)) FOR [Can_Comprada]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Can_Recibida]  DEFAULT ((0)) FOR [Can_Recibida]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Fac_EquiProv]  DEFAULT ((0)) FOR [Fac_EquiProv]
GO
ALTER TABLE [dbo].[LgOrdCompItem] ADD  CONSTRAINT [defaul_Cod_ItemProv]  DEFAULT ('') FOR [Cod_ItemProv]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Des_Proveedor]  DEFAULT ('') FOR [Des_Proveedor]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Dom_Proveedor]  DEFAULT ('') FOR [Dom_Proveedor]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Num_Ruc]  DEFAULT ('') FOR [Num_Ruc]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Num_Tel]  DEFAULT ('') FOR [Num_Tel]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Cod_CondVENT]  DEFAULT ('') FOR [Cod_CondVENT]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Cod_ANXO]  DEFAULT ('') FOR [Cod_ANXO]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Cod_Descuento]  DEFAULT ('') FOR [Cod_Descuento]
GO
ALTER TABLE [dbo].[LgProveedor] ADD  CONSTRAINT [default_Origen]  DEFAULT ('') FOR [Origen]
GO
ALTER TABLE [dbo].[LgStocksItem] ADD  CONSTRAINT [DF_DEFAULT_01]  DEFAULT ('') FOR [Cod_Item]
GO
ALTER TABLE [dbo].[LgStocksItem] ADD  CONSTRAINT [DF_Lg_StocksItem_DEFAULT_01]  DEFAULT ('') FOR [Cod_Comb]
GO
ALTER TABLE [dbo].[LgTiposMov] ADD  CONSTRAINT [DF_FAULT_01]  DEFAULT ('') FOR [Tip_Item]
GO
ALTER TABLE [dbo].[LgTiposMov] ADD  CONSTRAINT [DF_FAULT_02]  DEFAULT ('') FOR [Cod_ClaOrdComp]
GO
ALTER TABLE [dbo].[LgTiposMov] ADD  CONSTRAINT [DF_FAULT_03]  DEFAULT ('') FOR [Tip_Accion]
GO
ALTER TABLE [dbo].[LgTiposMov] ADD  CONSTRAINT [DF_FAULT_04]  DEFAULT ('') FOR [Cod_TipAnx]
GO
ALTER TABLE [dbo].[LgTiposMov] ADD  CONSTRAINT [DF_FAULT_05]  DEFAULT ('') FOR [Cod_Calidad]
GO
ALTER TABLE [dbo].[CnAnexosContables]  WITH CHECK ADD  CONSTRAINT [FK_CN_AnexosContables_Tx_Cliente] FOREIGN KEY([COD_CLIENTE])
REFERENCES [dbo].[TxCliente] ([Cod_Cliente_Tex])
GO
ALTER TABLE [dbo].[CnAnexosContables] CHECK CONSTRAINT [FK_CN_AnexosContables_Tx_Cliente]
GO
ALTER TABLE [dbo].[CnVentas]  WITH CHECK ADD  CONSTRAINT [FK_Cn_Ventas_CN_AnexosContables] FOREIGN KEY([Cod_Tipanex], [Cod_Anxo])
REFERENCES [dbo].[CnAnexosContables] ([Cod_TipAnEX], [Cod_Anxo])
GO
ALTER TABLE [dbo].[CnVentas] CHECK CONSTRAINT [FK_Cn_Ventas_CN_AnexosContables]
GO
ALTER TABLE [dbo].[CnVentas]  WITH CHECK ADD  CONSTRAINT [FK_Cn_Ventas_Cn_Tipos_Venta] FOREIGN KEY([Cod_Tipo_Venta])
REFERENCES [dbo].[CnTiposVenta] ([Cod_Tipo_Venta])
GO
ALTER TABLE [dbo].[CnVentas] CHECK CONSTRAINT [FK_Cn_Ventas_Cn_Tipos_Venta]
GO
ALTER TABLE [dbo].[CnVentas]  WITH CHECK ADD  CONSTRAINT [FK_Cn_Ventas_CN_TiposDocum] FOREIGN KEY([Cod_TipDoc])
REFERENCES [dbo].[CnTiposDocum] ([Cod_TipDoc])
GO
ALTER TABLE [dbo].[CnVentas] CHECK CONSTRAINT [FK_Cn_Ventas_CN_TiposDocum]
GO
ALTER TABLE [dbo].[CnVentasItems]  WITH CHECK ADD  CONSTRAINT [FK_Cn_Ventas_Items_Cn_Ventas] FOREIGN KEY([Num_Corre])
REFERENCES [dbo].[CnVentas] ([Num_Corre])
GO
ALTER TABLE [dbo].[CnVentasItems] CHECK CONSTRAINT [FK_Cn_Ventas_Items_Cn_Ventas]
GO
ALTER TABLE [dbo].[LgItem]  WITH CHECK ADD  CONSTRAINT [FK_Lg_Item_LG_FamIte] FOREIGN KEY([Cod_FamItem])
REFERENCES [dbo].[LgFamIte] ([cod_famitem])
GO
ALTER TABLE [dbo].[LgItem] CHECK CONSTRAINT [FK_Lg_Item_LG_FamIte]
GO
ALTER TABLE [dbo].[LgItemComb]  WITH CHECK ADD  CONSTRAINT [FK_Lg_ItemComb_Lg_Item] FOREIGN KEY([Cod_Item])
REFERENCES [dbo].[LgItem] ([Cod_Item])
GO
ALTER TABLE [dbo].[LgItemComb] CHECK CONSTRAINT [FK_Lg_ItemComb_Lg_Item]
GO
ALTER TABLE [dbo].[LgItemCombDet]  WITH CHECK ADD  CONSTRAINT [FK_Lg_ItemCombDet_Lg_ItemComb] FOREIGN KEY([Cod_Item], [Cod_Comb])
REFERENCES [dbo].[LgItemComb] ([Cod_Item], [Cod_Comb])
GO
ALTER TABLE [dbo].[LgItemCombDet] CHECK CONSTRAINT [FK_Lg_ItemCombDet_Lg_ItemComb]
GO
ALTER TABLE [dbo].[LgMoviStk]  WITH CHECK ADD  CONSTRAINT [FK_Lg_MoviStk_Lg_Almacen] FOREIGN KEY([Cod_Almacen])
REFERENCES [dbo].[LgAlmacen] ([Cod_almacen])
GO
ALTER TABLE [dbo].[LgMoviStk] CHECK CONSTRAINT [FK_Lg_MoviStk_Lg_Almacen]
GO
ALTER TABLE [dbo].[LgMoviStk]  WITH CHECK ADD  CONSTRAINT [FK_Lg_MoviStk_Lg_TiposMov] FOREIGN KEY([Cod_TipMov])
REFERENCES [dbo].[LgTiposMov] ([Cod_TipMov])
GO
ALTER TABLE [dbo].[LgMoviStk] CHECK CONSTRAINT [FK_Lg_MoviStk_Lg_TiposMov]
GO
ALTER TABLE [dbo].[LgMoviStkItem]  WITH CHECK ADD  CONSTRAINT [FK_Lg_MoviStkItem_Lg_Item] FOREIGN KEY([Cod_Item])
REFERENCES [dbo].[LgItem] ([Cod_Item])
GO
ALTER TABLE [dbo].[LgMoviStkItem] CHECK CONSTRAINT [FK_Lg_MoviStkItem_Lg_Item]
GO
ALTER TABLE [dbo].[LgMoviStkItem]  WITH CHECK ADD  CONSTRAINT [FK_Lg_MoviStkItem_Lg_MoviStk] FOREIGN KEY([Cod_Almacen], [Num_MovStk])
REFERENCES [dbo].[LgMoviStk] ([Cod_Almacen], [Num_MovStk])
GO
ALTER TABLE [dbo].[LgMoviStkItem] CHECK CONSTRAINT [FK_Lg_MoviStkItem_Lg_MoviStk]
GO
ALTER TABLE [dbo].[LgOrdComp]  WITH CHECK ADD  CONSTRAINT [FK_Lg_OrdComp_Lg_Proveedor] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[LgProveedor] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[LgOrdComp] CHECK CONSTRAINT [FK_Lg_OrdComp_Lg_Proveedor]
GO
ALTER TABLE [dbo].[LgOrdCompItem]  WITH CHECK ADD  CONSTRAINT [FK_LG_OrdCompItem_Lg_Item] FOREIGN KEY([Cod_Item])
REFERENCES [dbo].[LgItem] ([Cod_Item])
GO
ALTER TABLE [dbo].[LgOrdCompItem] CHECK CONSTRAINT [FK_LG_OrdCompItem_Lg_Item]
GO
ALTER TABLE [dbo].[LgOrdCompItem]  WITH CHECK ADD  CONSTRAINT [FK_LG_OrdCompItem_Lg_OrdComp] FOREIGN KEY([Ser_OrdComp], [Cod_OrdComp])
REFERENCES [dbo].[LgOrdComp] ([Ser_OrdComp], [Cod_OrdComp])
GO
ALTER TABLE [dbo].[LgOrdCompItem] CHECK CONSTRAINT [FK_LG_OrdCompItem_Lg_OrdComp]
GO
ALTER TABLE [dbo].[LgStocksItem]  WITH CHECK ADD  CONSTRAINT [FK_Lg_StocksItem_Lg_Item] FOREIGN KEY([Cod_Item])
REFERENCES [dbo].[LgItem] ([Cod_Item])
GO
ALTER TABLE [dbo].[LgStocksItem] CHECK CONSTRAINT [FK_Lg_StocksItem_Lg_Item]
GO
ALTER TABLE [dbo].[LgTipMoviAlm]  WITH CHECK ADD  CONSTRAINT [FK_LG_TipMoviAlm_Lg_Almacen] FOREIGN KEY([Cod_Almacen])
REFERENCES [dbo].[LgAlmacen] ([Cod_almacen])
GO
ALTER TABLE [dbo].[LgTipMoviAlm] CHECK CONSTRAINT [FK_LG_TipMoviAlm_Lg_Almacen]
GO
ALTER TABLE [dbo].[LgTipMoviAlm]  WITH CHECK ADD  CONSTRAINT [FK_LG_TipMoviAlm_Lg_TiposMov] FOREIGN KEY([Cod_TipMov])
REFERENCES [dbo].[LgTiposMov] ([Cod_TipMov])
GO
ALTER TABLE [dbo].[LgTipMoviAlm] CHECK CONSTRAINT [FK_LG_TipMoviAlm_Lg_TiposMov]
GO
USE [master]
GO
ALTER DATABASE [DXVENTAS] SET  READ_WRITE 
GO
