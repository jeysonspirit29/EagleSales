namespace Common.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt10_tipo_comprobante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt10_tipo_comprobante()
        {
            TNSt01_comp_recibido = new HashSet<TNSt01_comp_recibido>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
            TNSt09_numeracion = new HashSet<TNSt09_numeracion>();
        }

        [Key]
        public int id_tipo_comp { get; set; }

        [StringLength(10)]
        public string cod_tipo_comp { get; set; }

        [StringLength(10)]
        public string cod_tipo_comp_ple { get; set; }

        [StringLength(100)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(500)]
        public string txt_desc { get; set; }

        public int? id_location { get; set; }

        [StringLength(50)]
        public string cod_location { get; set; }

        [StringLength(50)]
        public string nro_caja { get; set; }

        [StringLength(50)]
        public string nro_serie { get; set; }

        public long? nro_inicial { get; set; }

        public long? nro_final { get; set; }

        public long? nro_contador { get; set; }

        public int sn_emito_comp { get; set; }

        public int sn_recibo_comp { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt09_numeracion> TNSt09_numeracion { get; set; }
    }
}
