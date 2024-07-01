using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.Signups.Where(x => x.removed == null).ToList();
                var signups = (from c in db.Signups
                               where c.removed == null
                               select c).ToList();
                var signupVMs = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVM();
                    signupVm.id = signup.id;
                    signupVm.firstName = signup.firstName;
                    signupVm.lastName = signup.lastName;
                    signupVm.emailAddress = signup.emailAddress;
                    signupVMs.Add(signupVm);
                }
                return View(signupVMs);
            }
        }

        public ActionResult Unsubcribe(int id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.Signups.Find(id);
                signup.removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("index");
        }
    }
}