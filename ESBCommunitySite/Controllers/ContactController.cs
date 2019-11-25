using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ESBCommunitySite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ESBCommunitySite.Controllers
{
    public class ContactController : Controller
    {
        // CONTACT/MAIL METHODS
        // Contact get method
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        // Contact post method
        [HttpPost]
        public ViewResult Contact(MessageInfo messageInfo)
        {
            // stores contact messages
            messageInfo.MessageDate = DateTime.Now;
            MailBox.AddMail(messageInfo);
            return View();
        }
        // sort mail by date 
        public ViewResult GetMail()
        {
            List<MessageInfo> mail = MailBox.Messages;
            mail.Sort((m1, m2) => DateTime.Compare(m1.MessageDate, m2.MessageDate));
            return View(mail);
        }
        // sort mail by priority
        public ViewResult GetPriorityMail()
        {
            List<MessageInfo> mail = MailBox.Messages;
            mail.Sort((m1, m2) => string.Compare(m1.MessagePriority, m2.MessagePriority, StringComparison.Ordinal));
            mail.Reverse();
            return View(mail);
        }
    }
}
