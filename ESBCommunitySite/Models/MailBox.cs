using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ESBCommunitySite.Models
{
    public static class MailBox
    {
        // list for collection of contactinfo (messages)
        public static List<MessageInfo> mail = new List<MessageInfo>();

        public static List<MessageInfo> Messages { get { return mail; } }

        // enable enumeration
        public static IEnumerable<MessageInfo> Mail
        {
            get
            {
                return mail;
            }
        }

        // method to add contactinfo (messages) to mail list
        public static void AddMail(MessageInfo contactInfo)
        {
            mail.Add(contactInfo);
        }
    }
}
