using System;
using System.Net.Mail;

namespace CommonUtilities
{
    public static class Email
    {
        public static bool Send(string toAddress, string ccAddress, string bccAddress, string fromAddress, string subject, string body, bool isHtml)
         {
            if(string.IsNullOrEmpty(toAddress))
                throw new ArgumentNullException("toAddress");

            string smtpServer;

            if (Settings.Default.Test)
            {
                if (string.IsNullOrEmpty(Settings.Default.SmtpServerTest))
                    throw new Exception("SmtpServerTest is not configured in Common Utilities App.Config");
                smtpServer = Settings.Default.SmtpServerTest;
            }
            else
            {
                if (string.IsNullOrEmpty(Settings.Default.SmtpServerProd))
                    throw new Exception("SmtpServerProd is not configured in Common Utilities App.Config");
                smtpServer = Settings.Default.SmtpServerProd;
            }
             try
             {
                 var myEmail = new MailMessage(fromAddress, toAddress);

                 if (!String.IsNullOrEmpty(ccAddress)) { myEmail.CC.Add(ccAddress); }
                 if (!String.IsNullOrEmpty(bccAddress)) { myEmail.Bcc.Add(bccAddress); }

                 myEmail.IsBodyHtml = isHtml;

                 myEmail.Body = body;

                 myEmail.Subject = subject;

                 var mySender = new SmtpClient(smtpServer);
                 mySender.Send(myEmail);

                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }
    }
}