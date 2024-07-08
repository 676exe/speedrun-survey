using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var sorular = new List<Soru>
            {
                new Soru { Id = 1, SoruMetni = "Adınız nedir?" },
                new Soru { Id = 2, SoruMetni = "Yaşınız kaç?" },
                new Soru { Id = 3, SoruMetni = "Hangi şehirde yaşıyorsunuz?" },
                new Soru { Id = 4, SoruMetni = "Mesleğiniz nedir?" },
                new Soru { Id = 5, SoruMetni = "Hobileriniz nelerdir?" }
            };

            var viewModel = new AnketViewModel
            {
                Sorular = sorular,
                Cevaplar = new List<string>(new string[sorular.Count])
            };

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Index(AnketViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Tesekkurler");
            }

            return View(viewModel);
        }

        public ActionResult Tesekkurler()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}