using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesdaHistoriaApp.Models
{
    public class Estatistica
    {

        public float pAudio { get; set; }
        public float pVideo { get; set; }
        public float pImg { get; set; }


        public Estatistica(Aulas a,Utilizadores u) {
            /*
             * calculo dos pesos das percentagens das aulas
             */
            float videoPa = (float) (a.videoAprov / a.videoVis);
            float audioPa = (float) (a.audioAprov / a.audioVis);
            float imgPa = (float)(a.imagemAprov / a.imagemVis);

            /*
            * calculo dos pesos das percentagens dos utlizadores
            */
            float videoPu = (float)(u.videoAprovado / u.videoVis);
            float audioPu = (float)(u.audioAprovado / u.audioVis);
            float imgPu = (float)(u.imagemAprovado / u.imagemVis);

            /*
             * multiplicar pesos
             */

            float p1 = videoPa*videoPu;
            float p2 = audioPa *audioPu;
            float p3 = imgPa * imgPu;

            float pt = p1 + p2 + p3;

            /*
             * calculo final dos pesos
             */
            this.pVideo =(p1 / pt);
            this.pAudio = (p2 / pt);
            this.pImg = (p3 / pt);
        }
    }
}