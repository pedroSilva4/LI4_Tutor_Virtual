using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NomesdaHistoriaApp.Models;
using System.Web.Security;
namespace NomesdaHistoriaApp.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
                    return View();
        }

        public ActionResult _ListEtapas()
        { 
            AulasDB AulasDb = new AulasDB();
            PerosnagensDBContext PersonagensDb = new PerosnagensDBContext();
            Dictionary<String, List<String>> aulasMap = new Dictionary<String, List<String>>();
            foreach (Personagen p in PersonagensDb.Personagens)
            {
                List<String> titles = new List<String>();
                foreach (Aulas a in AulasDb.Aulas.Where(a => a.personagem == p.nome))
                {
                    titles.Add(a.titulo);
                }
                aulasMap.Add(p.nome, titles);
            }

            return View(aulasMap);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.Utilizadores user)
        {

            if (ModelState.IsValid)
            {
                try{
                    using (var db = new UtilizadoresDBcontext())
                    {
                        db.Utilizadores.Add(user);
                        db.SaveChanges();
                        FormsAuthentication.SetAuthCookie(user.username, true);
                        Session["userID"] = user.username;
                        return RedirectToAction("Index", "Home");
                    }

                }
                catch (Exception e)
                {
                    System.Console.Write(e.StackTrace);
                    ModelState.AddModelError("username", "Username já está a ser usado");
                }
            }
            else
            {
                ModelState.AddModelError("username", "Username já está a ser usado");
            }

            return View(user);

        }

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.ViewUser user)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    using (var db = new UtilizadoresDBcontext())
                    {
                        Utilizadores usr = db.Utilizadores.Find(user.username);
                        if (usr != null)
                        {
                            if (usr.password.Equals(user.password))
                            {
                                FormsAuthentication.SetAuthCookie(user.username, true);
                                Session["userID"] = usr.username;
                                Session["points"] = usr.pontos;
                                return RedirectToAction("Index", "Home");
                            }
                            else {
                                ModelState.AddModelError("password", "Esta password está errada!");
                            }
                        }
                        else {
                            ModelState.AddModelError("username", "Não existe ninguem com este Username!");
                        }
                        
                    }

                }
                catch (Exception e)
                {
                    //depois rederecionar para a pagina de erro!
                    System.Console.Write(e.StackTrace);
                    ModelState.AddModelError("", "Dados Errados");
                }
            }
            else
            {
                ModelState.AddModelError("", "Dados Errados");
            }
            return View(user);
        }
        /*
         * fazer os detalhes do utilizador, mudar settings e assim
         */
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["userID"]=null;
            Session["points"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}