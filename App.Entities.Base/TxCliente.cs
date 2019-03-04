namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("TxCliente")]
    public partial class TxCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TxCliente()
        {
            CnAnexosContables = new HashSet<CnAnexosContables>();
        }

        [Key]
        [StringLength(5)]
        public string Cod_Cliente_Tex { get; set; }

        [Required]
        [StringLength(500)]
        public string Nom_Cliente { get; set; }

        [Required]
        [StringLength(5)]
        public string Abr_Cliente { get; set; }

        [Required]
        [StringLength(500)]
        public string Res_Cliente { get; set; }

        [Required]
        [StringLength(20)]
        public string Num_Ruc { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_CondVent { get; set; }

        [Required]
        [StringLength(100)]
        public string Lug_Entrega { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(500)]
        public string EMail { get; set; }

        [Required]
        [StringLength(1)]
        public string Origen { get; set; }

        [StringLength(4)]
        public string Cod_Via_Domicilio { get; set; }

        [StringLength(100)]
        public string Nombre_Domicilio { get; set; }

        [StringLength(4)]
        public string Numero_Domicilio { get; set; }

        [StringLength(4)]
        public string Interior_Domicilio { get; set; }

        [StringLength(2)]
        public string Cod_Zona_Domicilio { get; set; }

        [StringLength(100)]
        public string Nom_Zona_Domicilio { get; set; }

        [StringLength(6)]
        public string Cod_Ubigeo_Domicilio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CnAnexosContables> CnAnexosContables { get; set; }
    }
}
