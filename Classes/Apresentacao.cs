using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesDaHistoriaApp.Models
{
	public class Apresentacao {
		private int id;
		private int aprovados;
		private int visualizada;
		private String filepathMult;
		private String filepathText;

		public int GetId() {
			return this.id;
		}
		public void SetId(int id) {
			this.id = id;
		}
		public int GetAprovados() {
			return this.aprovados;
		}
		public void SetAprovados(int aprovados) {
			this.aprovados = aprovados;
		}
		public int GetVisualizada() {
			return this.visualizada;
		}
		public void SetVisualizada(int visualizada) {
			this.visualizada = visualizada;
		}
		public String GetFilepathMult() {
			return this.filepathMult;
		}
		public void SetFilepathMult(String filepathMult) {
			this.filepathMult = filepathMult;
		}
		public String GetFilepathText() {
			return this.filepathText;
		}
		public void SetFilepathText(String filepathText) {
			this.filepathText = filepathText;
		}


	}

}
