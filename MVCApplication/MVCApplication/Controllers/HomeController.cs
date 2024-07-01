using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello!";
            //System.IO.File.WriteAllText(@"C:\Users\HP\DevHub\C# Lessons\WebApplication1\log.txt", text);

            Random random = new Random(10);
            int displayedNum = random.Next();

            //how to display different views
            //if (displayedNum > 2000)
            //{
                //return View("About");
                //return Content("Hello");
                //return RedirectToAction("Contact");
            //}

            //how to pass a model to the view method
            //List<string> names = new List<string> { "Favour", "Daniel", "Mark" };
            User user = new User();
            user.id = 1;
            user.FName = "Favour";
            user.LName = "Umogbai";
            user.Age = 40;

            ViewBag.randomNumber = displayedNum;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.id = id;
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}