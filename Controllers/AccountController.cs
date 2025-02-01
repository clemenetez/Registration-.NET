using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class AccountController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public AccountController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                SaveToFile(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        private void SaveToFile(RegisterModel user)
        {
            var content = $"Username: {user.Username}, Email: {user.Email}, Password: {user.Password}\n";
            var filePath = Path.Combine(_env.ContentRootPath, "registrations.txt");

            System.IO.File.AppendAllText(filePath, content);
        }
    }

}
