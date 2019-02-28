namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cn_AnexosContables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cn_AnexosContables()
        {
            Cn_Ventas = new HashSet<Cn_Ventas>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string Cod_TipAnEX { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Cod_Anxo { get; set; }

        [Required]
        [StringLength(100)]
        public string Des_Anexo { get; set; }

        [Required]
        [StringLength(24)]
        public string Num_Ruc { get; set; }

        [Required]
        [StringLength(200)]
        public string Dir_Anexo { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_TipIte { get; set; }

        [StringLength(40)]
        public string Apellido_Paterno { get; set; }

        [StringLength(40)]
        public string Apellido_Materno { get; set; }

        [StringLength(40)]
        public string Nombres { get; set; }

        [StringLength(1)]
        public string Origen { get; set; }

        [StringLength(4)]
        public string Cod_Pais { get; set; }

        [StringLength(100)]
        public string Telefono { get; set; }

        [StringLength(3)]
        public string Cod_Zona { get; set; }

        [StringLength(2)]
        public string Codigo_Postal { get; set; }

        [StringLength(50)]
        public string Contacto_Pago { get; set; }

        [StringLength(5)]
        public string COD_CLIENTE { get; set; }

        public DateTime? Fec_Alta { get; set; }

        [StringLength(2)]
        public string Cod_TipoDocIde { get; set; }

        [StringLength(20)]
        public string Nro_DocIde { get; set; }

        public DateTime? Fec_Nacimiento { get; set; }

        public DateTime? Fec_Creacion { get; set; }

        [StringLength(6)]
        public string Cod_Ubigeo { get; set; }

        public DateTime? Fec_Baja { get; set; }

        [StringLength(15)]
        public string Cod_Usuario_Baja { get; set; }

        [StringLength(3)]
        public string Cod_Motivo_Baja { get; set; }

        [StringLength(300)]
        public string Observaciones_Baja { get; set; }

        [StringLength(1)]
        public string Flg_Activo { get; set; }

        public virtual Tx_Cliente Tx_Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cn_Ventas> Cn_Ventas { get; set; }
    }
}
