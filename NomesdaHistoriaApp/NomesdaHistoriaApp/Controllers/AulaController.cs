using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NomesdaHistoriaApp.Models;
using System.IO;
using System.Web.Hosting;

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

            Session["aulaId"] = aula.cod;
            Session["aulaAP"] = al.apresentacao.cod;
            Session["tituloAula"] = al.titulo;

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

        public String GetImages(List<Multimedia> multimedia, int Apid) {
            String result = "";
            int ordem = 1;

            foreach (Multimedia m in multimedia.Where(m => m.apresentacoes_cod == Apid))
            {
                if (ordem == m.ordem)
                {
                    var imgFilePath = HostingEnvironment.MapPath("~/" + m.PATH);
                    //result += "<li><img src=\"~/"+m.PATH+"\" alt=\"Smiley face\"> <p>" + parseFile(m.texto) + "</p></li>\n";

                    result += "../../" + m.PATH + ";" + parseFile(m.texto) + "+";
                    ordem++;
                }
            }

            return result;
        }

        public String parseFile(String Path) {

            var textFilePath = HostingEnvironment.MapPath("~/"+Path);
            String text = System.IO.File.ReadAllText(textFilePath,System.Text.Encoding.UTF8);


            Console.Write(text);
            return text;
           
        }

        public String getAudioText(String Path) {
            String text = parseFile(Path);

            return "<p>" + text + "</p>";
        }

    }
}