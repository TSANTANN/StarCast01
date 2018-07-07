using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Mvc.Controllers
{
    public class LoginMedicoController : Controller
    {

        private StarCastDBContex db = new StarCastDBContex();
        string MedicosId;

        // GET: LoginMedico
        public ActionResult Index()
        {

            ViewBag.MedicosId = new SelectList
                (
                   db.Medicos.ToList(), "Id", "Nome", MedicosId
                );


            return View();
        }
        [HttpPost]
        public ActionResult Index(string MedicosId)
        {
            Session["IdMedico"] = MedicosId;
            Session["Perfil"] = 2;
            return RedirectToAction("Index","Agendamentoes");
        }
    }
}