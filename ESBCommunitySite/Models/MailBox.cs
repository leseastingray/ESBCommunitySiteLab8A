using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ESBCommunitySite.Models
{
    public static class MailBox
    {
        // list for collection of contactinfo (messages)
        public static List<ContactInfo> mail = new List<ContactInfo>();

        public static List<ContactInfo> Mail { get { return mail; } }

        // method to add contactinfo (messages) to mail list
        public static void AddMail(ContactInfo contactInfo)
        {
            mail.Add(contactInfo);
        }
    }
}
