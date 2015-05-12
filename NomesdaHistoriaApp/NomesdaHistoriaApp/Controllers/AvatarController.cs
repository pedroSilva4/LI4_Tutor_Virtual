using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NomesdaHistoriaApp.Controllers
{
    public class AvatarController : Controller
    {
        // GET: Avatar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostraTutor(String username)
        {
            return View();   
        }
    }
}