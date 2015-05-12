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
        public ActionResult MostraTutor()
        {
            UtilizadorDBContext userDB = new UtilizadorDBContext();
            Utilizador u = new Utilizador();
            u = userDB.Utilizadores.Find("pedrinho");
           // string avatar = u.avatar;
            PerosnagensDBContext personagem = new PerosnagensDBContext();
            Personagen p = new Personagen();
            p = personagem.Personagens.Find(u.avatar.ToString());
            return View(p);   
        }
    }
}