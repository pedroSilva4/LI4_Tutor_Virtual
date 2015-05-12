using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NomesdaHistoriaApp.Models;

namespace NomesdaHistoriaApp.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _ListEtapas() {
            AulasDB AulasDb = new AulasDB();
            PerosnagensDBContext PersonagensDb = new PerosnagensDBContext();
            Dictionary<String,List<String>> aulasMap = new Dictionary<String,List<String>>();
            foreach (Personagen p in PersonagensDb.Personagens)
            {
                List<String> orders = new List<String>();
                foreach(Aulas a in AulasDb.Aulas.Where(a => a.personagem==p.nome)){
                    orders.Add(a.titulo); 
                }
                aulasMap.Add(p.nome, orders);
            }

            return View(aulasMap);
        }
    }
}