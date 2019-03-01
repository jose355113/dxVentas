namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CnVentasItems
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string Num_Corre { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        [Required]
        [StringLength(1)]
        public string Tipo_Item { get; set; }

        [Required]
        [StringLength(25)]
        public string Codigo_Item { get; set; }

        [Required]
        [StringLength(6)]
        public string Cod_Color { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad { get; set; }

        [Required]
        [StringLength(3)]
        public string Unidad_Medida { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_Unitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_Total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_Descuento { get; set; }

        [Required]
        [StringLength(12)]
        public string Num_Corre_Original_NCND { get; set; }

        public int Num_Secuencia_OriginalNCND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Cantidad_Item_NC_ND { get; set; }

        [StringLength(2)]
        public string Cod_TipDoc_NCND { get; set; }

        [StringLength(4)]
        public string Ser_Docum_NCND { get; set; }

        [StringLength(8)]
        public string Num_Docum_NCND { get; set; }
    }
}
