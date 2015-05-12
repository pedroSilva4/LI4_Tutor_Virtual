namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Multimedia")]
    public partial class Multimedia
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apresentacoes_cod { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int apresentacoes_aula { get; set; }

        public int ordem { get; set; }

        [StringLength(255)]
        public string texto { get; set; }

        [Required]
        [StringLength(255)]
        public string PATH { get; set; }

        public virtual Apresentacoes Apresentacoes { get; set; }
    }
}
