using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curtain.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public Boolean featureOne { get; set; }
        public Boolean featureTwo { get; set; }
        public Boolean featureThree { get; set; }
        public string orderColor { get; set; }
        public string orderRoom { get; set; }
        public string orderHeight { get; set; }
        public string orderWidth { get; set; }

    }
}
