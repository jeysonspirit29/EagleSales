namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt28_suspencion_laboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt28_suspencion_laboral()
        {
            PERt04_empleado = new HashSet<PERt04_empleado>();
        }

        [Key]
        public int id_suspencion_laboral { get; set; }

        [StringLength(10)]
        public string cod_suspencion_laboral { get; set; }

        [StringLength(10)]
        public string cod_suspencion_laboral_ple { get; set; }

        [StringLength(70)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt04_empleado> PERt04_empleado { get; set; }
    }
}
