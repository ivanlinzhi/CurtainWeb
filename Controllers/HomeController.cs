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

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Email()
        //{
        //    //create the mail message 
        //    MailMessage mail = new MailMessage();

        //    //set the addresses 
        //    mail.From = new MailAddress("postmaster@yourdomain.com"); //IMPORTANT: This must be same as your smtp authentication address.
        //    mail.To.Add("jonathan.lin1104@gmail.com");

        //    //set the content 
        //    mail.Subject = "This is an email";
        //    mail.Body = "This is from system.net.mail using C sharp with smtp authentication.";
        //    //send the message 
        //    SmtpClient smtp = new SmtpClient("mail.yourdomain.com");

        //    //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
        //    NetworkCredential Credentials = new NetworkCredential("postmaster@yourdomain.com", "password");
        //    smtp.UseDefaultCredentials = false;
        //    smtp.Credentials = Credentials;
        //    smtp.Port = 25;    //alternative port number is 8889
        //    smtp.EnableSsl = false;
        //    smtp.Send(mail);
        //    return View();
        //}

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
