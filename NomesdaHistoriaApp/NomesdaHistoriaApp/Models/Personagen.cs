namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personagen
    {
        [Key]
        [StringLength(75)]
        public string nome { get; set; }

        public int etapa { get; set; }

        [Required]
        [StringLength(255)]
        public string sprite { get; set; }
    }


    public class PersonagemViewModel {

        public string nome { get; set; }
        public int etapa { get; set; }
        public string sprite { get; set; }

        public Dictionary<String, List<Ajudas>> DicionariodeAjudas{get;set;}
    }
} 
