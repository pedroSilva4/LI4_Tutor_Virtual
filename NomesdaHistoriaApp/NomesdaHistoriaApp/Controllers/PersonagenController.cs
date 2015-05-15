using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NomesdaHistoriaApp.Models;

namespace NomesdaHistoriaApp.Controllers
{
    public class PersonagenController : Controller
    {
        // GET: Avatar
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MostraTutor(String username = "")
        {
            UtilizadoresDBcontext usersDB = new UtilizadoresDBcontext();
            Utilizadores u = new Utilizadores();
            u = usersDB.Utilizadores.Find(username);
            PerosnagensDBContext personagem = new PerosnagensDBContext();
            Personagen p = new Personagen();
            p = personagem.Personagens.Find(u.avatar.ToString());
            return View(p);   
        }
    }
}