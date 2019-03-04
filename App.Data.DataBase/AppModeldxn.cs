namespace App.Data.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using App.Entities.Base;

    public partial class AppModeldxn : DbContext
    {
        public AppModeldxn()
            : base("name=AppModeldxn")
        {
        }

        public virtual DbSet<CnAnexosContables> CnAnexosContables { get; set; }
        public virtual DbSet<CnTiposDocum> CnTiposDocum { get; set; }
        public virtual DbSet<CnTiposVenta> CnTiposVenta { get; set; }
        public virtual DbSet<CnVentas> CnVentas { get; set; }
        public virtual DbSet<CnVentasItems> CnVentasItems { get; set; }
        public virtual DbSet<LgAlmacen> LgAlmacen { get; set; }
        public virtual DbSet<LgFamIte> LgFamIte { get; set; }
        public virtual DbSet<LgItem> LgItem { get; set; }
        public virtual DbSet<LgItemComb> LgItemComb { get; set; }
        public virtual DbSet<LgItemCombDet> LgItemCombDet { get; set; }
        public virtual DbSet<LgMoviStk> LgMoviStk { get; set; }
        public virtual DbSet<LgMoviStkItem> LgMoviStkItem { get; set; }
        public virtual DbSet<LgOrdComp> LgOrdComp { get; set; }
        public virtual DbSet<LgOrdCompItem> LgOrdCompItem { get; set; }
        public virtual DbSet<LgProveedor> LgProveedor { get; set; }
        public virtual DbSet<LgStocksItem> LgStocksItem { get; set; }
        public virtual DbSet<LgTipMoviAlm> LgTipMoviAlm { get; set; }
        public virtual DbSet<LgTiposMov> LgTiposMov { get; set; }
        public virtual DbSet<TxCliente> TxCliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_TipAnEX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Anxo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Des_Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Num_Ruc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Dir_Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_TipIte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Apellido_Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Apellido_Materno)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Nombres)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Codigo_Postal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Contacto_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.COD_CLIENTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_TipoDocIde)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Nro_DocIde)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Ubigeo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Usuario_Baja)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Cod_Motivo_Baja)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Observaciones_Baja)
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .Property(e => e.Flg_Activo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnAnexosContables>()
                .HasMany(e => e.CnVentas)
                .WithRequired(e => e.CnAnexosContables)
                .HasForeignKey(e => new { e.Cod_Tipanex, e.Cod_Anxo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CnTiposDocum>()
                .Property(e => e.Cod_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposDocum>()
                .Property(e => e.Des_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposDocum>()
                .Property(e => e.Flg_ClaDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposDocum>()
                .Property(e => e.Flg_Aplica)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposDocum>()
                .HasMany(e => e.CnVentas)
                .WithRequired(e => e.CnTiposDocum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CnTiposVenta>()
                .Property(e => e.Cod_Tipo_Venta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposVenta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CnTiposVenta>()
                .HasMany(e => e.CnVentas)
                .WithRequired(e => e.CnTiposVenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Ser_Docum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Num_Docum_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Num_Corre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_Tipanex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_Anxo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Imp_Neto)
                .HasPrecision(13, 3);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Imp_IGV)
                .HasPrecision(13, 2);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Imp_Total)
                .HasPrecision(13, 3);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(10, 3);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_Usuario_Registro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Cod_Tipo_Venta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Por_Descuento)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CnVentas>()
                .Property(e => e.Num_Corre_Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Num_Corre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Tipo_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Codigo_Item)
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Unidad_Medida)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Imp_Unitario)
                .HasPrecision(18, 5);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Num_Corre_Original_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Cod_TipDoc_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Ser_Docum_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CnVentasItems>()
                .Property(e => e.Num_Docum_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Cod_almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Nom_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Tip_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Flg_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Anio_Cierre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Mes_Cierre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .Property(e => e.Tip_Presentacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgAlmacen>()
                .HasMany(e => e.LgMoviStk)
                .WithRequired(e => e.LgAlmacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgAlmacen>()
                .HasMany(e => e.LgTipMoviAlm)
                .WithRequired(e => e.LgAlmacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgFamIte>()
                .Property(e => e.cod_famitem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgFamIte>()
                .Property(e => e.des_famitem)
                .IsUnicode(false);

            modelBuilder.Entity<LgFamIte>()
                .HasMany(e => e.LgItem)
                .WithRequired(e => e.LgFamIte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItem>()
                .Property(e => e.Cod_FamItem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItem>()
                .Property(e => e.Cod_UniMed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItem>()
                .Property(e => e.Des_Item)
                .IsUnicode(false);

            modelBuilder.Entity<LgItem>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItem>()
                .HasMany(e => e.LgItemComb)
                .WithRequired(e => e.LgItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgItem>()
                .HasMany(e => e.LgStocksItem)
                .WithRequired(e => e.LgItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgItemComb>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemComb>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemComb>()
                .Property(e => e.Des_Comb)
                .IsUnicode(false);

            modelBuilder.Entity<LgItemComb>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<LgItemComb>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemComb>()
                .HasMany(e => e.LgItemCombDet)
                .WithRequired(e => e.LgItemComb)
                .HasForeignKey(e => new { e.Cod_Item, e.Cod_Comb })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Num_Secuencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Cod_Item_Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Cod_Comb_Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Can_Consumo)
                .HasPrecision(12, 5);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<LgItemCombDet>()
                .Property(e => e.Des_Combdet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Num_MovStk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_Usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Ser_Guia_Propia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Nro_Guia_Propia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_MotTra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Ser_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Num_Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Num_Corre_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Ser_Docum_Ventas)
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .Property(e => e.Num_Docum_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStk>()
                .HasMany(e => e.LgMoviStkItem)
                .WithRequired(e => e.LgMoviStk)
                .HasForeignKey(e => new { e.Cod_Almacen, e.Num_MovStk })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Num_MovStk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Num_Secuencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Can_Movimiento)
                .HasPrecision(13, 4);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgMoviStkItem>()
                .Property(e => e.Sec_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_LugEntr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_StaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .Property(e => e.Cod_ClaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdComp>()
                .HasMany(e => e.LgOrdCompItem)
                .WithRequired(e => e.LgOrdComp)
                .HasForeignKey(e => new { e.Ser_OrdComp, e.Cod_OrdComp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Sec_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(9, 2);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Pre_Unitario)
                .HasPrecision(13, 5);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Can_Requerida)
                .HasPrecision(13, 3);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Can_Comprada)
                .HasPrecision(14, 3);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Can_Recibida)
                .HasPrecision(14, 3);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Fac_EquiProv)
                .HasPrecision(13, 6);

            modelBuilder.Entity<LgOrdCompItem>()
                .Property(e => e.Cod_ItemProv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Des_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Dom_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Num_Ruc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Num_Tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Cod_CondVENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Cod_ANXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgProveedor>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgStocksItem>()
                .Property(e => e.Can_Stock)
                .HasPrecision(13, 4);

            modelBuilder.Entity<LgTipMoviAlm>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTipMoviAlm>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTipMoviAlm>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Cod_ClaMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Des_TipMov)
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Tip_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Cod_ClaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Tip_Accion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Cod_TipAnx)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .Property(e => e.Cod_Calidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LgTiposMov>()
                .HasMany(e => e.LgMoviStk)
                .WithRequired(e => e.LgTiposMov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LgTiposMov>()
                .HasMany(e => e.LgTipMoviAlm)
                .WithRequired(e => e.LgTiposMov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Cod_Cliente_Tex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Nom_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Abr_Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Res_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Num_Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Lug_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Cod_Via_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Nombre_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Numero_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Interior_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Cod_Zona_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Nom_Zona_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .Property(e => e.Cod_Ubigeo_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TxCliente>()
                .HasMany(e => e.CnAnexosContables)
                .WithOptional(e => e.TxCliente)
                .HasForeignKey(e => e.COD_CLIENTE);
        }
    }
}
