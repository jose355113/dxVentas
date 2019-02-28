namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_MoviStkItem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cod_Almacen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string Num_MovStk { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string Num_Secuencia { get; set; }

        [StringLength(8)]
        public string Cod_Item { get; set; }

        [StringLength(3)]
        public string Cod_Comb { get; set; }

        [StringLength(6)]
        public string Cod_Color { get; set; }

        [StringLength(10)]
        public string Cod_Talla { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Can_Movimiento { get; set; }

        [StringLength(3)]
        public string Ser_OrdComp { get; set; }

        [StringLength(6)]
        public string Cod_OrdComp { get; set; }

        [StringLength(3)]
        public string Sec_OrdComp { get; set; }

        public DateTime Fec_MOVsTK { get; set; }

        public virtual Lg_Item Lg_Item { get; set; }

        public virtual Lg_MoviStk Lg_MoviStk { get; set; }
    }
}
