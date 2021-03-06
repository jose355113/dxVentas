namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("LgItemCombDet")]
    public partial class LgItemCombDet
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

        public virtual LgItemComb LgItemComb { get; set; }
    }
}
