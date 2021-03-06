USE [GD1C2014]
GO
/****** Object:  Schema [LOS_GESTORES]    Script Date: 05/28/2014 19:42:22 ******/
CREATE SCHEMA [LOS_GESTORES] AUTHORIZATION [dbo]
GO
/****** Object:  Table [LOS_GESTORES].[Visibilidad]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Visibilidad](
	[id_visibilidad] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[precio] [numeric](18, 2) NULL,
	[porcentaje] [numeric](18, 2) NULL,
	[cant_dias] [smallint] NULL,
 CONSTRAINT [PK_Visibilidad] PRIMARY KEY CLUSTERED 
(
	[id_visibilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Venta]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_publicacion] [int] NOT NULL,
	[id_usuario_comprador] [int] NOT NULL,
	[id_calificacion] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[cantidad] [smallint] NULL,
	[monto_comision] [numeric](18, 2) NULL,
	[f_rendida] [smallint] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Rol]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario_Rol](
	[id_usuario] [int] NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Rol] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Empresa]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario_Empresa](
	[id_usuario] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[razon_social] [nvarchar](255) NULL,
	[cuit] [nvarchar](50) NULL,
	[fecha_creacion] [datetime] NULL,
	[nombre_contacto] [nvarchar](255) NULL,
	[telefono] [nvarchar](50) NULL,
	[reputacion] [smallint] NULL,
 CONSTRAINT [PK_Usuario_Empresa] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Cliente]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario_Cliente](
	[id_usuario] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[tipo_doc] [smallint] NULL,
	[nro_doc] [numeric](18, 0) NULL,
	[apellido] [nvarchar](255) NULL,
	[nombre] [nvarchar](255) NULL,
	[fecha_nac] [datetime] NULL,
	[cuil] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
	[reputacion] [smallint] NULL,
 CONSTRAINT [PK_Usuario_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Admin]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario_Admin](
	[id_usuario] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[nombre_sucursal] [nvarchar](50) NULL,
	[legajo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario_Admin] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_estado] [int] NOT NULL,
	[password] [varchar](50) NULL,
	[forzar_cambio] [smallint] NULL,
	[intentos_fallidos] [smallint] NULL,
	[tipo_usuario] [smallint] NULL,
	[descripcion_tipo] [varchar](50) NULL,
 CONSTRAINT [PK__Usuario__4E3E04AD00551192] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [LOS_GESTORES].[Usu_Vis_Gratificacion]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usu_Vis_Gratificacion](
	[id_usuario] [int] NOT NULL,
	[id_visibilidad] [int] NOT NULL,
	[contador] [smallint] NULL,
 CONSTRAINT [PK_Usu_Vis_Gratificacion] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_visibilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Tipo_Calificacion]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Tipo_Calificacion](
	[id_tipo_calificacion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tipo_Calificacion] PRIMARY KEY CLUSTERED 
(
	[id_tipo_calificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Rubro]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Rubro](
	[id_rubro] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Rol]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[id_estado] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Publicacion_Subasta]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Publicacion_Subasta](
	[id_publicacion] [int] NOT NULL,
	[precio_inicial] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Publicacion_Subasta] PRIMARY KEY CLUSTERED 
(
	[id_publicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Publicacion_Rubro]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Publicacion_Rubro](
	[id_publicacion] [int] NOT NULL,
	[id_rubro] [int] NOT NULL,
 CONSTRAINT [PK_Publicacion_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_publicacion] ASC,
	[id_rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Publicacion_Inmediata]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Publicacion_Inmediata](
	[id_publicacion] [int] NOT NULL,
	[stock] [numeric](18, 0) NULL,
	[precio] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Publicacion_Inmediata] PRIMARY KEY CLUSTERED 
(
	[id_publicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Publicacion]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Publicacion](
	[id_publicacion] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[id_visibilidad] [int] NOT NULL,
	[tipo_publicacion] [smallint] NULL,
	[descripcion_tipo] [nvarchar](50) NULL,
	[precio_publicacion] [numeric](18, 2) NULL,
	[codigo] [numeric](18, 0) NULL,
	[descripcion] [nvarchar](255) NULL,
	[fecha] [datetime] NULL,
	[fecha_venc] [datetime] NULL,
	[f_preguntas] [smallint] NULL,
	[f_bonificada] [smallint] NULL,
	[f_rendida] [smallint] NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[id_publicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Pregunta]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Pregunta](
	[id_pregunta] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_publicacion] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[txt_pregunta] [nvarchar](255) NULL,
	[txt_respuesta] [nvarchar](255) NULL,
	[fecha_pregunta] [datetime] NULL,
	[fecha_respuesta] [datetime] NULL,
 CONSTRAINT [PK_Pregunta_1] PRIMARY KEY CLUSTERED 
(
	[id_pregunta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Pago_Tarjeta]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Pago_Tarjeta](
	[id_pago] [int] NOT NULL,
	[nro_tarjeta] [nvarchar](50) NULL,
	[banco] [nvarchar](255) NULL,
	[tarjeta_validez] [datetime] NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pago_Tarjeta] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Pago_Efectivo]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Pago_Efectivo](
	[id_pago] [int] NOT NULL,
	[moneda] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pago_Efectivo] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Pago]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Pago](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[tipo_pago] [smallint] NULL,
	[descripcion_tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Oferta]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Oferta](
	[id_oferta] [int] IDENTITY(1,1) NOT NULL,
	[id_publicacion] [int] NOT NULL,
	[id_usuario_oferta] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[monto] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Oferta] PRIMARY KEY CLUSTERED 
(
	[id_oferta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Item_Factura]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Item_Factura](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[tipo_producto] [smallint] NULL,
	[descripcion_tipo] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[monto] [numeric](18, 2) NULL,
	[cantidad] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Item_Factura_1] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Funcion_Rol]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Funcion_Rol](
	[id_rol] [int] NOT NULL,
	[id_funcion] [int] NOT NULL,
 CONSTRAINT [PK_Funcion_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC,
	[id_funcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Funcion]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Funcion](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Factura]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_pago] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[nro] [numeric](18, 0) NULL,
	[fecha] [datetime] NULL,
	[total] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Estado]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Domicilio]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Domicilio](
	[id_domicilio] [int] IDENTITY(1,1) NOT NULL,
	[calle] [nvarchar](255) NULL,
	[nro_calle] [numeric](18, 0) NULL,
	[piso] [numeric](18, 0) NULL,
	[depto] [nvarchar](50) NULL,
	[codigo_postal] [nvarchar](50) NULL,
	[localidad] [nvarchar](50) NULL,
	[ciudad] [nvarchar](50) NULL,
	[mail] [nvarchar](50) NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[id_domicilio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Calificacion]    Script Date: 05/28/2014 19:42:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Calificacion](
	[id_calificacion] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario_comprador] [int] NOT NULL,
	[id_tipo_calificacion] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[codigo] [numeric](18, 0) NULL,
	[cant_estrellas] [smallint] NULL,
	[txt_calificacion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[id_calificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
