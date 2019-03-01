namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgStocksItem")]
    public partial class LgStocksItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cod_Almacen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Cod_Item { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string Cod_Comb { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string Cod_Color { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string Cod_Talla { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Stock { get; set; }

        public DateTime? Fec_1er_Entrada { get; set; }

        public DateTime? Fec_Ult_Entrada { get; set; }

        public DateTime? Fec_1er_Salida { get; set; }

        public DateTime? Fec_Ult_Salida { get; set; }

        public virtual LgItem LgItem { get; set; }
    }
}
