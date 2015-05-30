﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NomesdaHistoriaApp.Models
{
    public class AvaliacaoViewModel
    {
        int nextQuestion = 0; //# da proxima questao a ser gerada

        public Dictionary<int, int> ids; //ids das questoes geradas para a avaliacao
        public string tipo { get; set; }
        public int pontosQuestao { get; set; }
        public int codAula { get; set; }
        public String username { get; set; }
        public int codApr { get; set; }

        public int getIdCurrenctQuestion()
        {
            return this.ids[this.nextQuestion];
        }

        // atuliza # da proxima questao e retorna o Id da atual
        public int updateQuestion()
        {
            this.nextQuestion++;
            return (this.ids[this.nextQuestion - 1]);
        }

        public AvaliacaoViewModel(String username, int codAula, int codApr, String tipo)
        {
            this.tipo = tipo;
            this.username = username;
            this.pontosQuestao = 10;
            this.codAula = codAula;
            this.ids = new Dictionary<int, int>();
            this.codApr = codApr;

            AulasDbContext aulas = new AulasDbContext();
            Aulas aula = new Aulas();
            foreach (Aulas a in aulas.Aulas.Where(a => a.cod.Equals(codAula)))
            {
                aula = a;
                break;
            }

            ICollection<Perguntas> perguntas = aula.Perguntas;
            int nQ = 0;

            //sort X Perguntas -> fazer aqui !!!

            foreach (Perguntas item in perguntas)
            {
                item.randQuestions(); //a ordem das opções para resposta é "gerada" aqui
                PerguntaViewModel pvm = new PerguntaViewModel(item.pergunta, item.errada1, item.errada2, item.errada3, item.resposta);
                this.ids[nQ] = item.cod;
                nQ++;
            }
        }

    }
}