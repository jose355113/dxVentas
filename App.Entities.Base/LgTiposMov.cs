namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgTiposMov")]
    public partial class LgTiposMov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LgTiposMov()
        {
            LgMoviStk = new HashSet<LgMoviStk>();
            LgTipMoviAlm = new HashSet<LgTipMoviAlm>();
        }

        [Key]
        [StringLength(3)]
        public string Cod_TipMov { get; set; }

        [Required]
        [StringLength(1)]
        public string Cod_ClaMov { get; set; }

        [Required]
        [StringLength(80)]
        public string Des_TipMov { get; set; }

        [Required]
        [StringLength(1)]
        public string Tip_Item { get; set; }

        [StringLength(2)]
        public string Cod_ClaOrdComp { get; set; }

        [StringLength(1)]
        public string Tip_Accion { get; set; }

        [StringLength(1)]
        public string Cod_TipAnx { get; set; }

        [StringLength(1)]
        public string Cod_Calidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgMoviStk> LgMoviStk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LgTipMoviAlm> LgTipMoviAlm { get; set; }
    }
}
