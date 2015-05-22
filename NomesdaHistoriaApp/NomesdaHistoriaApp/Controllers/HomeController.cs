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
        public ActionResult _ConsultarRanking()
        {
            UtilizadoresDBcontext userDB = new UtilizadoresDBcontext();
            Dictionary<String, int> res = new Dictionary<String, int>();
            foreach (Utilizadores u in userDB.Utilizadores.OrderByDescending(u => u.pontos))
            {
                res.Add(u.username, (int)u.pontos);
            }
            return View(res);
        }

        public ActionResult _ListEtapas()
        {
            AulasDbContext aulasDB = new AulasDbContext();
            PerosnagensDBContext PersonagensDb = new PerosnagensDBContext();
            Dictionary<String, List<String>> aulasMap = new Dictionary<String, List<String>>();
            int prox = 0;
            String user = Session["userID"].ToString();
            foreach(Conquistas c in aulasDB.Conquistas.Where(c => c.username.Equals(user))){
                List<String> aulas = new List<String>();
                foreach(Aulas a in aulasDB.Aulas.Where(a => a.personagem == c.personagem)){
                    aulas.Add(a.titulo);
                }
                int etapa = PersonagensDb.Personagens.Find(c.personagem).etapa;
                if (etapa > prox)
                    prox = etapa;
                aulasMap.Add(c.personagem, aulas);
            }
            prox++;
            String proxima = "";
            foreach (Personagen p in PersonagensDb.Personagens.Where(p => p.etapa == prox))
            {
                proxima = p.nome;
            }
            prox = 0;
            List<String> novas = new List<String>();
            foreach (Aulas a in aulasDB.Aulas.Where(a => a.personagem == proxima))
            {
                foreach (Avaliacoes av in aulasDB.Avaliacoes.Where(av => av.aula == a.cod && av.username == user))
                {
                        novas.Add(a.titulo);
                        if (a.ordem > prox)
                            prox = a.ordem;
                }
            }
            prox++;
            foreach (Aulas a in aulasDB.Aulas.Where(a => a.personagem == proxima && a.ordem == prox))
                novas.Add(a.titulo);
            if(!proxima.Equals(""))
                aulasMap.Add(proxima, novas); 
            return View(aulasMap);
        }
        public Dictionary<String, String> _listaAvatares()
        {
            PerosnagensDBContext personagemDB = new PerosnagensDBContext();
            Dictionary<String, String> avatarMap = new Dictionary<String, String>();
            foreach(Personagen p in personagemDB.Personagens.ToList()){
                avatarMap.Add(p.nome, p.sprite);
            }
            return avatarMap;
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