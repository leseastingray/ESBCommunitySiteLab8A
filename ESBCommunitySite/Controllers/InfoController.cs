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
        // new Controller method #3 - returns IActionResult
        public IActionResult AuditionRequest()
        {
            return View();
        }
        // new Controller method #2 - returns RedirectToAction
        [HttpPost]
        public RedirectToActionResult AuditionRequest(string name, string instrument, DateTime requestDate)
        {
            // creates potential member and allows properties to be set
            PotentialMember potential = new PotentialMember();
            potential.Name = name;
            potential.Instrument = instrument;
            // time stamp
            potential.RequestDate = DateTime.Now;
            // redirects to Info View
            return RedirectToAction("Info");
        }
        // Location method
        public ViewResult Location()
        {
            return View();
        }
        // TODO get the Roster by Instrument to work on the View
        public ViewResult Roster()
        {
            List<Member> currentRoster = Models.Roster.GetMembers();
            ViewBag.flutes = new List <Member>(currentRoster.FilterByInstrument("flute"));
            ViewBag.oboes = new List<Member>(currentRoster.FilterByInstrument("oboe"));
            ViewBag.clarinets = new List<Member>(currentRoster.FilterByInstrument("clarinet"));
            ViewBag.saxes = new List<Member>(currentRoster.FilterByInstrument("saxophone"));
            ViewBag.horns = new List<Member>(currentRoster.FilterByInstrument("French horn"));
            ViewBag.trumpets = new List<Member>(currentRoster.FilterByInstrument("trumpet"));
            ViewBag.trombones = new List<Member>(currentRoster.FilterByInstrument("trombone"));
            ViewBag.euphoniums = new List<Member>(currentRoster.FilterByInstrument("euphonium"));
            ViewBag.tubas = new List<Member>(currentRoster.FilterByInstrument("tuba"));
            ViewBag.percussion = new List<Member>(currentRoster.FilterByInstrument("percussion"));
            return View();
        }
        // Roster by join date - working!
        public ViewResult RosterByJoinDate()
        {
            List<Member> roster = Models.Roster.GetMembers();
            roster.Sort((r1, r2) => string.Compare(r1.DateJoined.Substring((r1.DateJoined.Length - 4)),
                r2.DateJoined.Substring(r2.DateJoined.Length - 4), StringComparison.Ordinal));
            return View(roster);

        }
    }
}