namespace App.Data.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Lg_Item")]
    public partial class Lg_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_Item()
        {
            Lg_ItemComb = new HashSet<Lg_ItemComb>();
            Lg_MoviStkItem = new HashSet<Lg_MoviStkItem>();
            Lg_OrdCompItem = new HashSet<Lg_OrdCompItem>();
            Lg_StocksItem = new HashSet<Lg_StocksItem>();
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

        public virtual Lg_FamIte Lg_FamIte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_ItemComb> Lg_ItemComb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_MoviStkItem> Lg_MoviStkItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_OrdCompItem> Lg_OrdCompItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_StocksItem> Lg_StocksItem { get; set; }
    }
}
