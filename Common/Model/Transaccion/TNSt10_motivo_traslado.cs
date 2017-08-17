namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt10_motivo_traslado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TNSt10_motivo_traslado()
        {
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public int id_motivo_traslado { get; set; }

        [StringLength(10)]
        public string cod_motivo_traslado { get; set; }

        [Required]
        [StringLength(200)]
        public string txt_desc { get; set; }

        [StringLength(50)]
        public string txt_abrv { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}
