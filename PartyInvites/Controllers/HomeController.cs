using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View();

        }

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponses guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer
                return View("Thanks", guestResponse);

            }

            else
            {
                //there is a validation error    
                return
                View();
            }
        }
    }
}