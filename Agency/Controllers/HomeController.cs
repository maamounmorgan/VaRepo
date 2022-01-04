using Agency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Agency.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            var mail = new MailMessage();
            var loginInfo = new NetworkCredential("maamounmorgan@gmail.com", "asmagroup2015");
            mail.From = new MailAddress(contact.Email);
            mail.To.Add(new MailAddress("maamounmorgan@gmail.com"));
            mail.Subject = contact.Subject;
            mail.IsBodyHtml = true;
            string body = "اسم المرسل" + contact.Name + "<br>" +
                          "رقم الهاتف" + contact.Phone + "<br>" +
                         "بريد المرسل" + contact.Email + "<br>" +
                         "عنوان الرسالة " + contact.Subject + "<br>" +
                         "نص الرسالة <b>" + contact.Message + "</b>";
            mail.Body = body;

            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = loginInfo

            };
            smtpClient.Send(mail);
            return RedirectToAction("Index");

        }
    }
}