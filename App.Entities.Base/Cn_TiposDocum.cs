namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cn_TiposDocum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cn_TiposDocum()
        {
            Cn_Ventas = new HashSet<Cn_Ventas>();
        }

        [Key]
        [StringLength(2)]
        public string Cod_TipDoc { get; set; }

        [StringLength(50)]
        public string Des_TipDoc { get; set; }

        [StringLength(1)]
        public string Flg_ClaDoc { get; set; }

        [StringLength(1)]
        public string Flg_Aplica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cn_Ventas> Cn_Ventas { get; set; }
    }
}
