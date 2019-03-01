namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgProveedor")]
    public partial class LgProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgProveedor()
        {
            LgOrdComp = new HashSet<LgOrdComp>();
        }

        [Key]
        [StringLength(12)]
        public string Cod_Proveedor { get; set; }

        [Required]
        [StringLength(70)]
        public string Des_Proveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string Dom_Proveedor { get; set; }

        [StringLength(24)]
        public string Num_Ruc { get; set; }

        [StringLength(15)]
        public string Num_Tel { get; set; }

        [StringLength(3)]
        public string Cod_CondVENT { get; set; }

        [StringLength(4)]
        public string Cod_ANXO { get; set; }

        [StringLength(3)]
        public string Cod_Descuento { get; set; }

        [StringLength(1)]
        public string Origen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgOrdComp> LgOrdComp { get; set; }
    }
}
