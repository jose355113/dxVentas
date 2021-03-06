namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("CnTiposDocum")]
    public partial class CnTiposDocum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CnTiposDocum()
        {
            CnVentas = new HashSet<CnVentas>();
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
        public virtual ICollection<CnVentas> CnVentas { get; set; }
    }
}
