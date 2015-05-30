namespace NomesdaHistoriaApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using NomesdaHistoriaApp.Models;
    using System.Collections;

    public partial class Aulas
    {
        public Aulas()
        {
            Ajudas = new HashSet<Ajudas>();
            Apresentacoes = new HashSet<Apresentacoes>();
            Avaliacoes = new HashSet<Avaliacoes>();
            Perguntas = new HashSet<Perguntas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cod { get; set; }

        public int audioVis { get; set; }

        public int videoVis { get; set; }

        public int imagemVis { get; set; }

        public int audioAprov { get; set; }

        public int videoAprov { get; set; }

        public int imagemAprov { get; set; }

        [Required]
        [StringLength(75)]
        public string personagem { get; set; }

        public int ordem { get; set; }

        [StringLength(75)]
        public string titulo { get; set; }

        public virtual ICollection<Ajudas> Ajudas { get; set; }

        public virtual ICollection<Apresentacoes> Apresentacoes { get; set; }

        public virtual ICollection<Avaliacoes> Avaliacoes { get; set; }

        public virtual ICollection<Perguntas> Perguntas { get; set; }

        public AulaViewModel gerarAula(Estatistica stats,int apAnterior) {

            AulaViewModel aula = new AulaViewModel();
            aula.titulo = this.titulo;
            while (aula.apresentacao == null)
            {
                Random rnd = new Random();
                int opt = rnd.Next(1, 100);
                String apType = wichmedia(opt, stats);
                Dictionary<int, float> pesos = new Dictionary<int, float>();
                float totalp = 0.0f;
                foreach (Apresentacoes ap in this.Apresentacoes)
                {
                    if (ap.tipo == apType)
                    {
                        if (apAnterior != ap.cod)
                        {
                            pesos.Add(ap.cod, ((float)ap.aprovacoes / (float)ap.visualizacoes));
                            totalp += ((float)ap.aprovacoes / (float)ap.visualizacoes);
                        }
                    }
                }

                opt = rnd.Next(1, 100);
                int apid = -1;
                float prev = 0.0f;
                foreach (int i in pesos.Keys)
                {
                    float p = pesos[i];
                    pesos[i] = p / totalp;

                    if (opt <= (pesos[i]) * 100 + prev)
                    {
                        apid = i;
                        break;
                    }

                    prev += pesos[i];
                }


                aula.apresentacao = (from x in this.Apresentacoes where x.cod == apid select x).FirstOrDefault();
            }
            return aula;
        }

        private String wichmedia(int opt, Estatistica stats) {

            if (opt <= stats.pVideo * 100)
                return "video";
            if (opt <= (stats.pVideo + stats.pAudio) * 100)
                return "audio";
            else
                return "imagem";
        }
        public class AulaViewModel{

            [Required]
            public string titulo { get; set; }
            [Required]
            public Apresentacoes apresentacao { get; set; }


        }
    }
}
