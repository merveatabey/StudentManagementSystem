using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Areas.User.Models;

namespace StudentManagementSystem.Areas.User.Controllers
{
    [Area("User")]
    public class RegisterController : Controller
    {
        //UserManager hazır olarak geliyor. User entity yi kullanıyorum. İsmine de _userManager verdim.
        private readonly UserManager<EntityLayer.Concrete.User> _userManager;

        public RegisterController(UserManager<EntityLayer.Concrete.User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegister)
        {
            if(ModelState.IsValid)
            {      
                EntityLayer.Concrete.User w = new EntityLayer.Concrete.User()
                {
                    UserName = userRegister.UserName,
                    Email = userRegister.Mail,

                };
            
                var result = await _userManager.CreateAsync(w, userRegister.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        //key değerini boş bıraktık, mesaj kısmına da hatanın açıklamasını yazdır dedik.
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            
            return View(userRegister);
        }
    }
}
