using Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Mvc.Controllers
{
    public class LoginPacienteController : Controller
    {

        private StarCastDBContex db = new StarCastDBContex();
        string PacienteId;
        // GET: LoginPaciente
        public ActionResult Index()
        {

            ViewBag.PacientesId = new SelectList
                (
                   db.Pacientes.ToList(), "Id", "Nome", PacienteId
                );


            return View();
        }
        [HttpPost]
        public ActionResult Index(string PacienteId)
        {
            Session["IdMedico"] = PacienteId;
            Session["Perfil"] = 1;
            return RedirectToAction("Index", "Agendamentoes");
        }
    }
}