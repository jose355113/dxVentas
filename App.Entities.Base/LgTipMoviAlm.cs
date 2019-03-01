namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LgTipMoviAlm")]
    public partial class LgTipMoviAlm
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string Cod_Almacen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Cod_TipMov { get; set; }

        [StringLength(1)]
        public string Flg_Status { get; set; }

        public virtual LgAlmacen LgAlmacen { get; set; }

        public virtual LgTiposMov LgTiposMov { get; set; }
    }
}
