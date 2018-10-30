using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModel;

namespace MVC.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        public ActionResult Index()
        {
            Student student = new Student();
            student.ID = Guid.NewGuid();
            student.Name = "Jasmine";
            student.Phone = "18302983476";
            student.Address = "浦东";
            //ViewBag.Title1 = "this is viewBag transfor value.";
            //ViewData["Title2"] = "this is ViewData transfor value.";
            return View(student);
        }
        public ActionResult Index2(string id,string name)
        {
            ViewBag.ID = id;
            ViewBag.Name = name??Request["Address"];
            return View();
        }
    }
}