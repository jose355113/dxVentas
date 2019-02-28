namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_OrdComp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_OrdComp()
        {
            Lg_OrdCompItem = new HashSet<Lg_OrdCompItem>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string Ser_OrdComp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Cod_OrdComp { get; set; }

        [StringLength(12)]
        public string Cod_Proveedor { get; set; }

        [StringLength(3)]
        public string Cod_CondVent { get; set; }

        [StringLength(3)]
        public string Cod_Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Porc_IGV { get; set; }

        [StringLength(3)]
        public string Cod_Moneda { get; set; }

        [StringLength(3)]
        public string Cod_LugEntr { get; set; }

        [StringLength(2000)]
        public string Observaciones { get; set; }

        [StringLength(1)]
        public string Cod_StaOrdComp { get; set; }

        public DateTime? Fec_Creacion { get; set; }

        public DateTime? Fec_1raEmision { get; set; }

        public DateTime? Fec_UltaEmision { get; set; }

        public DateTime? Fec_1raAutoriz { get; set; }

        public DateTime? Fec_UltAutoriz { get; set; }

        public DateTime? Fec_Cierre { get; set; }

        [StringLength(2)]
        public string Cod_ClaOrdComp { get; set; }

        public DateTime? Fec_Entrega_Inicio { get; set; }

        public DateTime? Fec_Entrega_Fin { get; set; }

        public virtual Lg_Proveedor Lg_Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_OrdCompItem> Lg_OrdCompItem { get; set; }
    }
}
