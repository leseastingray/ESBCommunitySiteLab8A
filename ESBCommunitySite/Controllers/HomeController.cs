using ESBCommunitySite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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
        // new Controller method #1 - returns Json of past year's concerts
        public JsonResult ConcertHistory2018()
        {
            return Json(new[] {"Fall 2018 Concert: November 4th, 3:30pm",
                "Winter 2019 Concert: March 3rd, 3:30pm", "Outreach 2019 Concert: March 4th, 7:30pm",
                "Spring 2019 Concert: May 19th, 3:30pm"});
        }

        // new Controller method #2 - returns string of message from conductor
        public String ConductorMessage()
        {
            return "Hello, Eugene-Springfield community! I am proud to conduct the Eugene Symphonic Band. Get up-to-date information on the ESB on this website.";
        }
    }
}
