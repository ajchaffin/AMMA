using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMMA.Controllers
{
    public class ClassesController : Controller
    {
        //
        // GET: /Classes/

        public ActionResult Index(int id=0)
        {
            TempData["CurrentTab"] = id;
            return View();
        }
        
    }
}
