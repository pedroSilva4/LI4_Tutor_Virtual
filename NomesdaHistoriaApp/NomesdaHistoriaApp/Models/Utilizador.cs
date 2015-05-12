namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Utilizador
    {
        [Key]
        [StringLength(75)]
        public string username { get; set; }

        [Required]
        [StringLength(75)]
        public string password { get; set; }

        public int? pontos { get; set; }

        public int? imagemVis { get; set; }

        public int? audioVis { get; set; }

        public int? videoVis { get; set; }

        public int? videoAprovado { get; set; }

        public int? audioAprovado { get; set; }

        public int? imagemAprovado { get; set; }

        [Required]
        [StringLength(75)]
        public string avatar { get; set; }

        [Required]
        [StringLength(75)]
        public string tema_Ambiente { get; set; }


        public Boolean isValid_reg(String _username){

            UtilizadorDBContext utdb = new UtilizadorDBContext();

            Utilizador u = utdb.Utilizadores.Find(_username);
            if (u == null) 
                return true;
            else
                return false;
        }
        public Boolean isValid_reg(String _username)
        {

            UtilizadorDBContext utdb = new UtilizadorDBContext();

            Utilizador u = utdb.Utilizadores.Find(_username);
            if (u == null)
                return true;
            else
                return false;
        }

        public Boolean isValid_login(String _username,String _password)
        {

            UtilizadorDBContext utdb = new UtilizadorDBContext();

            Utilizador u = utdb.Utilizadores.Find(_username);
            if (u == null)
                return true;
            else
                return false;
        }
    }
}
