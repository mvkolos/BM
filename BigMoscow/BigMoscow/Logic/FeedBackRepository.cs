using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BigMoscow.Logic
{
    class FeedBackRepository
    {
        public List<string> DirSearch(string sDir)
        {
            List<string> pages = new List<string>();
            DirectoryInfo item = new DirectoryInfo(sDir);
            try
            {
                foreach (var f in item.GetFiles())
                {
                    if (f.Extension.Equals(".jpg"))
                    {
                        pages.Add(f.FullName);
                    }
                }
                foreach (var f in item.GetDirectories())
                {
                    DirSearch(f.FullName);
                }

            }
            catch
            {

            }


            return pages;

        }
        public void SendMessage(string question, string email)
        {
            try
            {
                MailMessage mailmess = new MailMessage();
                mailmess.From = new MailAddress("Bigmoscow@3dday.ru");
                mailmess.Subject = "PersonScheduler Notification";
                mailmess.To.Add(new MailAddress(email));
                mailmess.Body = string.Format("{0}", question);
                SmtpClient smpt = new SmtpClient("smtp.rambler.ru", 25);
                smpt.EnableSsl = true;
                smpt.Credentials = new NetworkCredential("Bigmoscow@3dday.ru".Split('@')[0], "bigmsc");
                smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
                smpt.Send(mailmess);
                smpt.Dispose();


            }
            catch (Exception)
            {


            }

        }
        public void SendPDF(string email)
        {
            MailMessage mailmess = new MailMessage();
            mailmess.From = new MailAddress("Bigmoscow@3dday.ru");
            mailmess.Subject = "BIGMOSCOW";
            mailmess.To.Add(new MailAddress(email));
            mailmess.Body = Properties.Resources.email;
            //string.Format("{0}", "Здравствуйте!/n Во вложении - ваша копия журнала./nBIGMOSCOW");
            // Attachment attach = new Attachment(@"..\..\Files\SALT.pdf");
            // mailmess.Attachments.Add(attach);
            SmtpClient smpt = new SmtpClient("smtp.yandex.ru", 25);
            smpt.EnableSsl = true;
            smpt.Credentials = new NetworkCredential("Bigmoscow@3dday.ru".Split('@')[0], "bigmsc");
            smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
            smpt.Send(mailmess);
            smpt.Dispose();
        }
    }
}
