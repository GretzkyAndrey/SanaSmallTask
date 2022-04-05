using Microsoft.AspNetCore.Mvc;
using SanaFirstApp.Models;
namespace SanaFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if (name != null)
            {
                //Username.Name = name;
                return View("Result", new UsenameViewModel() { UsenameView = name });
            }

            return View();
        }
    }
}