namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt09_numeracion
    {
        [Key]
        public long id_numeracion { get; set; }

        [StringLength(20)]
        public string cod_numeracion { get; set; }

        [StringLength(20)]
        public string auto_corr { get; set; }

        [StringLength(20)]
        public string caja { get; set; }

        [StringLength(50)]
        public string canal { get; set; }

        [StringLength(20)]
        public string num_impr { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_reg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_alta { get; set; }

        [StringLength(10)]
        public string serie { get; set; }

        [Required]
        [StringLength(20)]
        public string comp_ini { get; set; }

        [Required]
        [StringLength(20)]
        public string comp_final { get; set; }

        [Required]
        [StringLength(20)]
        public string comp_actual { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        [Column("lock")]
        public short _lock { get; set; }

        public int id_tipo_comp { get; set; }

        public int id_location { get; set; }

        public virtual MSTt08_location MSTt08_location { get; set; }

        public virtual SNTt10_tipo_comprobante SNTt10_tipo_comprobante { get; set; }
    }
}
