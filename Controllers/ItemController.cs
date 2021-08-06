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

        public class inventoryColor
        {
            public string strColor { get; set; }
        }
    }
}
