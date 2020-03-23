using System;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers{
    public class HomeController : Controller{
        private IRepository repository;

        public HomeController(IRepository repo){
            this.repository = repo;
        }

        public ViewResult Index(){

            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 17 ? "Good day" : "Good evenig";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm() => View();

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse){
            if(ModelState.IsValid){

                repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);

            } else {

                return View();

            }
        }
        public ViewResult ListResponses() => View(repository.Responses.Where(r => r.WillAttend == true));
        
    }
}