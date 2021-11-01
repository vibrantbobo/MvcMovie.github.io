using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Check(String username, String pwd) {
            //验证用户名密码
            if (!String.IsNullOrEmpty(username) && username.Equals("admin") && !String.IsNullOrEmpty(pwd) && pwd.Equals("admin")) {
                HttpContext.Session.SetString("username", username);
                TempData["Error"] = "登陆成功";

                return RedirectToAction("Index", "Hello");
            }

            TempData["Error"] = "用户名或密码错误";
            return RedirectToAction("Index", "Login");
        }
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
