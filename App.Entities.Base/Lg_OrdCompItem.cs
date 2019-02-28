namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_OrdCompItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string Ser_OrdComp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Cod_OrdComp { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string Sec_OrdComp { get; set; }

        [StringLength(8)]
        public string Cod_Item { get; set; }

        [StringLength(3)]
        public string Cod_Comb { get; set; }

        [StringLength(6)]
        public string Cod_Color { get; set; }

        [StringLength(10)]
        public string Cod_Talla { get; set; }

        [StringLength(3)]
        public string Cod_Descuento { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Porc_IGV { get; set; }

        public DateTime? Fec_Entrega_Inicio { get; set; }

        public DateTime? Fec_Entrega_Fin { get; set; }

        public DateTime? Fec_Cierre { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pre_Unitario { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Requerida { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Comprada { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Recibida { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Fac_EquiProv { get; set; }

        [StringLength(15)]
        public string Cod_ItemProv { get; set; }

        public DateTime? Fec_1RA_Entrega { get; set; }

        public DateTime? Fec_Ult_Entrega { get; set; }

        public virtual Lg_Item Lg_Item { get; set; }

        public virtual Lg_OrdComp Lg_OrdComp { get; set; }
    }
}
