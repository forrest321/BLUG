using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLUG.Models;

namespace BLUG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactUsModel model)
        {
            //WRONG!
            if (!ViewData.ModelState.IsValid)
                return View(model);
            else
            {
                //TODO:  Validate that they want to send the email.
                if (CommonUtilities.Email.Send("toAddress@here.com", "changeToArray", "ditto", "from address", "subject", "body", true))
                {
                    //woohoo! email sent
                    //SEND TO THANKS, ACCOUNT, etc
                }
                else
                {
                    //something happened.  or didnt happen.
                    //TODO: figure out whats wrong
                    //user gonna have to fix that
                    return View(model);
                }
            }

            return View();
        }

        public ActionResult History()
        {
            return View();
        }
    }
}
