using Microsoft.AspNetCore.Mvc;
using ASPCore_Empty.Models;

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
            List<Student> std = new List<Student>();
            std.Add(new Student { studentId = 1, name = "Prerak", description = "IT", age = 22 });
            std.Add(new Student { studentId = 2, name = "Raja", description = "Designer", age = 27 });
            std.Add(new Student { studentId = 3, name = "Tithi", description = "Doctor", age = 24 });
            std.Add(new Student { studentId = 4, name = "Rajavi", description = "Marketing", age = 28 });
            //ViewData["Data1"] = "View Data";
            //ViewBag.data2 = "Bag";
            //TempData["Data2"] = "Temp Data";
            //TempData.Keep();
            return View(std); // ViewResults, PartialViewResults , JsonResult all have implemented IActionResult
        }

        //[Route("[action]")]
        public IActionResult About()
        {
            //TempData.Keep();
            List<Student> std = new List<Student>();
            std.Add(new Student { studentId = 1, name = "Prerak", description = "IT", age = 22 });
            std.Add(new Student { studentId = 2, name = "Raja", description = "Designer", age = 27 });
            std.Add(new Student { studentId = 3, name = "Tithi", description = "Doctor", age = 24 });
            std.Add(new Student { studentId = 4, name = "Rajavi", description = "Marketing", age = 28 });
            return View(std);
        }

        //[Route("{id?}")]
        public IActionResult Contact()
        {
            //TempData.Keep();
            List<Student> std = new List<Student>();
            std.Add(new Student { studentId = 1, name = "Prerak", description = "IT", age = 22 });
            std.Add(new Student { studentId = 2, name = "Raja", description = "Designer", age = 27 });
            std.Add(new Student { studentId = 3, name = "Tithi", description = "Doctor", age = 24 });
            std.Add(new Student { studentId = 4, name = "Rajavi", description = "Marketing", age = 28 });
            return View(std);
        }
    }
}


//ViewData["Name"] = "Prerak";
//ViewData["Age"] = 22;
//ViewData["DateTime"] = DateTime.Now.ToLongDateString();


//string[] arr = { "Prerak", "Raj", "Ram" };
//ViewData["array"] = arr;

//List<string> list1 = new List<string> { "Perk", "Raja", "Jack" };

//ViewData["ListNames"] = list1;

//ViewBag.Age = 5;
//ViewBag.Name = "Prerak";
//ViewBag.DateTime = DateTime.Now.ToShortDateString();

//string[] arr = { "Prerak", "Raj", "Ram" };

//ViewBag.array = arr;

//ViewData["MyName"] = "Perkk";

//ViewBag.Data = "Hello World";

//List<string> l1 = new List<string> { "Perk", "Man", "Jack" };

//ViewBag.list1 = l1;