using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers
{
    [RemoteService(Name = "Acme.BookStore")]
    [Area("your-area-name")]
    [Route("api/[controller]")]
    public class DataController : AbpController
    {
        [HttpGet("chart-data")]
        public IActionResult GetChartData()
        {
            // Read the JSON data from the file
            string jsonFilePath = @"C:\Users\Waleed Hassan\Downloads\Chart Four - Data.txt";
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);

            // Return the JSON data
            return Ok(jsonData);
        }
    }
}
