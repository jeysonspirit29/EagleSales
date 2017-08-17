namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt01_usuario
    {
        [Key]
        public long id_usuario { get; set; }

        [StringLength(20)]
        public string cod_usuario { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string txt_clave { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_modificacion { get; set; }

        public int sn_upd_requered { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_empleado { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
