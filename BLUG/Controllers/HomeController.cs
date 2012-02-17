using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BLUG;
using BLUG.Models;

namespace BLUG.Controllers
{
    public class HomeController : Controller
    {
        private BlugEntities db = new BlugEntities();

        public ActionResult Index()
        {
            var message = new StringBuilder(db.Courses.Count().ToString(CultureInfo.InvariantCulture) + " Course(s) |");
            message.AppendLine(db.ClassOfferings.Count().ToString(CultureInfo.InvariantCulture) + " Class(es) |");
            message.AppendLine(db.Instructors.Count().ToString(CultureInfo.InvariantCulture) + " Instructor(s) |");
            message.AppendLine(db.Locations.Count().ToString(CultureInfo.InvariantCulture) + " Location(s) |");
            message.AppendLine(db.Vendors.Count().ToString(CultureInfo.InvariantCulture) + " Vendor(s) ");
            
            ViewBag.Message = message.ToString();
            ViewBag.Foo = "bar";

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
