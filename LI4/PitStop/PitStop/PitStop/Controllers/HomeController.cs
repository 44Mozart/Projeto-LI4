using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PitStop.Models;
using PitStop.DataAccess;

namespace PitStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(LogInModel model)
        {
            UtilDAO dao = new UtilDAO();
            bool res = dao.LogIn(model.Username, model.Password);

            if (res)
                return RedirectToAction("Index", "Home");
            else
                return View("Login");
        }

        public IActionResult Registo()
        {
            return View("Registo");
        }
        [HttpPost]
        public ActionResult Registo(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                Utilizador u = new Utilizador(-1, model.Username, model.Pass, model.Email);
                UtilDAO daou = new UtilDAO();

                bool flag = daou.Insert(u);

                if (flag)
                    return RedirectToAction("Index", "Home", new { area = "" });
                else
                    model.Username= "";
            }
            return RedirectToAction("Index", "Home");
           }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
