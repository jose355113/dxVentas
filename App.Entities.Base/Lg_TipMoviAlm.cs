namespace App.Entities.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lg_TipMoviAlm
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

        public virtual Lg_Almacen Lg_Almacen { get; set; }

        public virtual Lg_TiposMov Lg_TiposMov { get; set; }
    }
}
