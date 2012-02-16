using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLUG;
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
            //Validation failed
            if (!ViewData.ModelState.IsValid) return View(model);
            
            if (CommonUtilities.Email.Send(ContactEmailAddress, string.Empty, string.Empty, model.EmailAddress, ContactEmailSubject, model.EmailAddress, true))
            {
                ViewBag.MessageSent = "true";
            }
            else
            {
                ViewBag.MessageSent = "false";
            }

            return View(model);
        }

        public ActionResult History()
        {
            return View();
        }

        #region properties
        private static string ContactEmailAddress
        {
            get
            {
                var rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
                var emailAddress = rootWebConfig.AppSettings.Settings["ContactEmail_ToAddress"];
                if (emailAddress == null || string.IsNullOrEmpty(emailAddress.Value))
                    throw new ConfigurationErrorsException("Configure ContactEmail_ToAddress as an app setting in the root web.config");
                return emailAddress.Value;
            }
        }

        private static string ContactEmailSubject
        {
            get
            {
                var rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
                var emailAddress = rootWebConfig.AppSettings.Settings["ContactEmail_Subject"];
                if (emailAddress == null || string.IsNullOrEmpty(emailAddress.Value))
                    throw new ConfigurationErrorsException("Configure ContactEmail_Subject as an app setting in the root web.config");
                return emailAddress.Value;
            }
        }
        #endregion
    }
}
