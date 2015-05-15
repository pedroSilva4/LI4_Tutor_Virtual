namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conquistas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(75)]
        public string username { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(75)]
        public string personagem { get; set; }
    }
}
