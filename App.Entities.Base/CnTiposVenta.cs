namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CnTiposVenta")]
    public partial class CnTiposVenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CnTiposVenta()
        {
            CnVentas = new HashSet<CnVentas>();
        }

        [Key]
        [StringLength(3)]
        public string Cod_Tipo_Venta { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CnVentas> CnVentas { get; set; }
    }
}
