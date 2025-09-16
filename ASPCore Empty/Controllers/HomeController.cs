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
