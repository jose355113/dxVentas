namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("LgFamIte")]
    public partial class LgFamIte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgFamIte()
        {
            LgItem = new HashSet<LgItem>();
        }

        [Key]
        [StringLength(2)]
        public string cod_famitem { get; set; }

        [Required]
        [StringLength(500)]
        public string des_famitem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgItem> LgItem { get; set; }
    }
}
