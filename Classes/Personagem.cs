using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesDaHistoriaApp.Models
{
	public class Personagem {

        public int id { get; set; }

        private String _nome;

        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _etapa;

        public String etapa
        {
            get { return _etapa; }
            set { _etapa = value; }
        }

        private String _sprite;

        public String sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

	}

}
