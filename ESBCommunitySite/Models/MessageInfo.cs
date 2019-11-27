using System;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ESBCommunitySite.Models
{
    public class MessageInfo
    {
        // ID for Primary key
        public int MessageInfoID { get; set; }
        [Required(ErrorMessage = "Please enter the recipient's name")]
        public string Recipient { get; set; }
        [Required(ErrorMessage = "Please enter some message text")]
        public string MessageText { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Sender { get; set; }

        public DateTime MessageDate { get; set; }
        // 0 = no priority, 1 = low priority, 2 = medium priority, 3 = high priority
        public string MessagePriority { get; set; }

    }
}
