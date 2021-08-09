using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Curtain.Models;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.Web;
using Curtain.Data;
using System.Net.Mail;
using System.Net;

namespace Curtain.Controllers
{
    public class HomeController : Controller
    {
        private readonly CurtainContext _context;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger, CurtainContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Products()
        {
            ViewData["Images"] = GetImageList("ALL");
            return View();
        }

        public IActionResult Order()
        {
            return View();
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

        public List<ImageModel> GetImageList(string ProductType){
            var rootFolder = Directory.GetCurrentDirectory();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(rootFolder + @"\wwwroot\images\Curtains\");
            FileInfo[] rgFiles = di.GetFiles("*.jpg");

            List<ImageModel> list = new List<ImageModel>();
            foreach (FileInfo fi in rgFiles)
            {
                ImageModel image = new ImageModel();
                image.ImgName = fi.Name;
                image.CurtainType = fi.Name.Split('_')[0];
                image.CurtainCode= fi.Name.Split('_')[1];
                image.ImgPath = fi.DirectoryName.Replace(rootFolder + @"\wwwroot","")+@"\";
                image.EncodedImgPath = image.ImgPath.Replace(@"\", @"\\");
                list.Add(image);

            }
            return list;
         }
    }
}
