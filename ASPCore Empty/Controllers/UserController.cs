using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Empty.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
