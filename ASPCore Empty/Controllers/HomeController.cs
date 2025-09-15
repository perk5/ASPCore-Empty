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
            return View();
        }

        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("{id?}")]
        public int Details(int id)
        {
            return id ;
        }
    }
}
