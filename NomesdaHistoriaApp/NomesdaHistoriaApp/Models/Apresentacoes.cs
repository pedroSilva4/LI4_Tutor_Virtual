namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Apresentacoes
    {
        public Apresentacoes()
        {
            Multimedia = new HashSet<Multimedia>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aulas { get; set; }

        [Required]
        [StringLength(75)]
        public string tipo { get; set; }

        public int? visualizacoes { get; set; }

        public int? aprovacoes { get; set; }

        public virtual Aulas Aulas1 { get; set; }

        public virtual ICollection<Multimedia> Multimedia { get; set; }
    }
}
