using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using xyz.Models;

namespace xyz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HeaderModel modelHeader = new HeaderModel();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult header()
        {
            HeaderModel headerModel = new HeaderModel()
            {
                name="xyz",
                home="home",
                privacy="privacy"
            };
            List<color> HList = new List<color>();

            HList.Add(new color() { Id = 1, name = "Red" });
            HList.Add(new color() { Id = 2, name = "Green" });
            HList.Add(new color() { Id = 3, name = "white" });
            HList.Add(new color() { Id = 4, name = "blue" });
            HList.Add(new color() { Id = 5, name = "black" });
            headerModel.colour = HList;
            return View(headerModel);
        }
        [HttpPost]
        public IActionResult header(HeaderModel header)
        {
            modelHeader.home = header.home;
            modelHeader.name = header.name;
            modelHeader.privacy = header.privacy;
            if(header.Selectedcolor=="1")
            {
                modelHeader.colorName = "Red";
            }
            if (header.Selectedcolor == "2")
            {
                modelHeader.colorName = "Green";
            }
            if (header.Selectedcolor == "3")
            {
                modelHeader.colorName = "White";
            }
            if (header.Selectedcolor == "4")
            {
                modelHeader.colorName = "Blue";
            }
            if (header.Selectedcolor == "5")
            {
                modelHeader.colorName = "Black";
            }
            return RedirectToAction("index", modelHeader);
        }
        public IActionResult Index(HeaderModel header)
        {
            if(header.name != null)
            {
                return View(header);
            }
            HeaderModel headerModel = new HeaderModel()
            {
                name = "xyz",
                home = "home",
                privacy = "privacy",
                colorName="White"
            };
            

            return View(headerModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
