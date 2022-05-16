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
        [HttpGet("GetAll")]
        public ActionResult GetAll(string filter)
        {
            List<Product> products = getRecordsFromFile(filter);
            return Ok(products);
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult Sort(SortObject sortObject)
        {
            List<Product> products = getRecordsFromFile(null);
            products = products.AsQueryable().OrderBy($"{sortObject.active} {sortObject.direction}").ToList();
            return Ok(products);
        }

        private List<Product> getRecordsFromFile(string filter)
        {
            var filesPath = Directory.GetCurrentDirectory() + @"\Source\products.json";
            StreamReader r = new StreamReader(filesPath);
            string jsonString = r.ReadToEnd();
            List<Product> products = new List<Product>();
            products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            if (filter!=null && filter != "undefined")
            {
                products = products.ToList().Where(column => column.name.ToLower().Contains(filter.ToLower())).ToList();
            }
            else
            {
                products = products.AsQueryable().OrderBy("name ASC").ToList();
            }
            return products;
        }
    }

    public class SortObject
    {
        public string active { get; set; }
        public string direction { get; set; }
    }
}
