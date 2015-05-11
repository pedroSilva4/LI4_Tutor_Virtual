using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesDaHistoriaApp.Models
{
	public class Utilizador {
		private String username;
		private String password;
		private int pontos;
		private int imgVis;
		private int videoVis;
		private int audioVis;
		private int imgAprov;
		private int videoAprov;
		private int audioAprov;
		private String codAvatar;
		private String ambienteCod;

		public String GetUsername() {
			return this.username;
		}
		public void SetUsername(String username) {
			this.username = username;
		}
		public String GetPassword() {
			return this.password;
		}
		public void SetPassword(String password) {
			this.password = password;
		}
		public int GetPontos() {
			return this.pontos;
		}
		public void SetPontos(int pontos) {
			this.pontos = pontos;
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
		public int GetAudioVis() {
			return this.audioVis;
		}
		public void SetAudioVis(int audioVis) {
			this.audioVis = audioVis;
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
		public int GetAudioAprov() {
			return this.audioAprov;
		}
		public void SetAudioAprov(int audioAprov) {
			this.audioAprov = audioAprov;
		}
		public String GetAvatarCod() {
            return this.codAvatar;
		}
		public void SetAvatarCod(String avatarCod) {
            this.codAvatar = avatarCod;
		}
		public String GetAmbienteCod() {
			return this.ambienteCod;
		}
		public void SetAmbienteCod(String ambienteCod) {
			this.ambienteCod = ambienteCod;
		}

	}

}
