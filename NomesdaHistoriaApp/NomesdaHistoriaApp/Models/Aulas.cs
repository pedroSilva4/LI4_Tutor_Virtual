namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aulas
    {
        public Aulas()
        {
            Ajudas = new HashSet<Ajudas>();
            Apresentacoes = new HashSet<Apresentacoes>();
            Perguntas = new HashSet<Perguntas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        public int? audioVis { get; set; }

        public int? videoVis { get; set; }

        public int? imagemVis { get; set; }

        public int? audioAprov { get; set; }

        public int? videoAprov { get; set; }

        public int? imagemAprov { get; set; }

        [Required]
        [StringLength(75)]
        public string personagem { get; set; }

        public int ordem { get; set; }

        [StringLength(75)]
        public string titulo { get; set; }

        public virtual ICollection<Ajudas> Ajudas { get; set; }

        public virtual ICollection<Apresentacoes> Apresentacoes { get; set; }

        public virtual ICollection<Perguntas> Perguntas { get; set; }
    }
}
