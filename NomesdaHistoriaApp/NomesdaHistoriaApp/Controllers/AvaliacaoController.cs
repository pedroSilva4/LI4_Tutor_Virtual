using NomesdaHistoriaApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NomesdaHistoriaApp.Controllers
{
    public class AvaliacaoController : Controller
    {

        public ActionResult avaliar(String username, int codAula, int codApr, String tipo)
        {
            AvaliacaoViewModel avaliacao = new AvaliacaoViewModel(username, codAula, codApr, tipo);
            return View(avaliacao);
        }


        public ActionResult getQuestion(int idQuestion)
        {
            AulasDbContext aulas = new AulasDbContext();
            Perguntas p = new Perguntas();

            foreach (Perguntas aux in aulas.Perguntas)
            {
                if (aux.cod == idQuestion)
                    p = aux;
            }
            PerguntaViewModel res = new PerguntaViewModel(p.pergunta, p.errada1, p.errada2, p.errada3, p.resposta);

            return Json(res, JsonRequestBehavior.AllowGet);
        }


        public ActionResult insereAvaliacao(String username, int codAula, int codApr, String tipo, int pontos)
        {

            /*
             *****NOTA IMPORTANTE******
             *
             *os contadores apenas são inseridos aqui
             *se o user apenas assistir à aula, o seu contador não é incrementado
             *se o user repetir uma avaliação, todos os contadores sao incrementados novamente(incluindo a visualização)
             *
             * isto faz sentido pois, estes contadores são apenas para calculo da "eficacia" dos tipos de apresentaçoes erespetivas apresentaçoes 
             */
            AulasDbContext db = new AulasDbContext();
            UtilizadoresDBcontext userDB = new UtilizadoresDBcontext();
            Utilizadores user = userDB.Utilizadores.Find(username);

            Avaliacoes avAnt = db.Avaliacoes.Find(username, codAula);

            //aquie é feito o incremento de todos os contasdores de visualizaçoes e aprovaçoes
            Aulas aula = db.Aulas.Find(codAula);

            Apresentacoes apr = db.Apresentacoes.Find(codApr, codAula);

            //incrementa visualização na aula
            if (tipo.Equals("video"))
            {
                aula.videoVis++;
                user.videoVis++;
            }
            else if (tipo.Equals("imagem"))
            {
                aula.imagemVis++;
                user.imagemVis++;
            }
            else if (tipo.Equals("audio"))
            {
                aula.audioVis++;
                user.audioVis++;
            }

            //incrementa visualização na apresentação
            apr.visualizacoes++;

            String res;

            if (pontos < 36)
            {
                res = "reprovado";
            }
            else
            {
                res = "aprovado";
                //incrementa aprovaçao na aula
                if (tipo.Equals("video"))
                {
                    aula.videoAprov++;
                    user.videoAprovado++;
                }
                else if (tipo.Equals("imagem"))
                {
                    aula.imagemAprov++;
                    user.imagemAprovado++;
                }
                else if (tipo.Equals("audio"))
                {
                    aula.audioAprov++;
                    user.audioAprovado++;
                }

                //incrementa aprovacao na apresentação
                apr.aprovacoes++;
            }

            //grava contadores aulas e apresentaçoes
            db.Entry(apr).State = EntityState.Modified;
            db.Entry(aula).State = EntityState.Modified;
            db.SaveChanges();

            //grava contadores user
            userDB.Entry(user).State = EntityState.Modified;
            userDB.SaveChanges();

            if (res.Equals("reprovado"))
                return Json(res, JsonRequestBehavior.AllowGet);

            //verifica se o user já tem uma avalicao positiva para esta aula
            if (avAnt != null)
            {
                //verifica qual a que tem mais pontos melhor
                //se a melhoria for melhor, atualiza
                if (pontos > avAnt.pontos)
                {
                    //atuliza pontos
                    int maisPontos = pontos - avAnt.pontos;
                    user.pontos += maisPontos;
                    Session["points"] = user.pontos;

                    avAnt.pontos = pontos;
                    avAnt.tipo = tipo;
                    db.Entry(avAnt).State = EntityState.Modified;
                    db.SaveChanges();

                }
                else
                {
                    res = "naoMelhoria";
                    return Json(res, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                //insere pontos
                user.pontos += pontos;
                Session["points"] = user.pontos;

                Avaliacoes av = new Avaliacoes();
                av.aula = codAula;
                av.username = username;
                av.tipo = tipo;
                av.pontos = pontos;
                db.Avaliacoes.Add(av);
                db.SaveChanges();

                //verifica se já fez todas as conquistas
                String personagem = aula.personagem;
                int totalAulas=0, avs=0;

                foreach (Aulas au in db.Aulas)
                {
                    if(au.personagem.Equals(personagem))
                        totalAulas++;
                }

                foreach (Avaliacoes a in db.Avaliacoes)
                {
                    if(db.Aulas.Find(a.aula).personagem.Equals(personagem))
                        avs++;
                }

                if (avs == totalAulas)
                {
                    Conquistas nova = new Conquistas();
                    nova.personagem = personagem;
                    nova.username = username;

                    db.Conquistas.Add(nova);
                    db.SaveChanges();
                }

            }

            //grava alterações de pontos
            userDB.Entry(user).State = EntityState.Modified;
            userDB.SaveChanges();

            return Json(res, JsonRequestBehavior.AllowGet);
        }


        public ActionResult validaQuestion(int idQuestion, String resposta)
        {
            AulasDbContext aulas = new AulasDbContext();
            Perguntas p = new Perguntas();
            String res;

            foreach (Perguntas aux in aulas.Perguntas)
            {
                if (aux.cod == idQuestion)
                    p = aux;
            }

            if (p.resposta.Equals(resposta))
                res = "true";
            else
                res = "false";

            return Json(res, JsonRequestBehavior.AllowGet);
        }

    }
}