namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class CnVentas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cod_TipDoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Ser_Docum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string Num_Docum_Ventas { get; set; }

        [Required]
        [StringLength(12)]
        public string Num_Corre { get; set; }

        [Required]
        [StringLength(1)]
        public string Cod_Tipanex { get; set; }

        [Required]
        [StringLength(4)]
        public string Cod_Anxo { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_CondVent { get; set; }

        public int Cod_Tip_Pago { get; set; }

        public DateTime? Fec_EmiDoc { get; set; }

        public DateTime? Fec_RegDoc { get; set; }

        public DateTime? Fec_VenDoc { get; set; }

        public DateTime? Fec_Cancelacion { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_Moneda { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_Neto { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_IGV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Imp_Total { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Tipo_Cambio { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Porc_IGV { get; set; }

        [Required]
        [StringLength(50)]
        public string Cod_Usuario_Registro { get; set; }

        [Required]
        [StringLength(3)]
        public string Cod_Tipo_Venta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Por_Descuento { get; set; }

        [Required]
        [StringLength(12)]
        public string Num_Corre_Referencia { get; set; }

        public virtual CnAnexosContables CnAnexosContables { get; set; }

        public virtual CnTiposDocum CnTiposDocum { get; set; }

        public virtual CnTiposVenta CnTiposVenta { get; set; }
    }
}
