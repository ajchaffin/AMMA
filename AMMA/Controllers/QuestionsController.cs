using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace AMMA.Controllers
{
    public class QuestionsController : Controller
    {
        //
        // GET: /Questions/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitQuestion(AMMA.Models.QuestionsModel model)
        {
            var mail = new MailMessage();

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Credentials = new System.Net.NetworkCredential("adamchaffin7", "Chapstik*3");
            smtpServer.Port = 587; // Gmail works on this port

            mail.From = new MailAddress(model.EmailAddress);
            mail.To.Add("adamchaffin7@gmail.com");
            mail.Subject = "Test";
            mail.Body = model.Question;

            smtpServer.Send(mail);
            return View("Index");
        }

    }
}
