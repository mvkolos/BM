using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows;

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
        public void SendMessage(string question)
        {
            try
            {
                SmtpClient smpt = new SmtpClient("smtp.yandex.ru", 25);

                smpt.EnableSsl = true;
                smpt.UseDefaultCredentials = false;
                smpt.Credentials = new NetworkCredential("bigmoscow@3dday.ru"/*.Split('@')[0]*/, "bigmsc");

                smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage mailmess = new MailMessage();
                mailmess.From = new MailAddress("bigmoscow@3dday.ru");
                mailmess.Subject = "BIGMOSCOW";
                mailmess.To.Add(new MailAddress("bigmoscow@3dday.ru"));
                mailmess.Body = question;
                smpt.Send(mailmess);

                smpt.Dispose();


            }
            catch (Exception)
            {

                MessageBox.Show(Properties.Resources.mail_ex);
            }

        }
        public void SendPDF(string email)
        {
            try
            {
                SmtpClient smpt = new SmtpClient("smtp.yandex.ru", 25);

                smpt.EnableSsl = true;
                smpt.UseDefaultCredentials = false;
                smpt.Credentials = new NetworkCredential("bigmoscow@3dday.ru"/*.Split('@')[0]*/, "bigmsc");

                smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage mailmess = new MailMessage();
                mailmess.From = new MailAddress("bigmoscow@3dday.ru");
                mailmess.Subject = "BIGMOSCOW";
                mailmess.To.Add(new MailAddress(email));
                mailmess.Body = Properties.Resources.email;

                Attachment attach = new Attachment(string.Format("../../../../../Files/{0}{1}.pdf", Properties.Resources.magazine, MagazineDictionary.GetDictionary()[CurrentJournal.journal]));//язык ресурсы
                mailmess.Attachments.Add(attach);



                smpt.Send(mailmess);

                smpt.Dispose();
            }
            catch (Exception)
            {

                MessageBox.Show(Properties.Resources.exception);
            }

        }
    }
}
