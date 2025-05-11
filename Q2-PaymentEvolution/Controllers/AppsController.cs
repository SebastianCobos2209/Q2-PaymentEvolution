using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Q2_PaymentEvolution.Models;

namespace Q2_PaymentEvolution.Controllers
{
    public class AppsController : Controller
    {
        public JsonResult GetApplications()
        {
            var applications = new List<Application>
            {
                new Application
                {
                    AppID= 1,
                    AppName="Facebook",
                    AppDetails="Facebook Details",
                    AppAvatar=GenerateAvatar("FaceBook")
                },
                new Application
                {
                    AppID= 2,
                    AppName="Instagram",
                    AppDetails="Instagram Details",
                    AppAvatar=GenerateAvatar("Instagram")
                },
                new Application
                {
                    AppID= 3,
                    AppName="Twitter",
                    AppDetails="Twitter Details",
                    AppAvatar=GenerateAvatar("Twitter")
                },
                new Application
                {
                    AppID= 4,
                    AppName="Google Maps",
                    AppDetails="Google Maps Details",
                    AppAvatar=GenerateAvatar("Google Maps")
                },
                new Application
                {
                    AppID= 5,
                    AppName="GitHub",
                    AppDetails="GitHub Details",
                    AppAvatar=GenerateAvatar("Git Hub")
                },
                new Application
                {
                    AppID= 6,
                    AppName="Steam",
                    AppDetails="Steam Details",
                    AppAvatar=GenerateAvatar("Steam")
                },
                new Application
                {
                    AppID= 7,
                    AppName="Youtube",
                    AppDetails="Youtube Details",
                    AppAvatar=GenerateAvatar("You Tube")
                },
                new Application
                {
                    AppID= 8,
                    AppName="Slack",
                    AppDetails="Slack Details",
                    AppAvatar=GenerateAvatar("Slack")
                },
                new Application
                {
                    AppID= 9,
                    AppName="Jira",
                    AppDetails="Jira Details",
                    AppAvatar=GenerateAvatar("Jira")
                },
                new Application
                {
                    AppID= 10,
                    AppName="Google",
                    AppDetails="Google Details",
                    AppAvatar=GenerateAvatar("Google")
                },

            };

            return Json(applications, JsonRequestBehavior.AllowGet);
        }

        private string GenerateAvatar(string appName) {
            appName = appName.Trim();

            if (!appName.Contains(" ")) return appName.Length >= 2 ? appName.Substring(0, 2).ToUpper() : appName.ToUpper();

            string[] words = appName.Split(' ');
            string avatar = "";

            foreach(var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                    avatar += word[0];
            }
            return avatar.ToUpper();
        
        }
    }
}
