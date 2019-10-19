using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ESBCommunitySite.Models
{
    public class ContactInfo
    {
        [Required(ErrorMessage = "Please enter the recipient's name")]
        public string Recipient { get; set; }
        [Required(ErrorMessage = "Please enter some message text")]
        public string MessageText { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Sender { get; set; }

        //TODO: Just added these two; not tested yet
        public string MessageDate { get; set; }
        public string MessagePriority { get; set; }

    }
}
