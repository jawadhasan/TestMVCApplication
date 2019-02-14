using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            
            // create a new Movie object with instance name jungleBook, using the constructures in paranthesis
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Ridley Scott");
            Movie becomingAstrid = new Movie("Becoming Astrid", 200.10m, "becomingAstrid.png", "Ridley Scott");
            Movie starBorn = new Movie("A star is born", 180.10m, "starBorn.png", "Ridley Scott");

            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.BecomingAstrid = becomingAstrid;
            ViewBag.StarBorn = starBorn;

            return View();
        }
    }
}