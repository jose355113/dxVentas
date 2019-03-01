namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgItemComb")]
    public partial class LgItemComb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgItemComb()
        {
            LgItemCombDet = new HashSet<LgItemCombDet>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Cod_Item { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Cod_Comb { get; set; }

        [Required]
        [StringLength(500)]
        public string Des_Comb { get; set; }

        [Required]
        [StringLength(100)]
        public string Observaciones { get; set; }

        [StringLength(1)]
        public string Flg_Status { get; set; }

        public virtual LgItem LgItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgItemCombDet> LgItemCombDet { get; set; }
    }
}
