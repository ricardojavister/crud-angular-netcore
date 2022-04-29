using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using tech_task_api.Model;
using System.Linq.Dynamic.Core;

namespace tech_task_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll() {
            return Ok(getRecordsFromFile());
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult Sort(SortObject sortObject)
        {
            List<Product> products = getRecordsFromFile();
            products = products.AsQueryable().OrderBy($"{sortObject.active} {sortObject.direction}").ToList();      
            return Ok(products);
        }

        private List<Product> getRecordsFromFile() {
            var filesPath = Directory.GetCurrentDirectory() + @"\Source\products.json";
            StreamReader r = new StreamReader(filesPath);
            string jsonString = r.ReadToEnd();
            List<Product> products = new List<Product>();
            products =  JsonConvert.DeserializeObject<List<Product>>(jsonString);
            products = products.AsQueryable().OrderBy("name ASC").ToList();
            return products;
        }
    }

    public class SortObject {
        public string active { get; set; }
        public string direction { get; set; }
    }
}
