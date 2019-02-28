namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_TiposMov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_TiposMov()
        {
            Lg_MoviStk = new HashSet<Lg_MoviStk>();
            Lg_TipMoviAlm = new HashSet<Lg_TipMoviAlm>();
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
        public virtual ICollection<Lg_MoviStk> Lg_MoviStk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_TipMoviAlm> Lg_TipMoviAlm { get; set; }
    }
}
