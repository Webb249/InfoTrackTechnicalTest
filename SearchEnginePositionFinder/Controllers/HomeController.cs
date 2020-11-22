using Microsoft.AspNetCore.Mvc;
using SearchEnginePositionFinder.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SearchEnginePositionFinder.Controllers
{
    public class HomeController : Controller
    {
        IndexModel IndexModelData = new IndexModel();

        [HttpGet]
        public IActionResult Index()
        {

            return View(IndexModelData);
        }

        [HttpPost]
        public IActionResult Index(string searchphrase, string searchwebsite, string searchengine)
        {

            IndexModelData.SearchPhrase = searchphrase;
            IndexModelData.SearchSite = searchwebsite;
            IndexModelData.SearchEngine = searchengine;

            Task t = IndexModelData.RunGetURLPositionAsync();
            t.Wait();
      
            return View(IndexModelData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
