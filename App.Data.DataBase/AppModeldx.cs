namespace App.Data.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppModeldx : DbContext
    {
        public AppModeldx()
            : base("name=AppModeldx")
        {
            Database.SetInitializer<AppModel>(null);
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Cn_AnexosContables> Cn_AnexosContables { get; set; }
        public virtual DbSet<Cn_TiposDocum> Cn_TiposDocum { get; set; }
        public virtual DbSet<Cn_TiposVenta> Cn_TiposVenta { get; set; }
        public virtual DbSet<Cn_Ventas> Cn_Ventas { get; set; }
        public virtual DbSet<Cn_Ventas_Items> Cn_Ventas_Items { get; set; }
        public virtual DbSet<Lg_Almacen> Lg_Almacen { get; set; }
        public virtual DbSet<Lg_FamIte> Lg_FamIte { get; set; }
        public virtual DbSet<Lg_Item> Lg_Item { get; set; }
        public virtual DbSet<Lg_ItemComb> Lg_ItemComb { get; set; }
        public virtual DbSet<Lg_ItemCombDet> Lg_ItemCombDet { get; set; }
        public virtual DbSet<Lg_MoviStk> Lg_MoviStk { get; set; }
        public virtual DbSet<Lg_MoviStkItem> Lg_MoviStkItem { get; set; }
        public virtual DbSet<Lg_OrdComp> Lg_OrdComp { get; set; }
        public virtual DbSet<Lg_OrdCompItem> Lg_OrdCompItem { get; set; }
        public virtual DbSet<Lg_Proveedor> Lg_Proveedor { get; set; }
        public virtual DbSet<Lg_StocksItem> Lg_StocksItem { get; set; }
        public virtual DbSet<Lg_TipMoviAlm> Lg_TipMoviAlm { get; set; }
        public virtual DbSet<Lg_TiposMov> Lg_TiposMov { get; set; }
        public virtual DbSet<Tx_Cliente> Tx_Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_TipAnEX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Anxo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Des_Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Num_Ruc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Dir_Anexo)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_TipIte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Apellido_Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Apellido_Materno)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Nombres)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Pais)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Zona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Codigo_Postal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Contacto_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.COD_CLIENTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_TipoDocIde)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Nro_DocIde)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Ubigeo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Usuario_Baja)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Cod_Motivo_Baja)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Observaciones_Baja)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .Property(e => e.Flg_Activo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_AnexosContables>()
                .HasMany(e => e.Cn_Ventas)
                .WithRequired(e => e.Cn_AnexosContables)
                .HasForeignKey(e => new { e.Cod_Tipanex, e.Cod_Anxo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cn_TiposDocum>()
                .Property(e => e.Cod_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposDocum>()
                .Property(e => e.Des_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposDocum>()
                .Property(e => e.Flg_ClaDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposDocum>()
                .Property(e => e.Flg_Aplica)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposDocum>()
                .HasMany(e => e.Cn_Ventas)
                .WithRequired(e => e.Cn_TiposDocum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cn_TiposVenta>()
                .Property(e => e.Cod_Tipo_Venta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposVenta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_TiposVenta>()
                .HasMany(e => e.Cn_Ventas)
                .WithRequired(e => e.Cn_TiposVenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_TipDoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Ser_Docum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Num_Docum_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Num_Corre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_Tipanex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_Anxo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Imp_Neto)
                .HasPrecision(13, 3);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Imp_IGV)
                .HasPrecision(13, 2);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Imp_Total)
                .HasPrecision(13, 3);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Tipo_Cambio)
                .HasPrecision(10, 3);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_Usuario_Registro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Cod_Tipo_Venta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Por_Descuento)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Cn_Ventas>()
                .Property(e => e.Num_Corre_Referencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Num_Corre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Tipo_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Codigo_Item)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Unidad_Medida)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Imp_Unitario)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Num_Corre_Original_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Cod_TipDoc_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Ser_Docum_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cn_Ventas_Items>()
                .Property(e => e.Num_Docum_NCND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Cod_almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Nom_Almacen)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Tip_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Flg_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Anio_Cierre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Mes_Cierre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .Property(e => e.Tip_Presentacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Almacen>()
                .HasMany(e => e.Lg_MoviStk)
                .WithRequired(e => e.Lg_Almacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_Almacen>()
                .HasMany(e => e.Lg_TipMoviAlm)
                .WithRequired(e => e.Lg_Almacen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_FamIte>()
                .Property(e => e.cod_famitem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_FamIte>()
                .Property(e => e.des_famitem)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_FamIte>()
                .HasMany(e => e.Lg_Item)
                .WithRequired(e => e.Lg_FamIte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_Item>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Item>()
                .Property(e => e.Cod_FamItem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Item>()
                .Property(e => e.Cod_UniMed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Item>()
                .Property(e => e.Des_Item)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Item>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Item>()
                .HasMany(e => e.Lg_ItemComb)
                .WithRequired(e => e.Lg_Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_Item>()
                .HasMany(e => e.Lg_StocksItem)
                .WithRequired(e => e.Lg_Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .Property(e => e.Des_Comb)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemComb>()
                .HasMany(e => e.Lg_ItemCombDet)
                .WithRequired(e => e.Lg_ItemComb)
                .HasForeignKey(e => new { e.Cod_Item, e.Cod_Comb })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Num_Secuencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Cod_Item_Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Cod_Comb_Detalle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Can_Consumo)
                .HasPrecision(12, 5);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_ItemCombDet>()
                .Property(e => e.Des_Combdet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Num_MovStk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_Usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Ser_Guia_Propia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Nro_Guia_Propia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_MotTra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Ser_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Num_Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Num_Corre_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Ser_Docum_Ventas)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .Property(e => e.Num_Docum_Ventas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStk>()
                .HasMany(e => e.Lg_MoviStkItem)
                .WithRequired(e => e.Lg_MoviStk)
                .HasForeignKey(e => new { e.Cod_Almacen, e.Num_MovStk })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Num_MovStk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Num_Secuencia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Can_Movimiento)
                .HasPrecision(13, 4);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_MoviStkItem>()
                .Property(e => e.Sec_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_Moneda)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_LugEntr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_StaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .Property(e => e.Cod_ClaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdComp>()
                .HasMany(e => e.Lg_OrdCompItem)
                .WithRequired(e => e.Lg_OrdComp)
                .HasForeignKey(e => new { e.Ser_OrdComp, e.Cod_OrdComp })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Ser_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Sec_OrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Porc_IGV)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Pre_Unitario)
                .HasPrecision(13, 5);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Can_Requerida)
                .HasPrecision(13, 3);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Can_Comprada)
                .HasPrecision(14, 3);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Can_Recibida)
                .HasPrecision(14, 3);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Fac_EquiProv)
                .HasPrecision(13, 6);

            modelBuilder.Entity<Lg_OrdCompItem>()
                .Property(e => e.Cod_ItemProv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Cod_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Des_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Dom_Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Num_Ruc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Num_Tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Cod_CondVENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Cod_ANXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Cod_Descuento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_Proveedor>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Cod_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Cod_Comb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Cod_Color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Cod_Talla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_StocksItem>()
                .Property(e => e.Can_Stock)
                .HasPrecision(13, 4);

            modelBuilder.Entity<Lg_TipMoviAlm>()
                .Property(e => e.Cod_Almacen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TipMoviAlm>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TipMoviAlm>()
                .Property(e => e.Flg_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Cod_TipMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Cod_ClaMov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Des_TipMov)
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Tip_Item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Cod_ClaOrdComp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Tip_Accion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Cod_TipAnx)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .Property(e => e.Cod_Calidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .HasMany(e => e.Lg_MoviStk)
                .WithRequired(e => e.Lg_TiposMov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lg_TiposMov>()
                .HasMany(e => e.Lg_TipMoviAlm)
                .WithRequired(e => e.Lg_TiposMov)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Cod_Cliente_Tex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Nom_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Abr_Cliente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Res_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Num_Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Cod_CondVent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Lug_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Origen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Cod_Via_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Nombre_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Numero_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Interior_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Cod_Zona_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Nom_Zona_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .Property(e => e.Cod_Ubigeo_Domicilio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tx_Cliente>()
                .HasMany(e => e.Cn_AnexosContables)
                .WithOptional(e => e.Tx_Cliente)
                .HasForeignKey(e => e.COD_CLIENTE);
        }
    }
}
