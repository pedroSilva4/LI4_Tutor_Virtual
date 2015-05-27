namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AmbientesDeAula")]
    public partial class AmbientesDeAula
    {
        [Key]
        [StringLength(75)]
        public string tema { get; set; }

        [Required]
        [StringLength(255)]
        public string PATH { get; set; }
    }
}
