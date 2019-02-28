namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Lg_Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_Proveedor()
        {
            Lg_OrdComp = new HashSet<Lg_OrdComp>();
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
        public virtual ICollection<Lg_OrdComp> Lg_OrdComp { get; set; }
    }
}
