using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NomesdaHistoriaApp.Models;

namespace NomesdaHistoriaApp.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        [HttpGet]
        public ActionResult Index(String titulo)
        {
            AulasDbContext aulas = new AulasDbContext();
            Aulas aula  =new Aulas();
            foreach (Aulas a in aulas.Aulas.Where(a => a.titulo.Equals(titulo)))
            {
                aula = a;
                break;
            }

            Utilizadores u = new UtilizadoresDBcontext().Utilizadores.Find(Session["userID"]);

            Estatistica stat = new Estatistica(aula,u);

            if (aula.Apresentacoes.Count == 0) return View();

            if (Session["aulaAP"] == null) Session["aulaAP"] = -1;

            NomesdaHistoriaApp.Models.Aulas.AulaViewModel al = aula.gerarAula(stat,(int)Session["aulaAP"]);

            Session["aulaAP"] = al.apresentacao.cod;

            return View(al);
        }

        [HttpGet]
        public ActionResult _LoadMedia(Apresentacoes ap){

            return View(ap);
        }

        public ActionResult PlayVideo(String url) {
            return new VideoResult(url);
        }

        public ActionResult NoApresentacoesAction()
        {
            return View();
        }
    }
}