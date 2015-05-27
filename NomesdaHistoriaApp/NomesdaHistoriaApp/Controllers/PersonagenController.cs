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
        public ActionResult MostraTutor()
        {
            UtilizadoresDBcontext usersDB = new UtilizadoresDBcontext();
            String avatar = usersDB.Utilizadores.Find(Session["userID"]).avatar;
            PerosnagensDBContext personagensDB = new PerosnagensDBContext();
            Personagen p = personagensDB.Personagens.Find(avatar);

            PersonagemViewModel pvm = new PersonagemViewModel();
            pvm.nome = p.nome;
            pvm.sprite = p.sprite;
            pvm.etapa = p.etapa;

            AulasDbContext aulasdb = new AulasDbContext();
            pvm.DicionariodeAjudas = new Dictionary<String, List<Ajudas>>();
            foreach (Personagen ps in personagensDB.Personagens)
            {
                String key = ps.nome;
                List<Ajudas> ajudas = new List<Ajudas>();
                foreach (Aulas al in aulasdb.Aulas.Where(al => al.personagem == key)) {
                    ajudas.AddRange(al.Ajudas);
                }
                pvm.DicionariodeAjudas.Add(key, ajudas);
            }
            

            return View(pvm);   
        }
    }
}