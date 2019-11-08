using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ESBCommunitySite.Models
{
    public class PotentialMember
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your primary instrument")]
        public string Instrument { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
