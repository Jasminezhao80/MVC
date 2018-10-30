using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        //方法名必须与Views/User下的cshtml文件名字一致，当return View(),就会跳转到相应的视图页面
        public ActionResult LoginSuccess()
        {
            //string name = Request["userName"].ToString();
            return View();
        }
        [HttpPost]
        //public ActionResult Login(string name, string Password)
        //{
        //    User user = new User();
        //    user.Name = name;
        //    user.Password = Password;
        //    return Json(user);
        //}
        public ActionResult Login()
        {
            User user = new User();
            user.Name = Request.Form["userName"];
            user.Password = Request.Form["password"]; ;
            return Json(user);
        }
    }
}