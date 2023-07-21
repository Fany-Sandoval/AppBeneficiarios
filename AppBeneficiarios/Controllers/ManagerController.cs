using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppBeneficiarios.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult CreateSexo()
        {
            return View();
        }

        public ActionResult GetAllSexos()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateBeneficiarios()
        {
            return View();
        }

    }
}