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
            AulasDBContext AulasDb = new AulasDBContext();
            PerosnagensDBContext PersonagensDb = new PerosnagensDBContext();
            Dictionary<String,List<int>> aulasMap = new Dictionary<String,List<int>>();
            foreach (Personagen p in PersonagensDb.Personagens)
            {
                List<int> orders = new List<int>();
                foreach(Aulas a in AulasDb.Aulas.Where(a => a.personagem==p.nome)){
                    orders.Add(a.ordem); 
                }
                aulasMap.Add(p.nome, orders);
            }

            return View(aulasMap);
        }
    }
}