using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
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
        Tama newTama = new Tama (Request.Form["new-name"]);
        newTama.Save();
        return View(newTama);
        }
        // [Route("/tamagotchi/list")]
        // public ActionResult TamagotchiList()
        // {
        //
        //   List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
        //   return View(allTamagotchis);
        // }
        //
        // [HttpPost("/tamagotchi/create")]
        // public ActionResult CreateTamagotchi()
        // {
        //   Tamagotchi newTamagotchi = new Tamagotchi (Request.Form["new-make"], Request.Form["new-model"], int.Parse(Request.Form["new-year"]), Request.Form["new-color"]);
        //   newTamagotchi.Save();
        //   return View(newTamagotchi);
        // }
        //
        // [HttpPost("/tamagotchi/list/clear")]
        // public ActionResult TamagotchiListClear()
        // {
        //     Tamagotchi.ClearAll();
        //     return View();
        // }

    }
}
