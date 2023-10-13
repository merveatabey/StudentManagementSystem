using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Areas.User.Controllers
{
    [Area("User")]     //hangi area ile çalışacaksan parantez içerisinde ismini ver
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
