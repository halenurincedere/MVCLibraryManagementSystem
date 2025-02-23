using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        public static List<AuthorViewModel> authors = new List<AuthorViewModel>();
        public IActionResult List()
        {
            return View(authors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuthorViewModel model)
        {
            model.Id = authors.Any() ? authors.Max(a => a.Id) + 1 : 1;
            authors.Add(model);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            return NotFound();
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(AuthorViewModel updateAuthor)
        {
            var author = authors.FirstOrDefault(a => a.Id == updateAuthor.Id);
            if (author == null)
            return NotFound();
            
            author.FirstName = updateAuthor.FirstName;
            author.LastName = updateAuthor.LastName;
            author.DateOfBirth = updateAuthor.DateOfBirth;

            foreach (var book in author.Books)
            {
                book.AuthorName = $"{author.FirstName} {author.LastName}";
            }
            return RedirectToAction("List");
        }
        
        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null)
            return NotFound();
            return View(author);
        }

        public IActionResult Delete(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) 
            return NotFound();

            foreach (var book in author.Books)
            {
                book.AuthorId = 0;
                book.AuthorName = "Unknown"; 
            }
            authors.Remove(author);
            return RedirectToAction("List");
        }
    }
}