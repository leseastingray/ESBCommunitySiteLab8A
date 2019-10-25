using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESBCommunitySite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESBCommunitySite.Controllers
{
    public class InfoController : Controller
    {
        // Info method
        public ViewResult Info()
        {
            return View();
        }
        // Location method
        public ViewResult Location()
        {
            return View();
        }
        // Roster method
        public ViewResult Roster()
        {
            List<Member> currentRoster = new List<Member>();
            List<Member> flutes = new List <Member>(currentRoster.FilterByInstrument("flute"));
            return View(flutes);
        }
    }
}