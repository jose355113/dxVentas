namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_Almacen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lg_Almacen()
        {
            Lg_MoviStk = new HashSet<Lg_MoviStk>();
            Lg_TipMoviAlm = new HashSet<Lg_TipMoviAlm>();
        }

        [Key]
        [StringLength(2)]
        public string Cod_almacen { get; set; }

        [Required]
        [StringLength(200)]
        public string Nom_Almacen { get; set; }

        [Required]
        [StringLength(1)]
        public string Tip_Item { get; set; }

        [Required]
        [StringLength(1)]
        public string Flg_status { get; set; }

        [StringLength(4)]
        public string Anio_Cierre { get; set; }

        [StringLength(2)]
        public string Mes_Cierre { get; set; }

        [StringLength(1)]
        public string Tip_Presentacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_MoviStk> Lg_MoviStk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lg_TipMoviAlm> Lg_TipMoviAlm { get; set; }
    }
}
