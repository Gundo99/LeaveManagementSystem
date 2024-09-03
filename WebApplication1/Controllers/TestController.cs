using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Victor",
                DateOfBirth = new DateTime(1999,02,10)
            };
            return View(data);
        }
    }
}
