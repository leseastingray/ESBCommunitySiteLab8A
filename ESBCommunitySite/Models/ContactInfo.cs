using System;
using Microsoft.AspNetCore.Mvc;

namespace ESBCommunitySite.Models
{
    public class ContactInfo
    {
        //TODO: validation! I want everything filled in
        public string Recipient { get; set; }
        public string MessageText { get; set; }
        public string Sender { get; set; }
        //TODO: Just added these two; not tested yet
        public string MessageDate { get; set; }
        public string MessagePriority { get; set; }
    }
}
