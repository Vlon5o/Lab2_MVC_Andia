using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Andia.Models;

namespace Lab2_MVC_Andia.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }


        //Solo retornamos el Visualizar
        public ActionResult Visualizar(Cls_Bisiesto objBisiesto)
        {
            return View(objBisiesto);
        }
    }
}