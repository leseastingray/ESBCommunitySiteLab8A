using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ESBCommunitySite.Models;

namespace ESBCommunitySite.Controllers
{
    public class HomeController : Controller
    {
        // Index method
        public ViewResult Index()
        {
            return View();
        }
        // History method
        public ViewResult History()
        {
            return View();
        }
        // CONTACT/MAIL METHODS
        // Contact get method
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        // Contact post method
        [HttpPost]
        public ViewResult Contact(ContactInfo contactInfo)
        {
            // stores contact messages
            MailBox.AddMail(contactInfo);
            return View();
        }
        // sort mail by date - default get mail; not tested yet
        public IActionResult GetMail()
        {
            List<ContactInfo> mail = MailBox.Mail;
            mail.Sort((m1, m2) => string.Compare(m1.MessageDate, m2.MessageDate, StringComparison.Ordinal));
            return View(mail);
        }
        // sort mail by priority; not tested yet
        public IActionResult GetPriorityMail()
        {
            List<ContactInfo> mail = MailBox.Mail;
            mail.Sort((m1, m2) => string.Compare(m1.MessagePriority, m2.MessagePriority, StringComparison.Ordinal));
            return View(mail);
        }

        // Error method
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
