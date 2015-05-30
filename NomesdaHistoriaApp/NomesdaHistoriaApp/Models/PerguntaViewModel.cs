using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NomesdaHistoriaApp.Models
{
    public class PerguntaViewModel
    {
        public String pergunta { get; set; }
        public String opt1 { get; set; }
        public String opt2 { get; set; }
        public String opt3 { get; set; }
        public String opt4 { get; set; }
        public int correctOpt { get; set; }

        public PerguntaViewModel() { }

        public PerguntaViewModel(String pergunta, String opt1, String opt2, String opt3, String certa)
        {
            this.pergunta = pergunta;

            Random rnd = new Random();
            int nextAnswer = rnd.Next(1, 4);

            for (int i = 1; i <= 4; i++)
            {
                if (nextAnswer == 1)
                {
                    if (i == 1)
                        this.opt1 = opt1;
                    if (i == 2)
                        this.opt2 = opt1;
                    if (i == 3)
                        this.opt3 = opt1;
                    if (i == 4)
                        this.opt4 = opt1;
                }
                else if (nextAnswer == 2)
                {
                    if (i == 1)
                        this.opt1 = opt2;
                    if (i == 2)
                        this.opt2 = opt2;
                    if (i == 3)
                        this.opt3 = opt2;
                    if (i == 4)
                        this.opt4 = opt2;
                }
                else if (nextAnswer == 3)
                {
                    if (i == 1)
                        this.opt1 = opt3;
                    if (i == 2)
                        this.opt2 = opt3;
                    if (i == 3)
                        this.opt3 = opt3;
                    if (i == 4)
                        this.opt4 = opt3;
                }
                else if (nextAnswer == 4)
                {
                    this.correctOpt = i;
                    if (i == 1)
                        this.opt1 = certa;
                    if (i == 2)
                        this.opt2 = certa;
                    if (i == 3)
                        this.opt3 = certa;
                    if (i == 4)
                        this.opt4 = certa;
                }

                if (nextAnswer == 4) nextAnswer = 1;
                else nextAnswer++;
            }

        }

    }
}