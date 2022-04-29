using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_task_api.Model
{
    public class Product
    {
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string filename { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public decimal price { get; set; }
        public int rating { get; set; }
    }
}
