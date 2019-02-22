using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyWeb.Models;

namespace SurveyWeb.Controllers
{
    public class HomeController : Controller
    {
        private static List<User> Users = new List<User>();
        private static User loginUser;
        private static List<Survey> Surveys = new List<Survey>();
        private static string surveyId = "";
        private static List<SurveyQuestion> surveyQuestions = new List<SurveyQuestion>();
        private static List<SurveyQuestionChoice> surveyQuestionChoices = new List<SurveyQuestionChoice>();

        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Index(string accountTx, string passwordTx)
        {
            UserContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.UserContext)) as UserContext;
            //return View(context.GetAllAlbums());

            Users = context.GetAllUsers();
            loginUser = Users.Find(x => x.Email == accountTx && x.Password == passwordTx);

            if (loginUser != null)  // succes
            {
                return RedirectToAction("Surveylist");
            }
            else // failed
            {
                ViewData["isOk"] = false;
            }

            return View();
        }

        public IActionResult Surveylist()
        {
            ViewData["Message"] = "Your application description page.";

            SurveyContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.SurveyContext)) as SurveyContext;
            Surveys = context.GetAllSurvey();

            return View(Surveys);
        }
        [HttpPost]
        public IActionResult Surveylist(string id)
        {
            surveyId = id;

            // insert SurveyPaticipate
            //SurveyParticipationContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.SurveyParticipationContext)) as SurveyParticipationContext;
            //var newPaticipate = new SurveyParticipation { User_ID = loginUser.Id, Survey_ID = Convert.ToInt32(surveyId), ParticipationDate= DateTime.Now.ToString("yyyy-MM-dd"), ID=0}; 
            //context.InsertParticipation(newPaticipate);
            //var testGetall = context.GetAllParticipations();

            return RedirectToAction("Questionlist");
        }

        public IActionResult Questionlist()
        {
            ViewData["Message"] = "Go to Survey ID: " + surveyId;

            // get all surveyQuestions
            SurveyQuestionContext context = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.SurveyQuestionContext)) as SurveyQuestionContext;
            surveyQuestions = context.GetAllSurveyQuestion();

            // get all surveyQuestionChoices
            SurveyQuestionChoiceContext choiceContext = HttpContext.RequestServices.GetService(typeof(SurveyWeb.Models.SurveyQuestionChoiceContext)) as SurveyQuestionChoiceContext;
            surveyQuestionChoices = choiceContext.GetAllSurveyQuestionChoice();

            // get the Survey i need
            var targetSurveyQuestions = surveyQuestions.FindAll(x => x.SurveyId == Convert.ToInt32(surveyId));

            // add the choices to question
            foreach (var question in targetSurveyQuestions)
            {
               question.Choices =  surveyQuestionChoices.FindAll(x => x.SurveyQuestionId == question.Id);
            }

            var test = targetSurveyQuestions;

            return View(targetSurveyQuestions);
        }
        //[HttpPost]
        //public IActionResult Questionlist()
        //{

        //}



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
