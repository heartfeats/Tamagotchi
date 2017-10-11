using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;
using System.Collections.Generic;

namespace TamagotchiGame.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/tama")]
        public ActionResult Tama()
        {
        Tamagotchi newTama = new Tamagotchi (Request.Form["new-name"]);
        newTama.Save();
        return View(newTama);
        }

        [Route("/list")]
        public ActionResult List()
        {
          List<Tamagotchi> allTama = Tamagotchi.GetAll();
          return View(allTama);
        }
    }
}
