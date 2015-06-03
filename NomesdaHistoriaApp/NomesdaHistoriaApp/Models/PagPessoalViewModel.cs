using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesdaHistoriaApp.Models
{
    public class PagPessoalViewModel
    {
        public List<Personagen> conquistas { get; set;}
        public Personagen emConquista { get; set; }
        public Utilizadores user { get; set; }

        public int emConquistaAulas { get; set; }
        public int emConquistasAprovado { get; set; } 

        public PagPessoalViewModel()
        {
            this.conquistas = null;
            this.emConquista = null;
            this.user = new Utilizadores();
        }
    }
}