using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyWeb.Models;

namespace SurveyWeb.Controllers
{
    public class HomeController : Controller
    {

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

            var users = context.GetAllUsers();
            var loginUser = users.Find(x => x.Email == accountTx && x.Password == passwordTx);

            if (loginUser != null)  // succes
            {
                RedirectToAction("About");
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
