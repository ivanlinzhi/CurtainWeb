using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curtain.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Curtain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly CurtainContext _context;

        public ItemController(CurtainContext context)
        {
            _context = context;

        }

        // GET: api/<ItemController>
        [HttpGet]
        public IEnumerable<inventoryColor> Get(String ItemName)
        {
            var productList = from inventory in _context.Inventories where inventory.ItemName == ItemName select new inventoryColor { strColor = inventory.Color };
            return productList.Distinct().ToList();
        }

        [HttpPost]
        public void Post([FromBody] String Cart, String Email, String PhoneNum)
        {
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
            //    smtp.Send(mail)
        }


        public class inventoryColor
        {
            public string strColor { get; set; }
        }
    }
}
