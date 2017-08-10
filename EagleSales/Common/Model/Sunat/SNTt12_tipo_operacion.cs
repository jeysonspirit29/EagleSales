namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt12_tipo_operacion
    {
        [Key]
        public int id_tipo_operacion { get; set; }

        [StringLength(10)]
        public string cod_tipo_operacion { get; set; }

        [StringLength(10)]
        public string cod_tipo_operacion_ple { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
