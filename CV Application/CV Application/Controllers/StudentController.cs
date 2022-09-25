using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV_Application.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewData["Name"] = "Abidur Rahman Nabil";
            ViewData["ID"] = "19-41607-3";
            ViewData["Dept"] = "CSE";

            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult References()
        {
            ViewBag.F1 = "Rashidul Hasan Nabil";
            ViewBag.F1P = "Lecturer";
            ViewBag.F1U = "American International University Bangladesh";
            ViewBag.F1D = "Faculty of Science and Technology";
            ViewBag.F1E = "rashidul@aiub.edu";

            ViewBag.F2 = "Ayesha Siddiqua";
            ViewBag.F2P = "Assistant Professor";
            ViewBag.F2U = "American International University Bangladesh";
            ViewBag.F2D = "Faculty of Science and Technology";
            ViewBag.F2E = "ayesha.siddiqua@aiub.edu";
            return View();
        }
    }
}