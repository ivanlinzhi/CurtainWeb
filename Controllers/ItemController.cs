using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Curtain.Data;
using Curtain.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        [HttpPost("CurtainCheckoutAPI")]
        public void CurtainCheckoutAPI(string Cart,string Email,string PhoneNum)
        {
            List<ProductModel> CartList = JsonConvert.DeserializeObject<List<ProductModel>>(Cart);
            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            String msg = "Email: " + Email;
            msg += " Phone Number: " + PhoneNum + "\n\n";
            msg += "Ordered Items:\n\n";

            for (int i = 0; i < CartList.Count; i++)
            {
                msg += "Order " + (i + 1) + ":\n";
                msg += "Width: " + CartList[i].orderWidth + " inches\n";
                msg += "Height: " + CartList[i].orderHeight + " inches\n";
                msg += "Color: " + CartList[i].orderColor + "\n";
                msg += "Room: " + CartList[i].orderRoom + "\n";
                msg += "Features:\n\n";
                msg += "Motor: " + CartList[i].featureOne + "\n";
                msg += "Google: " + CartList[i].featureTwo + "\n";
                msg += "Manual: " + CartList[i].featureThree + "\n";
                msg += "\n";
            }

            m.From = new MailAddress("postmaster@tamily.ca");
            m.To.Add("j.linyolo@gmail.com");
            m.Subject = "Order for " + Email;
            m.Body = msg;
            sc.Host = "mail.tamily.ca";

            sc.Port = 25;
            sc.Credentials = new System.Net.NetworkCredential("postmaster@tamily.ca", "Jonny@951021");
            sc.EnableSsl = false;
            sc.Send(m);

        }

        public class CheckoutList
        {

        }
        public class inventoryColor
        {
            public string strColor { get; set; }
        }
    }
}
