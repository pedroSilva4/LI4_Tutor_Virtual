namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ajudas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aula { get; set; }

        [Required]
        [StringLength(255)]
        public string ajuda { get; set; }

        [Required]
        [StringLength(255)]
        public string topico { get; set; }

        [StringLength(255)]
        public string audio { get; set; }

        public virtual Aulas Aulas { get; set; }
    }
}
