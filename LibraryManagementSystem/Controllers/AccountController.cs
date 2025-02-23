using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    // Authentication & Authorization 
    public class AccountController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public AccountController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpFormViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }

            var newFileName = "";

            if (formData.Image is not null)
            {
                var allowedFileTypes = new string[] { "image/jpeg", "image/jpg", "image/png", "image/jfif", "image/avif" };
                var allowedFileExtensions = new string[] { ".jpg", ".jpeg", ".png", ".jfif", ".avif" };

                var fileContentType = formData.Image.ContentType;
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(formData.Image.FileName);
                var fileExtension = Path.GetExtension(formData.Image.FileName);

                if (!allowedFileTypes.Contains(fileContentType) || !allowedFileExtensions.Contains(fileExtension))
                {
                    return View(formData);
                }

                newFileName = fileNameWithoutExtension + "-" + Guid.NewGuid() + fileExtension;
                var folderPath = Path.Combine("Users", "Profiles"); // Users/Profiles
                var wwwrootFolderPath = Path.Combine(_environment.WebRootPath, folderPath); // wwwroot/Users/Profiles

                // Create wwwroot/Users/Profiles folder if it doesn't exist
                Directory.CreateDirectory(wwwrootFolderPath);

                var filePath = Path.Combine(wwwrootFolderPath, newFileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    formData.Image.CopyTo(filestream);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.Email == "test@example.com" && model.Password == "1234")
            {
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return View(model);
        }
    }
}