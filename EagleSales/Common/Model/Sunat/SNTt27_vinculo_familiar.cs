namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt27_vinculo_familiar
    {
        [Key]
        public int id_vinculo_familiar { get; set; }

        [StringLength(10)]
        public string cod_vinculo_familiar { get; set; }

        [StringLength(10)]
        public string cod_vinculo_familiar_ple { get; set; }

        [StringLength(70)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
