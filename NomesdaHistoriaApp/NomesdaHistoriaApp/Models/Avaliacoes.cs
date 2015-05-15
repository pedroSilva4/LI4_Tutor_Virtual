namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Avaliacoes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(75)]
        public string username { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aula { get; set; }

        public int pontos { get; set; }

        [Required]
        [StringLength(75)]
        public string tipo { get; set; }

        public virtual Aulas Aulas { get; set; }
    }
}
