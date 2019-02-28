namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_ItemComb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_ItemComb()
        {
            Lg_ItemCombDet = new HashSet<Lg_ItemCombDet>();
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

        public virtual Lg_Item Lg_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_ItemCombDet> Lg_ItemCombDet { get; set; }
    }
}
