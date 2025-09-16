using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Empty.Controllers
{
    [Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]

        //[Route("[action]")]
        public IActionResult Index()
        {
            ViewData["Name"] = "Prerak";
            ViewData["Age"] = 22;
            ViewData["DateTime"] = DateTime.Now.ToLongDateString();
            

            string[] arr = { "Prerak", "Raj", "Ram" };
            ViewData["array"] = arr;

            List<string> list1 = new List<string> { "Perk", "Raja", "Jack" };

            ViewData["ListNames"] = list1;



            return View(); // ViewResults, PartialViewResults , JsonResult all have implemented IActionResult
        }

        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("{id?}")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
