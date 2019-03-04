namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("LgItem")]
    public partial class LgItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgItem()
        {
            LgItemComb = new HashSet<LgItemComb>();
            LgMoviStkItem = new HashSet<LgMoviStkItem>();
            LgOrdCompItem = new HashSet<LgOrdCompItem>();
            LgStocksItem = new HashSet<LgStocksItem>();
        }

        [Key]
        [StringLength(8)]
        public string Cod_Item { get; set; }

        [Required]
        [StringLength(2)]
        public string Cod_FamItem { get; set; }

        [Required]
        [StringLength(2)]
        public string Cod_UniMed { get; set; }

        [StringLength(200)]
        public string Des_Item { get; set; }

        public DateTime Fec_Creacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Can_PtoReor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Can_LotPed { get; set; }

        [Required]
        [StringLength(1)]
        public string Flg_Status { get; set; }

        public virtual LgFamIte LgFamIte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgItemComb> LgItemComb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgMoviStkItem> LgMoviStkItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgOrdCompItem> LgOrdCompItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgStocksItem> LgStocksItem { get; set; }
    }
}
