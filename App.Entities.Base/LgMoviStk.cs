namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgMoviStk")]
    public partial class LgMoviStk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgMoviStk()
        {
            LgMoviStkItem = new HashSet<LgMoviStkItem>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cod_Almacen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Num_MovStk { get; set; }

        public DateTime Fec_Creacion { get; set; }

        public DateTime Fec_MovStk { get; set; }

        [StringLength(50)]
        public string Cod_Usuario { get; set; }

        [StringLength(12)]
        public string Cod_Proveedor { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_TipMov { get; set; }

        [StringLength(3)]
        public string Ser_OrdComp { get; set; }

        [StringLength(6)]
        public string Cod_OrdComp { get; set; }

        [StringLength(5)]
        public string Cod_Cliente { get; set; }

        [StringLength(3)]
        public string Ser_Guia_Propia { get; set; }

        [StringLength(8)]
        public string Nro_Guia_Propia { get; set; }

        [StringLength(3)]
        public string Cod_MotTra { get; set; }

        [StringLength(4)]
        public string Ser_Factura { get; set; }

        [StringLength(8)]
        public string Num_Factura { get; set; }

        [StringLength(3)]
        public string Cod_CondVent { get; set; }

        [StringLength(12)]
        public string Num_Corre_Ventas { get; set; }

        public DateTime? fecha_facturacion { get; set; }

        [StringLength(3)]
        public string Cod_Moneda { get; set; }

        [StringLength(4)]
        public string Ser_Docum_Ventas { get; set; }

        [StringLength(15)]
        public string Num_Docum_Ventas { get; set; }

        public virtual LgAlmacen LgAlmacen { get; set; }

        public virtual LgTiposMov LgTiposMov { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgMoviStkItem> LgMoviStkItem { get; set; }
    }
}
