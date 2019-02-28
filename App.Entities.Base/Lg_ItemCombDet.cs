namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_ItemCombDet
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Cod_Item { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Cod_Comb { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Num_Secuencia { get; set; }

        [StringLength(8)]
        public string Cod_Item_Detalle { get; set; }

        [StringLength(8)]
        public string Cod_Comb_Detalle { get; set; }

        [StringLength(6)]
        public string Cod_Color { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Consumo { get; set; }

        [StringLength(100)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(20)]
        public string Des_Combdet { get; set; }

        public virtual Lg_ItemComb Lg_ItemComb { get; set; }
    }
}
