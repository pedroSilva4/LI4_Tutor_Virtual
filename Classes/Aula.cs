using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesDaHistoriaApp.Models
{
	public class Aula{
		private int _id;
		public int id {
			get {
				return _id;
			}
			set {
				_id = value;
			}
		}
		private int audiVis;
		private int imgVis;
		private int videoVis;
		private int audioAprov;
		private int imgAprov;
		private int videoAprov;
		private int ordem;
		private String personagem;

		public int GetAudiVis() {
			return this.audiVis;
		}
		public void SetAudiVis(int audiVis) {
			this.audiVis = audiVis;
		}
		public int GetImgVis() {
			return this.imgVis;
		}
		public void SetImgVis(int imgVis) {
			this.imgVis = imgVis;
		}
		public int GetVideoVis() {
			return this.videoVis;
		}
		public void SetVideoVis(int videoVis) {
			this.videoVis = videoVis;
		}
		public int GetAudioAprov() {
			return this.audioAprov;
		}
		public void SetAudioAprov(int audioAprov) {
			this.audioAprov = audioAprov;
		}
		public int GetImgAprov() {
			return this.imgAprov;
		}
		public void SetImgAprov(int imgAprov) {
			this.imgAprov = imgAprov;
		}
		public int GetVideoAprov() {
			return this.videoAprov;
		}
		public void SetVideoAprov(int videoAprov) {
			this.videoAprov = videoAprov;
		}
		public int GetOrdem() {
			return this.ordem;
		}
		public void SetOrdem(int ordem) {
			this.ordem = ordem;
		}
		public void CarregaTopicos() {
			throw new System.Exception("Not implemented");
		}
		public void GerarAula(out object stat) {
			throw new System.Exception("Not implemented");
		}
		public String GetPersonagem() {
			return this.personagem;
		}
		public void SetPersonagem(String personagem) {
			this.personagem = personagem;
		}
		public void SorteiaQuestoes() {
			throw new System.Exception("Not implemented");
		}
		public void CarregaAvaliacao() {
			throw new System.Exception("Not implemented");
		}
		public void AtualizaRegisto(out object codUser, out object codAula, out object codApr, out object points) {
			throw new System.Exception("Not implemented");
		}

		private Apresentacao apresentacao;

	}

}
