using System.Configuration;

namespace BlugAppCode
{
    public static class BlugSettings
    {
        public static string ContactEmailAddress
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

        public static string ContactEmailSubject
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
    }
}