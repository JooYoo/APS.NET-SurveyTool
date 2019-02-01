using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyWeb.Models;

namespace SurveyWeb.Controllers
{
    public class HomeController : Controller
    {
        private static List<User> Users = new List<User>();
        private static List<Survey> Surveys = new List<Survey>();

        public IActionResult Index()
        {
            ViewData["isOk"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string accountTx, string passwordTx)
        {
            UserContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.UserContext)) as UserContext;
            //return View(context.GetAllAlbums());

            Users = context.GetAllUsers();
            var loginUser = Users.Find(x => x.Email == accountTx && x.Password == passwordTx);

            if (loginUser != null)  // succes
            {
                return RedirectToAction("About");
            }
            else // failed
            {
                ViewData["isOk"] = false;
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            SurveyContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.SurveyContext)) as SurveyContext;
            Surveys = context.GetAllSurvey();

            return View(Surveys);
        }

        [HttpPost]
        public IActionResult About(string id)
        {
            var targetId = id;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
