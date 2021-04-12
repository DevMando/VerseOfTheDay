using KLOVE_Mando.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KLOVE_Mando.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Index(string startDate, string pageSize)
        {
            Bible theWord = new Bible(startDate: startDate, pageSize: pageSize);
            return View(theWord);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Save(string favorites, string serializedVerses)
        {
            Bible theWord = new Bible(favorites: favorites, verses: serializedVerses);
            var favList = theWord.GetBibleVerses().Where((v) => v.isFavorite).ToList();
            using (var db = new BibleContext())
            {
                foreach (var verse in favList)
                {
                    if (!db.Verses.Any((v) => v.Id == verse.Id))
                    {
                        db.Verses.Add(verse);
                    }
                }

                db.SaveChanges();
            }

            return View("Index", theWord);
        }

        public IActionResult Favorites()
        {
            List<Verse> myVerses;
            using (var db = new BibleContext())
            {
                myVerses = db.Verses.ToList();
            }
            return View(myVerses);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
