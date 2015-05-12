namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Utilizadores
    {
        [Key]
        [StringLength(75)]
        [Display(Name = "Username")]
        public string username { get; set; }

        [Required]
        [StringLength(75)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        private int _pontos = 0;
        public int? pontos { get { return _pontos; } set { _pontos =(int)value; } }

        private int _iv = 1;
        public int? imagemVis { get { return _iv; } set { _iv = (int)value; } }

        private int _av = 1;
        public int? audioVis { get { return _av; } set { _av = (int)value; } }

        private int _vv = 1;
        public int? videoVis { get { return _vv; } set { _vv = (int)value; } }

        private int _va = 1;
        public int? videoAprovado { get { return _va; } set { _va = (int)value; } }

        private int _aa = 1;
        public int? audioAprovado { get { return _aa; } set { _aa = (int)value; } }

        private int _ia = 1;
        public int? imagemAprovado { get { return _ia; } set { _ia = (int)value; } }

        [Required]
        [StringLength(75)]
        public string avatar { get; set; }

        [Required]
        [StringLength(75)]
        public string tema_Ambiente { get; set; }
    }


    public class ViewUser{

        [Required]
        [Display(Name = "Username")]
        public String username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String password { get; set; }
    }
}
