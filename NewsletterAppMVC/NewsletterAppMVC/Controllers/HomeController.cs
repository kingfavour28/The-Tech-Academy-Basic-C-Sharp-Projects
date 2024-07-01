using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.Models;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using(NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new Signup();
                    signup.firstName = firstName;
                    signup.lastName = lastName;
                    signup.emailAddress = emailAddress;

                    db.Signups.Add(signup);
                    db.SaveChanges();
                }
                //string queryString = @"INSERT INTO Signups (firstName, lastName, emailAddress) VALUES (@firstName, @lastName, @emailAddress)";
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@firstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@lastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@emailAddress", SqlDbType.VarChar);

                //    command.Parameters["@firstName"].Value = firstName;
                //    command.Parameters["@lastName"].Value = lastName;
                //    command.Parameters["@emailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}

                return View("Success");
            }
        }
    }
}
