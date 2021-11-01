using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            //check
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("username")))
            {
                ViewData["Message"] = "this is " + HttpContext.Session.GetString("username") + " 's page.";
                return View();
            }
            else {
                return RedirectToAction("Index", "Login");
            }
        }
        //public String Welcome(String name, int n=1) {
        //    String tmp = "name=" + name + "&n=" + n;
        //    //return tmp;
        //    return HtmlEncoder.Default.Encode($"name={name}, n={n}");
        //}
        public IActionResult Welcome(String name, int n = 1) {
            ViewData["Message"] = "Hello " + name;
            ViewData["Count"] = n;
            return View();
        }
    }
}
