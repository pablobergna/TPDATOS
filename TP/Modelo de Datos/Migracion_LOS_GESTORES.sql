USE [GD1C2014]
GO
/****** Object:  Schema [LOS_GESTORES]    Script Date: 06/17/2014 18:27:41 ******/
CREATE SCHEMA [LOS_GESTORES] AUTHORIZATION [dbo]
GO
/****** Object:  Table [LOS_GESTORES].[Estado]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Domicilio]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Funcion]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Tipo_Doc]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Tipo_Doc](
	[id_tipo_doc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tipo_Doc] PRIMARY KEY CLUSTERED 
(
	[id_tipo_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Tipo_Calificacion]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Rubro]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Rubro](
	[id_rubro] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [codigo_unico] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Visibilidad]    Script Date: 06/17/2014 18:27:44 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [cod_vis_unico] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_estado] [int] NOT NULL,
	[nombre_usuario] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[forzar_cambio] [smallint] NULL,
	[intentos_fallidos] [smallint] NULL,
	[tipo_usuario] [smallint] NULL,
	[descripcion_tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK__Usuario__4E3E04AD00551192] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [nom_usu_unico] UNIQUE NONCLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Rol]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Visibilidades]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Visibilidades]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN VISIBILIDAD
	declare @codigo numeric(18,0), @descripcion  nvarchar(255), @precio numeric(18,2)
	declare @porcentaje numeric(18,2), @cant_dias smallint
	
	-- Lo seteo en 7 por el analisis de la tabla maestra
	set @cant_dias = 7
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE VISIBILIDAD EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare visibilidad_cursor cursor for
	
	select distinct Publicacion_visibilidad_cod, Publicacion_visibilidad_desc, Publicacion_visibilidad_precio,
		Publicacion_visibilidad_porcentaje 
	from gd_esquema.Maestra

	open visibilidad_cursor
	
	fetch next from visibilidad_cursor
	into
	@codigo, @descripcion, @precio, @porcentaje
	
	while @@FETCH_STATUS = 0
		begin
			-- Cargo la visibilidad
			insert into LOS_GESTORES.Visibilidad
			values (@codigo, @descripcion, @precio, @porcentaje, @cant_dias)

			-- Proximo registro de la Maestra
			fetch next from visibilidad_cursor
			into
			@codigo, @descripcion, @precio, @porcentaje
	
		end
	close visibilidad_cursor
	deallocate visibilidad_cursor

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Rubros]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Rubros]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN VISIBILIDAD
	declare @codigo nvarchar(50), @descripcion  nvarchar(255)
	declare @cont smallint = 10000
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE RUBROS EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare rubro_cursor cursor for
	
	select distinct Publicacion_rubro_descripcion
	from gd_esquema.Maestra

	open rubro_cursor
	
	fetch next from rubro_cursor
	into
	@descripcion
	
	while @@FETCH_STATUS = 0
		begin
			-- Genero el codigo
			set @codigo = 'RB_' + CAST(@cont as nvarchar)
			set @cont = @cont + 1
			
			-- Cargo la visibilidad
			insert into LOS_GESTORES.Rubro
			values (@codigo, @descripcion)

			-- Proximo registro de la Maestra
			fetch next from rubro_cursor
			into
			@descripcion
		
		end
	close rubro_cursor
	deallocate rubro_cursor

end
GO
/****** Object:  Table [LOS_GESTORES].[Calificacion]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Calificacion](
	[id_calificacion] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [LOS_GESTORES].[Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
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
	[precio_por_publicar] [numeric](18, 2) NULL,
	[codigo] [numeric](18, 0) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[fecha] [datetime] NULL,
	[fecha_venc] [datetime] NULL,
	[f_preguntas] [smallint] NULL,
	[f_bonificada] [smallint] NULL,
	[f_rendida] [smallint] NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[id_publicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [cod_pub_unico] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Funcion_Rol]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Factura]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Factura](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_estado] [int] NOT NULL,
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
/****** Object:  Table [LOS_GESTORES].[Usuario_Rol]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Usuario_Empresa]    Script Date: 06/17/2014 18:27:44 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [cuit_unico] UNIQUE NONCLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [razon_unica] UNIQUE NONCLUSTERED 
(
	[razon_social] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Cliente]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Usuario_Cliente](
	[id_usuario] [int] NOT NULL,
	[id_domicilio] [int] NOT NULL,
	[id_tipo_doc] [int] NOT NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [tndoc_unico] UNIQUE NONCLUSTERED 
(
	[id_tipo_doc] ASC,
	[nro_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [cuil_unico] ON [LOS_GESTORES].[Usuario_Cliente] 
(
	[cuil] ASC
)
WHERE ([cuil] IS NOT NULL)
WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [tel_unico] ON [LOS_GESTORES].[Usuario_Cliente] 
(
	[telefono] ASC
)
WHERE ([telefono] IS NOT NULL)
WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Usuario_Admin]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Usu_Vis_Gratificacion]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Venta]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_publicacion] [int] NOT NULL,
	[id_usuario_comprador] [int] NOT NULL,
	[id_calificacion] [int] NULL,
	[fecha] [datetime] NULL,
	[cantidad] [smallint] NULL,
	[monto_venta] [numeric](18, 2) NULL,
	[monto_comision] [numeric](18, 2) NULL,
	[f_rendida] [smallint] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Publicacion_Subasta]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Publicacion_Rubro]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Publicacion_Inmediata]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Item_Factura]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Item_Factura](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_publicacion] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[monto] [numeric](18, 2) NULL,
	[cantidad] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Item_Factura_1] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Crea_Usuario_Admin]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Crea_Usuario_Admin]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN USUARIO
	declare @id_estado int, @pass nvarchar(50), @f_cambio smallint
	declare @i_fall smallint, @tipo_usu smallint, @desc_tipo nvarchar(50)
	declare @nombre_usuario nvarchar(50), @id_usu int, @id_rol int
	
	-- el pass es "inicio" en SHA256
	set @pass = 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'
	set @f_cambio = 0 
	set @i_fall = 0 
	set @tipo_usu = 3 
	set @desc_tipo = 'ADMINISTRADOR'
	
    -- Traigo el id del estado "Habilitado"
    select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'	

	-- DECLARO VARIABLES PARA DOMICILIO
	declare @id_dom int
		
	-- DECLARO VARIABLES PARA ADMIN
	declare @nombre_sucursal nvarchar(5), @legajo nvarchar(50)
	set @nombre_sucursal = 'Central'
	set @legajo = 'CA12345'

	-- Seteo el nombre de usuario inicial - nombre y apellido concatenados
	set @nombre_usuario = upper('admin')

	-- Cargo el usuario
	insert into LOS_GESTORES.Usuario
	values (@id_estado, @nombre_usuario, @pass, @f_cambio, @i_fall, @tipo_usu, @desc_tipo)
	-- recupero el ID
	set @id_usu = @@IDENTITY

	-- Cargo el domicilio
	insert into LOS_GESTORES.Domicilio
	values ('Mozart', 1234, 0, null, '1010', 'Almagro', 'CABA', 'admin@utn.edu.ar')
	-- recupero el ID
	set @id_dom = @@IDENTITY
			
	-- Cargo el admin
	insert into LOS_GESTORES.Usuario_Admin
	values (@id_usu, @id_dom, @nombre_sucursal, @legajo)
					
	-- Asocio con el rol admin
	select @id_rol = id_rol from Rol where nombre = 'Administrador'
			
	insert into LOS_GESTORES.Usuario_Rol
	values (@id_usu, @id_rol)


end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Carga_Tablas_Base]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Carga_Tablas_Base]
as
begin
	
	-- Variables para ids de tablas base
	declare @id_habilitado int, @id_publicar int ,@id_comprar int
	declare @id_facturar int, @id_listar int, @id_visualizar int, @id_abmroles int
	declare @id_abmusu int, @id_abmrubro int, @id_abmvisi int
	declare @id_rol_cliente int, @id_rol_empresa int, @id_rol_admin int

	-------------------
	--TABLA DE ESTADO--
	-------------------
	INSERT INTO [LOS_GESTORES].[Estado]
		(descripcion)
     VALUES
           ('Habilitado'),('Inhabilitado'),('Baja'),('Borrador'),('Activa'),
           ('Pausada'),('Finalizada'),('Pendiente'),('Respondida'),('Paga'),('Impaga');
           
    -- Traigo el id del estado "Habilitado"
    select @id_habilitado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'

	----------------
	--TABLA DE ROL--
	----------------
	INSERT INTO [LOS_GESTORES].[ROl]
		(nombre, id_estado)
     VALUES
           ('Cliente',@id_habilitado),('Empresa',@id_habilitado),('Administrador',@id_habilitado);

    -- Traigo el id de los roles
    select @id_rol_cliente = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Cliente'
	select @id_rol_empresa = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Empresa'
	select @id_rol_admin = id_rol from LOS_GESTORES.Rol where Rol.nombre = 'Administrador'

	--------------------
	--TABLA DE FUNCION--
	--------------------
	
	INSERT INTO [LOS_GESTORES].[Funcion]
		(descripcion)
     VALUES
           ('Publicar'),('Comprar'),('Facturar Publicaciones'),('Listar Estadisticas'),
           ('Visualizar Historial'),('ABM Roles'),('ABM Usuarios'),('ABM Rubros'),('ABM Visibilidad');

	-- Traigo los ids de las funciones para asociar
    select @id_publicar = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'Publicar'
    select @id_comprar = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'Comprar'		
    select @id_facturar = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'Facturar Publicaciones'    
    select @id_listar = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'Listar Estadisticas'
    select @id_visualizar = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'Visualizar Historial'
    select @id_abmroles = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'ABM Roles'
    select @id_abmusu = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'ABM Usuarios'
    select @id_abmrubro = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'ABM Rubros'
    select @id_abmvisi = id_funcion from LOS_GESTORES.Funcion where Funcion.descripcion = 'ABM Visibilidad'

	-------------------
	--TABLA DE ESTADO--
	-------------------
	
	INSERT INTO [LOS_GESTORES].[Funcion_Rol]
		(id_funcion, id_rol)
     VALUES
           (@id_publicar,@id_rol_cliente),
           (@id_comprar,@id_rol_cliente),
           (@id_facturar,@id_rol_cliente),
           (@id_visualizar,@id_rol_cliente),

           (@id_facturar,@id_rol_empresa),
           (@id_publicar,@id_rol_empresa),
           (@id_visualizar,@id_rol_empresa),
           (@id_facturar,@id_rol_admin),

           (@id_listar,@id_rol_admin),
           (@id_abmroles,@id_rol_admin),
           (@id_abmusu,@id_rol_admin),
           (@id_abmrubro,@id_rol_admin),
           (@id_abmvisi,@id_rol_admin), 
           (@id_comprar,@id_rol_admin),
           (@id_visualizar,@id_rol_admin),            
           (@id_publicar,@id_rol_admin);

	---------------------
	--TABLA DE TIPO_DOC--
	---------------------
	
	INSERT INTO [LOS_GESTORES].[Tipo_Doc]
           ([descripcion])
     VALUES
           ('DNI'), ('LE'), ('LC'), ('DU');
           
	------------------------------
	--TABLA DE TIPO_CALIFICACION--
	------------------------------
	
	INSERT INTO [LOS_GESTORES].[Tipo_Calificacion]
           ([descripcion])
     VALUES
           ('Positiva'), ('Neutral'), ('Negativa');
                      
end
GO
/****** Object:  Table [LOS_GESTORES].[Pago]    Script Date: 06/17/2014 18:27:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LOS_GESTORES].[Pago](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[tipo_pago] [smallint] NULL,
	[descripcion_tipo] [nvarchar](50) NULL,
	[monto] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [LOS_GESTORES].[Oferta]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Usuarios_Empresa]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Usuarios_Empresa]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN USUARIO
	declare @id_estado int, @pass nvarchar(50), @f_cambio smallint
	declare @i_fall smallint, @tipo_usu smallint, @desc_tipo nvarchar(50)
	declare @nombre_usuario nvarchar(50), @id_usu int, @id_rol int
	
	-- el pass es "inicio" en SHA256
	set @pass = 'e980e67bc2f06641f23e62a14329c883c6e31203df3cf26a4c364df2e5d9d081'
	set @f_cambio = 1 
	set @i_fall = 0 
	set @tipo_usu = 2 
	set @desc_tipo = 'EMPRESA'
	
    -- Traigo el id del estado "Habilitado"
    select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'	

	-- DECLARO VARIABLES PARA DOMICILIO
	declare @ciudad nvarchar(50), @localidad nvarchar(50), @id_dom int
	set @ciudad = 'MIGRADA'
	set @localidad = 'MIGRADA'
		
	-- DECLARO VARIABLES PARA EMPRESA
	declare @nombre_contacto nvarchar(255), @telefono nvarchar(50), @reputacion smallint
	set @nombre_contacto = 'NO ASIGNADO'
	set @telefono = NULL
	set @reputacion = NULL

	-- DECLARO LAS VARIABLES PARA EL CURSOR DE EMPRESA
	declare @razon nvarchar(255), @cuit nvarchar(50),@fecha_cre datetime
	declare @cp nvarchar(50), @depto nvarchar(50)
	declare @calle nvarchar(255), @mail nvarchar(255)
	declare @nro_calle numeric(18,0), @piso numeric(18,0)
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE USUARIOS EMPRESA EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare empresa_cursor cursor for
	
	select distinct Publ_Empresa_Razon_Social, Publ_Empresa_Cuit, Publ_Empresa_Fecha_Creacion,
	Publ_Empresa_Mail, Publ_Empresa_Dom_Calle, Publ_Empresa_Nro_Calle, Publ_Empresa_Piso,
	Publ_Empresa_Depto, Publ_Empresa_Cod_Postal
	from gd_esquema.Maestra
	where Publ_Empresa_Cuit is not null

	open empresa_cursor
	
	fetch next from empresa_cursor
	into
	@razon, @cuit, @fecha_cre, @mail, @calle,@nro_calle, @piso, @depto, @cp
	
	while @@FETCH_STATUS = 0
		begin
			-- Seteo el nombre de usuario inicial - nombre y apellido concatenados
			set @nombre_usuario = upper(@razon)

			-- Cargo el usuario
			insert into LOS_GESTORES.Usuario
			values (@id_estado, @nombre_usuario, @pass, @f_cambio, @i_fall, @tipo_usu, @desc_tipo)
			-- recupero el ID
			set @id_usu = @@IDENTITY

			-- Cargo el domicilio
			insert into LOS_GESTORES.Domicilio
			values (@calle, @nro_calle, @piso, @depto, @cp, @localidad, @ciudad, @mail)
			-- recupero el ID
			set @id_dom = @@IDENTITY
			
			-- Cargo la empresa
			insert into LOS_GESTORES.Usuario_Empresa
			values (@id_usu, @id_dom, @razon, @cuit, @fecha_cre, @nombre_contacto, @telefono, @reputacion)
					
			-- Asocio con el rol cliente
			select @id_rol = id_rol from Rol where nombre = 'Empresa'
			
			insert into LOS_GESTORES.Usuario_Rol
			values (@id_usu, @id_rol)

			-- Proximo registro de la Maestra
			fetch next from empresa_cursor
			into
			@razon, @cuit, @fecha_cre, @mail, @calle,@nro_calle, @piso, @depto, @cp
	
		end
	close empresa_cursor
	deallocate empresa_cursor

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Usuarios_Cliente]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Usuarios_Cliente]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN USUARIO
	declare @id_estado int, @pass nvarchar(50), @f_cambio smallint
	declare @i_fall smallint, @tipo_usu smallint, @desc_tipo nvarchar(50)
	declare @nombre_usuario nvarchar(50), @id_usu int, @id_rol int
	
	-- el pass es "inicio" en SHA256
	set @pass = 'e980e67bc2f06641f23e62a14329c883c6e31203df3cf26a4c364df2e5d9d081'
	set @f_cambio = 1 
	set @i_fall = 0 
	set @tipo_usu = 1 
	set @desc_tipo = 'CLIENTE'
	
    -- Traigo el id del estado "Habilitado"
    select @id_estado = id_estado from LOS_GESTORES.Estado where Estado.descripcion = 'Habilitado'	
	
	-- DECLARO VARIABLES PARA DOMICILIO
	declare @ciudad nvarchar(50), @localidad nvarchar(50), @id_dom int
	set @ciudad = 'MIGRADA'
	set @localidad = 'MIGRADA'
		
	-- DECLARO VARIABLES PARA CLIENTE
	declare @id_tipo_doc int, @cuil nvarchar(50), @telefono nvarchar(50), @reputacion smallint
	set @cuil = NULL
	set @telefono = NULL
	set @reputacion = NULL

	-- Traigo el id del tipo DNI de la tabla de tipo_doc
	select @id_tipo_doc = LOS_GESTORES.Tipo_Doc.id_tipo_doc from LOS_GESTORES.Tipo_Doc where descripcion = 'DNI'

	-- DECLARO LAS VARIABLES PARA EL CURSOR DE CLIENTE
	declare @apellido nvarchar(255), @cp nvarchar(50), @depto nvarchar(50), @dni numeric(18,0)
	declare @calle nvarchar(255), @fecha_nac datetime, @mail nvarchar(255), @nombre nvarchar(255)
	declare @nro_calle numeric(18,0), @piso numeric(18,0)
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE USUARIOS CLIENTE EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare cliente_cursor cursor for
	
	select distinct Publ_Cli_Apeliido, Publ_Cli_Cod_Postal, Publ_Cli_Depto, Publ_Cli_Dni,
		Publ_Cli_Dom_Calle, Publ_Cli_Fecha_Nac, Publ_Cli_Mail, Publ_Cli_Nombre, 
		Publ_Cli_Nro_Calle, Publ_Cli_Piso
	from gd_esquema.Maestra
	where Publ_Cli_Dni is not null

	open cliente_cursor
	
	fetch next from cliente_cursor
	into
	@apellido, @cp, @depto, @dni, @calle, @fecha_nac, @mail, @nombre, @nro_calle, @piso
	
	while @@FETCH_STATUS = 0
		begin
			-- Seteo el nombre de usuario inicial - nombre y apellido concatenados
			set @nombre_usuario = upper(@nombre + @apellido)

			-- Cargo el usuario
			insert into LOS_GESTORES.Usuario
			values (@id_estado, @nombre_usuario, @pass, @f_cambio, @i_fall, @tipo_usu, @desc_tipo)
			-- recupero el ID
			set @id_usu = @@IDENTITY

			-- Cargo el domicilio
			insert into LOS_GESTORES.Domicilio
			values (@calle, @nro_calle, @piso, @depto, @cp, @localidad, @ciudad, @mail)
			-- recupero el ID
			set @id_dom = @@IDENTITY
			
			-- Cargo el cliente
			insert into LOS_GESTORES.Usuario_Cliente
			values (@id_usu, @id_dom, @id_tipo_doc, @dni, @apellido, @nombre, @fecha_nac, @cuil, @telefono, @reputacion)

			-- Asocio con el rol cliente
			select @id_rol = id_rol from Rol where nombre = 'Cliente'
			
			insert into LOS_GESTORES.Usuario_Rol
			values (@id_usu, @id_rol)
					
			-- Proximo registro de la Maestra
			fetch next from cliente_cursor
			into
			@apellido, @cp, @depto, @dni, @calle, @fecha_nac, @mail, @nombre, @nro_calle, @piso

		end
	close cliente_cursor
	deallocate cliente_cursor

end
GO
/****** Object:  Table [LOS_GESTORES].[Pregunta]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Pago_Tarjeta]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  Table [LOS_GESTORES].[Pago_Efectivo]    Script Date: 06/17/2014 18:27:44 ******/
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
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Ventas_Calificaciones]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Ventas_Calificaciones]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN VENTAS
	declare @cod_pub int, @id_pub int, @id_usuario_compra int, @id_calificacion int
	declare @fecha datetime, @cantidad numeric (18,0), @monto_compra numeric(18,2)
	declare	@monto_comision numeric(18,2), @frendida smallint
	set @frendida = 1

	-- DECLARO LAS VARIABLES PARA EL INSERT EN CALIFICACION
	declare @id_tipo_calif int, @codigo numeric (18,0), @cant_estrellas numeric(18,0)
	declare @txt_calif nvarchar(255), @id_venta int

    -- Traigo el id del calificacion "Neutral"
    select @id_tipo_calif = id_tipo_calificacion from LOS_GESTORES.Tipo_Calificacion 
    where descripcion = 'Neutral'	

	-- DECLARO VARIABLES ADICIONALES PARA EL CURSOR
	declare @dni numeric(18,0), @com_porc numeric(18,2)
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE VENTAS Y CALIFICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare venta_cursor cursor for
	
	select Publicacion_cod, Publicacion_Precio, Publicacion_Visibilidad_Porcentaje, Cli_dni, compra_fecha, compra_cantidad, Calificacion_Cant_Estrellas,
		Calificacion_Codigo, Calificacion_Descripcion
	from gd_esquema.Maestra
	where Compra_Fecha is not null
	order by Publicacion_Cod, Cli_Dni, Compra_Fecha, Calificacion_Cant_Estrellas
	
	open venta_cursor
	
	fetch next from venta_cursor
	into
	@cod_pub, @monto_compra, @com_porc, @dni, @fecha, @cantidad, @cant_estrellas, @codigo, @txt_calif
	
	while @@FETCH_STATUS = 0
		begin

			if @cant_estrellas is null
				-- Es una venta
				begin
					-- Traigo el id del usuario comprador
					select @id_usuario_compra = Usuario_Cliente.id_usuario from Usuario_Cliente 
					where nro_doc = @dni

					-- Traigo el id de la publicacion
					select @id_pub = Publicacion.id_publicacion from Publicacion 
					where Publicacion.codigo = @cod_pub
					
					-- Calculo comision
					set @monto_comision = (@cantidad*@monto_compra)*@com_porc
					
					-- Creo la Venta
					insert into LOS_GESTORES.Venta
					values
					(@id_pub, @id_usuario_compra, null, @fecha, @cantidad, @monto_compra * @cantidad,
					@monto_comision, @frendida)
					
					set @id_venta = @@IDENTITY	
						
				end
			else
				-- Es una calificacion
				begin
				
				--Creo la calificacion
				insert into LOS_GESTORES.Calificacion
				values
				(@id_tipo_calif, @id_venta, @codigo, round(@cant_estrellas/2,0), @txt_calif)
				set @id_calificacion = @@IDENTITY
				
				-- Asocio con la venta
				update Venta
				set id_calificacion= @id_calificacion
				where id_venta = @id_venta
				
				end

			-- Proximo registro de la Maestra
			fetch next from venta_cursor
			into
			@cod_pub, @monto_compra, @com_porc, @dni, @fecha, @cantidad, @cant_estrellas, @codigo, @txt_calif
		end
	close venta_cursor
	deallocate venta_cursor

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Publicaciones_Empresa]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Publicaciones_Empresa]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN PUBLICACION
	declare @id_usu int, @id_estado int, @id_visibilidad int, @t_publ smallint
	declare @desc_tipo nvarchar(50), @precio_publicar numeric(18,2)
	declare @codigo numeric(18,0), @desc nvarchar(255) 
	declare @fecha datetime, @fecha_venc datetime
	declare @f_preg smallint, @f_bonif smallint, @f_rend smallint
	declare @stock numeric(18,0), @precio numeric(18,2)

	set @f_bonif = 0
	set @f_preg =0
	set @f_rend = 1

	-- VARIABLES PARA ASOCIACION
	declare @cuit nvarchar(50), @vis_cod numeric(18,0), @id_pub int
	
	-- DECLARO VARIABLES PARA RUBRO
	declare @id_rubro int, @rubro_pub nvarchar(255)

	-- DECLARO VARIABLES PARA ESTADO DE FETCHS
	declare @fs_publ int, @fs_rub int

	--DECLARO UN CURSOR QUE RECORRE LA INFO DE PUBLICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare publ_cursor cursor for
	
	select distinct Publicacion_Cod, Publ_Empresa_Cuit, Publicacion_Visibilidad_Cod,
		Publicacion_Tipo, Publicacion_Precio, Publicacion_Fecha, Publicacion_Fecha_Venc,
		Publicacion_Descripcion, Publicacion_Stock, Publicacion_Visibilidad_Precio,
		Publicacion_Rubro_Descripcion
	from gd_esquema.Maestra
	where Publ_Empresa_Cuit is not null
	
	open publ_cursor
	
	fetch next from publ_cursor
	into
	@codigo, @cuit, @vis_cod, @desc_tipo, @precio, @fecha, @fecha_venc, @desc, @stock, @precio_publicar, 
	@rubro_pub
	
	set @fs_publ = @@FETCH_STATUS
	
	while @fs_publ = 0
		begin
			-- Seteo el estado en Finalizada, el id_suario, el id_visibilidad 
			select @id_estado = id_estado from LOS_GESTORES.Estado where descripcion = 'Finalizada'
			select @id_usu = id_usuario from LOS_GESTORES.Usuario_Empresa
				where cuit = @cuit 
			select @id_visibilidad = id_visibilidad from LOS_GESTORES.Visibilidad
				where codigo = @vis_cod
			
			-- Defino el tipo de publicacion
			if @desc_tipo like 'Compra Inmediata'
				set @t_publ = 1 
			else
				set @t_publ = 2
						
			-- Cargo la publicacion
			insert into LOS_GESTORES.Publicacion
			values (@id_usu, @id_estado, @id_visibilidad, @t_publ, @desc_tipo, @precio_publicar, @codigo,
					@desc, @fecha, @fecha_venc, @f_preg, @f_bonif, @f_rend)
			-- recupero el ID
			set @id_pub = @@IDENTITY

			-- Creo el subtipo
			if @t_publ = 1
				insert into LOS_GESTORES.Publicacion_Inmediata
				values(@id_pub, @stock, @precio)
			else
				insert into LOS_GESTORES.Publicacion_Subasta
				values(@id_pub, @precio)

			--Asocio con el rubro
				select @id_rubro = id_rubro from LOS_GESTORES.Rubro
					where descripcion = @rubro_pub
					
				insert into LOS_GESTORES.Publicacion_Rubro
					values (@id_pub, @id_rubro)
			
			-- Proximo registro de la Maestra
			fetch next from publ_cursor
			into
			@codigo, @cuit, @vis_cod, @desc_tipo, @precio, @fecha, @fecha_venc, @desc, @stock, @precio_publicar,
			@rubro_pub 	
			
			set @fs_publ = @@FETCH_STATUS

		end
	close publ_cursor
	deallocate publ_cursor


end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Publicaciones_Clientes]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Publicaciones_Clientes]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN PUBLICACION
	declare @id_usu int, @id_estado int, @id_visibilidad int, @t_publ smallint
	declare @desc_tipo nvarchar(50), @precio_publicar numeric(18,2)
	declare @codigo numeric(18,0), @desc nvarchar(255) 
	declare @fecha datetime, @fecha_venc datetime
	declare @f_preg smallint, @f_bonif smallint, @f_rend smallint
	declare @stock numeric(18,0), @precio numeric(18,2)

	set @f_bonif = 0
	set @f_preg =0
	set @f_rend = 1

	-- VARIABLES PARA ASOCIACION
	declare @dni numeric(18,8), @vis_cod numeric(18,0), @id_pub int
	
	-- DECLARO VARIABLES PARA RUBRO
	declare @id_rubro int, @rubro_pub nvarchar(255)

	-- DECLARO VARIABLES PARA ESTADO DE FETCHS
	declare @fs_publ int, @fs_rub int

	--DECLARO UN CURSOR QUE RECORRE LA INFO DE PUBLICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare publ_cursor cursor for
	
	select distinct Publicacion_Cod, Publ_Cli_Dni, Publicacion_Visibilidad_Cod,
		Publicacion_Tipo, Publicacion_Precio, Publicacion_Fecha, Publicacion_Fecha_Venc,
		Publicacion_Descripcion, Publicacion_Stock, Publicacion_Visibilidad_Precio,
		Publicacion_Rubro_Descripcion
	from gd_esquema.Maestra
	where Publ_Cli_Dni is not null
	
	open publ_cursor
	
	fetch next from publ_cursor
	into
	@codigo, @dni, @vis_cod, @desc_tipo, @precio, @fecha, @fecha_venc, @desc, @stock, @precio_publicar, 
	@rubro_pub
	
	set @fs_publ = @@FETCH_STATUS
	
	while @fs_publ = 0
		begin
			-- Seteo el estado en Finalizada, el id_suario, el id_visibilidad 
			select @id_estado = id_estado from LOS_GESTORES.Estado where descripcion = 'Finalizada'
			select @id_usu = id_usuario from LOS_GESTORES.Usuario_Cliente 
				where nro_doc = @dni 
			select @id_visibilidad = id_visibilidad from LOS_GESTORES.Visibilidad
				where codigo = @vis_cod
			
			-- Defino el tipo de publicacion
			if @desc_tipo like 'Compra Inmediata'
				set @t_publ = 1 
			else
				set @t_publ = 2
						
			-- Cargo la publicacion
			insert into LOS_GESTORES.Publicacion
			values (@id_usu, @id_estado, @id_visibilidad, @t_publ, @desc_tipo, @precio_publicar, @codigo,
					@desc, @fecha, @fecha_venc, @f_preg, @f_bonif, @f_rend)
			-- recupero el ID
			set @id_pub = @@IDENTITY

			-- Creo el subtipo
			if @t_publ = 1
				insert into LOS_GESTORES.Publicacion_Inmediata
				values(@id_pub, @stock, @precio)
			else
				insert into LOS_GESTORES.Publicacion_Subasta
				values(@id_pub, @precio)

			--Asocio con el rubro
				select @id_rubro = id_rubro from LOS_GESTORES.Rubro
					where descripcion = @rubro_pub
					
				insert into LOS_GESTORES.Publicacion_Rubro
					values (@id_pub, @id_rubro)
			
			-- Proximo registro de la Maestra
			fetch next from publ_cursor
			into
			@codigo, @dni, @vis_cod, @desc_tipo, @precio, @fecha, @fecha_venc, @desc, @stock, @precio_publicar,
			@rubro_pub 	
			
			set @fs_publ = @@FETCH_STATUS

		end
	close publ_cursor
	deallocate publ_cursor


end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Ofertas]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Ofertas]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN VENTAS
	declare @id_pub int, @id_usu_oferta int, @of_fecha datetime, @of_monto numeric(18,2)
	
	-- DECLARO VARIABLES ADICIONALES PARA EL CURSOR
	declare @dni numeric(18,0), @codigo numeric(18,2)
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE VENTAS Y CALIFICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare oferta_cursor cursor for
	
	select Publicacion_cod, Cli_Dni, oferta_fecha, oferta_monto
	from gd_esquema.Maestra
	where Oferta_Fecha is not null	
	
	open oferta_cursor
	
	fetch next from oferta_cursor
	into
	@codigo, @dni, @of_fecha, @of_monto
	
	while @@FETCH_STATUS = 0
		begin

			-- Traigo el id del usuario comprador
			select @id_usu_oferta = Usuario_Cliente.id_usuario from Usuario_Cliente 
			where nro_doc = @dni

			-- Traigo el id de la publicacion
			select @id_pub = Publicacion.id_publicacion from Publicacion 
			where Publicacion.codigo = @codigo
					
			-- Creo la Oferta
			insert into LOS_GESTORES.Oferta
			values
			(@id_pub, @id_usu_oferta, @of_fecha, @of_monto)

			-- Proximo registro de la Maestra
			fetch next from oferta_cursor
			into
			@codigo, @dni, @of_fecha, @of_monto
		end
	close oferta_cursor
	deallocate oferta_cursor

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Facturas_Empresa]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Facturas_Empresa]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN FACTURA
	declare @id_usu int, @id_estado int, @nro_fact numeric(18,0), @fecha_fact datetime
	declare @total numeric(18,2)
		
	-- DECLARO LAS VARIABLES PARA EL INSERT EN ITEM FACTURA
	declare @id_fact int, @id_pub int, @desc_item nvarchar(50)
	declare @monto_item numeric(18,2), @cantidad_item numeric(18,0)
	set @desc_item = 'ITEM MIGRADO' 
		
    -- Traigo el id del estado "Rendida"
    select @id_estado = id_estado from LOS_GESTORES.Estado
    where descripcion = 'Paga'	

	-- DECLARO VARIABLES ADICIONALES PARA EL CURSOR
	declare @pub_cod numeric(18,0), @cuit nvarchar(50), @nro_fact_ant numeric(18,0), @id_pago int
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE VENTAS Y CALIFICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare facturas_cursor cursor for
	
	select Publicacion_Cod, Publ_Empresa_cuit , Factura_Fecha, Factura_Nro, Factura_Total,
		Item_Factura_Cantidad, Item_Factura_Monto
	from gd_esquema.Maestra
	where Publ_Empresa_cuit is not null and Factura_Fecha is not null
	order by Factura_Nro
	
	open facturas_cursor
	
	fetch next from facturas_cursor
	into
	@pub_cod, @cuit, @fecha_fact, @nro_fact, @total, @cantidad_item, @monto_item
	
	while @@FETCH_STATUS = 0
		begin
	
			-- guardo el nro de factura para el corte de control
			set @nro_fact_ant = @nro_fact

			-- Traigo el id del usuario comprador
			select @id_usu = Usuario_Empresa.id_usuario from Usuario_Empresa 
			where cuit = @cuit

			-- Traigo el id de la publicacion
			select @id_pub = Publicacion.id_publicacion from Publicacion 
			where Publicacion.codigo = @pub_cod

			
			while @@FETCH_STATUS = 0 and @nro_fact_ant = @nro_fact
				begin
					-- Creo la Factura
					insert into LOS_GESTORES.Factura
					values
					(@id_estado, @id_usu, @nro_fact, @fecha_fact, @total)
					
					set @id_fact = @@IDENTITY	

					-- Creo el item de la factura
					insert into LOS_GESTORES.Item_Factura
					values
					(@id_fact, @id_pub, @desc_item, @monto_item, @cantidad_item)
					
					-- Creo el pago 
					insert into LOS_GESTORES.Pago
					values
					(@id_fact, 1, 'EFECTIVO', @total)
					
					set @id_pago = @@IDENTITY
					
					-- Creo el Pago efectivo
					insert into LOS_GESTORES.Pago_Efectivo
					values
					(@id_pago, 'PESOS ARGENTINOS', 'PAGO MIGRADO')

					-- Proximo registro de la Maestra
					fetch next from facturas_cursor
					into
					@pub_cod, @cuit, @fecha_fact, @nro_fact, @total, @cantidad_item, @monto_item
				end
		end
	close facturas_cursor
	deallocate facturas_cursor

end
GO
/****** Object:  StoredProcedure [LOS_GESTORES].[Migra_Facturas_Cliente]    Script Date: 06/17/2014 18:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [LOS_GESTORES].[Migra_Facturas_Cliente]
as
begin

	-- DECLARO LAS VARIABLES PARA EL INSERT EN FACTURA
	declare @id_usu int, @id_estado int, @nro_fact numeric(18,0), @fecha_fact datetime
	declare @total numeric(18,2)
		
	-- DECLARO LAS VARIABLES PARA EL INSERT EN ITEM FACTURA
	declare @id_fact int, @id_pub int, @desc_item nvarchar(50)
	declare @monto_item numeric(18,2), @cantidad_item numeric(18,0)
	set @desc_item = 'ITEM MIGRADO' 
		
    -- Traigo el id del estado "Rendida"
    select @id_estado = id_estado from LOS_GESTORES.Estado
    where descripcion = 'Paga'	

	-- DECLARO VARIABLES ADICIONALES PARA EL CURSOR
	declare @pub_cod numeric(18,0), @dni numeric(18,0), @nro_fact_ant numeric(18,0), @id_pago int
	
	--DECLARO UN CURSOR QUE RECORRE LA INFO DE VENTAS Y CALIFICACIONES EN LA MAESTRA
	--EN BASE A ESA INFORMACION ARMO EL REGISTRO DEL NUEVO MODELO
	declare facturas_cursor cursor for
	
	select Publicacion_Cod, Publ_Cli_Dni, Factura_Fecha, Factura_Nro, Factura_Total,
		Item_Factura_Cantidad, Item_Factura_Monto
	from gd_esquema.Maestra
	where Publ_Cli_Dni is not null and Factura_Fecha is not null
	order by Factura_Nro
	
	open facturas_cursor
	
	fetch next from facturas_cursor
	into
	@pub_cod, @dni, @fecha_fact, @nro_fact, @total, @cantidad_item, @monto_item
	
	while @@FETCH_STATUS = 0
		begin
	
			-- guardo el nro de factura para el corte de control
			set @nro_fact_ant = @nro_fact

			-- Traigo el id del usuario comprador
			select @id_usu = Usuario_Cliente.id_usuario from Usuario_Cliente 
			where nro_doc = @dni

			-- Traigo el id de la publicacion
			select @id_pub = Publicacion.id_publicacion from Publicacion 
			where Publicacion.codigo = @pub_cod

			
			while @@FETCH_STATUS = 0 and @nro_fact_ant = @nro_fact
				begin
					-- Creo la Factura
					insert into LOS_GESTORES.Factura
					values
					(@id_estado, @id_usu, @nro_fact, @fecha_fact, @total)
					
					set @id_fact = @@IDENTITY	

					-- Creo el item de la factura
					insert into LOS_GESTORES.Item_Factura
					values
					(@id_fact, @id_pub, @desc_item, @monto_item, @cantidad_item)
					
					-- Creo el pago 
					insert into LOS_GESTORES.Pago
					values
					(@id_fact, 1, 'EFECTIVO', @total)
					
					set @id_pago = @@IDENTITY
					
					-- Creo el Pago efectivo
					insert into LOS_GESTORES.Pago_Efectivo
					values
					(@id_pago, 'PESOS ARGENTINOS', 'PAGO MIGRADO')

					-- Proximo registro de la Maestra
					fetch next from facturas_cursor
					into
					@pub_cod, @dni, @fecha_fact, @nro_fact, @total, @cantidad_item, @monto_item
				end
		end
	close facturas_cursor
	deallocate facturas_cursor

end
GO
/****** Object:  ForeignKey [FK_Calificacion_Tipo_Calificacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Calificacion]  WITH CHECK ADD  CONSTRAINT [FK_Calificacion_Tipo_Calificacion] FOREIGN KEY([id_tipo_calificacion])
REFERENCES [LOS_GESTORES].[Tipo_Calificacion] ([id_tipo_calificacion])
GO
ALTER TABLE [LOS_GESTORES].[Calificacion] CHECK CONSTRAINT [FK_Calificacion_Tipo_Calificacion]
GO
/****** Object:  ForeignKey [FK_Factura_Estado]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Estado] FOREIGN KEY([id_estado])
REFERENCES [LOS_GESTORES].[Estado] ([id_estado])
GO
ALTER TABLE [LOS_GESTORES].[Factura] CHECK CONSTRAINT [FK_Factura_Estado]
GO
/****** Object:  ForeignKey [FK_Factura_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Factura] CHECK CONSTRAINT [FK_Factura_Usuario]
GO
/****** Object:  ForeignKey [FK_Funcion_Rol_Funcion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Funcion_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Rol_Funcion] FOREIGN KEY([id_funcion])
REFERENCES [LOS_GESTORES].[Funcion] ([id_funcion])
GO
ALTER TABLE [LOS_GESTORES].[Funcion_Rol] CHECK CONSTRAINT [FK_Funcion_Rol_Funcion]
GO
/****** Object:  ForeignKey [FK_Funcion_Rol_Rol]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Funcion_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Rol_Rol] FOREIGN KEY([id_rol])
REFERENCES [LOS_GESTORES].[Rol] ([id_rol])
GO
ALTER TABLE [LOS_GESTORES].[Funcion_Rol] CHECK CONSTRAINT [FK_Funcion_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Item_Factura_Factura]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Factura] FOREIGN KEY([id_factura])
REFERENCES [LOS_GESTORES].[Factura] ([id_factura])
GO
ALTER TABLE [LOS_GESTORES].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Item_Factura_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Oferta_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Usuario] FOREIGN KEY([id_usuario_oferta])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Oferta] CHECK CONSTRAINT [FK_Oferta_Usuario]
GO
/****** Object:  ForeignKey [FK_Pago_Factura]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Factura] FOREIGN KEY([id_factura])
REFERENCES [LOS_GESTORES].[Factura] ([id_factura])
GO
ALTER TABLE [LOS_GESTORES].[Pago] CHECK CONSTRAINT [FK_Pago_Factura]
GO
/****** Object:  ForeignKey [FK_Pago_Efectivo_Pago]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pago_Efectivo]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Efectivo_Pago] FOREIGN KEY([id_pago])
REFERENCES [LOS_GESTORES].[Pago] ([id_pago])
GO
ALTER TABLE [LOS_GESTORES].[Pago_Efectivo] CHECK CONSTRAINT [FK_Pago_Efectivo_Pago]
GO
/****** Object:  ForeignKey [FK_Pago_Tarjeta_Pago]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pago_Tarjeta]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Tarjeta_Pago] FOREIGN KEY([id_pago])
REFERENCES [LOS_GESTORES].[Pago] ([id_pago])
GO
ALTER TABLE [LOS_GESTORES].[Pago_Tarjeta] CHECK CONSTRAINT [FK_Pago_Tarjeta_Pago]
GO
/****** Object:  ForeignKey [FK_Pregunta_Estado]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_Estado] FOREIGN KEY([id_estado])
REFERENCES [LOS_GESTORES].[Estado] ([id_estado])
GO
ALTER TABLE [LOS_GESTORES].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_Estado]
GO
/****** Object:  ForeignKey [FK_Pregunta_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Pregunta_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Pregunta] CHECK CONSTRAINT [FK_Pregunta_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Estado]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([id_estado])
REFERENCES [LOS_GESTORES].[Estado] ([id_estado])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]
GO
/****** Object:  ForeignKey [FK_Publicacion_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([id_visibilidad])
REFERENCES [LOS_GESTORES].[Visibilidad] ([id_visibilidad])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Publicacion_Inmediata_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion_Inmediata]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Inmediata_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion_Inmediata] CHECK CONSTRAINT [FK_Publicacion_Inmediata_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Rubro]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Rubro] FOREIGN KEY([id_rubro])
REFERENCES [LOS_GESTORES].[Rubro] ([id_rubro])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Rubro]
GO
/****** Object:  ForeignKey [FK_Publicacion_Subasta_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Publicacion_Subasta]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Subasta_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Publicacion_Subasta] CHECK CONSTRAINT [FK_Publicacion_Subasta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Rol_Estado]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Rol]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Estado] FOREIGN KEY([id_estado])
REFERENCES [LOS_GESTORES].[Estado] ([id_estado])
GO
ALTER TABLE [LOS_GESTORES].[Rol] CHECK CONSTRAINT [FK_Rol_Estado]
GO
/****** Object:  ForeignKey [FK_Usu_Vis_Gratificacion_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usu_Vis_Gratificacion]  WITH CHECK ADD  CONSTRAINT [FK_Usu_Vis_Gratificacion_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Usu_Vis_Gratificacion] CHECK CONSTRAINT [FK_Usu_Vis_Gratificacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Usu_Vis_Gratificacion_Visibilidad]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usu_Vis_Gratificacion]  WITH CHECK ADD  CONSTRAINT [FK_Usu_Vis_Gratificacion_Visibilidad] FOREIGN KEY([id_visibilidad])
REFERENCES [LOS_GESTORES].[Visibilidad] ([id_visibilidad])
GO
ALTER TABLE [LOS_GESTORES].[Usu_Vis_Gratificacion] CHECK CONSTRAINT [FK_Usu_Vis_Gratificacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Usuario_Estado]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Estado] FOREIGN KEY([id_estado])
REFERENCES [LOS_GESTORES].[Estado] ([id_estado])
GO
ALTER TABLE [LOS_GESTORES].[Usuario] CHECK CONSTRAINT [FK_Usuario_Estado]
GO
/****** Object:  ForeignKey [FK_Usuario_Admin_Domicilio]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Admin]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Admin_Domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [LOS_GESTORES].[Domicilio] ([id_domicilio])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Admin] CHECK CONSTRAINT [FK_Usuario_Admin_Domicilio]
GO
/****** Object:  ForeignKey [FK_Usuario_Admin_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Admin]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Admin_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Admin] CHECK CONSTRAINT [FK_Usuario_Admin_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente_Domicilio]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Cliente_Domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [LOS_GESTORES].[Domicilio] ([id_domicilio])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente] CHECK CONSTRAINT [FK_Usuario_Cliente_Domicilio]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente_Tipo_Doc]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Cliente_Tipo_Doc] FOREIGN KEY([id_tipo_doc])
REFERENCES [LOS_GESTORES].[Tipo_Doc] ([id_tipo_doc])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente] CHECK CONSTRAINT [FK_Usuario_Cliente_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Usuario_Cliente_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Cliente_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Cliente] CHECK CONSTRAINT [FK_Usuario_Cliente_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_Empresa_Domicilio]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empresa_Domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [LOS_GESTORES].[Domicilio] ([id_domicilio])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Empresa] CHECK CONSTRAINT [FK_Usuario_Empresa_Domicilio]
GO
/****** Object:  ForeignKey [FK_Usuario_Empresa_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empresa_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Empresa] CHECK CONSTRAINT [FK_Usuario_Empresa_Usuario]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Rol]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([id_rol])
REFERENCES [LOS_GESTORES].[Rol] ([id_rol])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuario]
GO
/****** Object:  ForeignKey [FK_Venta_Calificacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Calificacion] FOREIGN KEY([id_calificacion])
REFERENCES [LOS_GESTORES].[Calificacion] ([id_calificacion])
GO
ALTER TABLE [LOS_GESTORES].[Venta] CHECK CONSTRAINT [FK_Venta_Calificacion]
GO
/****** Object:  ForeignKey [FK_Venta_Publicacion]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Publicacion] FOREIGN KEY([id_publicacion])
REFERENCES [LOS_GESTORES].[Publicacion] ([id_publicacion])
GO
ALTER TABLE [LOS_GESTORES].[Venta] CHECK CONSTRAINT [FK_Venta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Venta_Usuario]    Script Date: 06/17/2014 18:27:44 ******/
ALTER TABLE [LOS_GESTORES].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([id_usuario_comprador])
REFERENCES [LOS_GESTORES].[Usuario] ([id_usuario])
GO
ALTER TABLE [LOS_GESTORES].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO


exec LOS_GESTORES.Carga_Tablas_Base

exec LOS_GESTORES.Crea_Usuario_Admin

exec LOS_GESTORES.Migra_Usuarios_Cliente

exec LOS_GESTORES.Migra_Usuarios_Empresa

exec LOS_GESTORES.Migra_Visibilidades

exec LOS_GESTORES.Migra_Rubros

exec LOS_GESTORES.Migra_Publicaciones_Clientes

exec LOS_GESTORES.Migra_Publicaciones_Empresa

exec LOS_GESTORES.migra_ventas_calificaciones

exec LOS_GESTORES.migra_ofertas

exec LOS_GESTORES.Migra_Facturas_Cliente

exec LOS_GESTORES.Migra_Facturas_Empresa
