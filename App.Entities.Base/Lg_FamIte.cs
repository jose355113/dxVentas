namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class Lg_FamIte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_FamIte()
        {
            Lg_Item = new HashSet<Lg_Item>();
        }

        [Key]
        [StringLength(2)]
        public string cod_famitem { get; set; }

        [Required]
        [StringLength(500)]
        public string des_famitem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_Item> Lg_Item { get; set; }
    }
}
