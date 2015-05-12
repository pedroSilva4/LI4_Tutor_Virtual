namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Perguntas
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
        public string pergunta { get; set; }

        [Required]
        [StringLength(255)]
        public string resposta { get; set; }

        [StringLength(255)]
        public string errada1 { get; set; }

        [StringLength(255)]
        public string errada2 { get; set; }

        [StringLength(255)]
        public string errada3 { get; set; }

        public virtual Aulas Aulas { get; set; }
    }
}
