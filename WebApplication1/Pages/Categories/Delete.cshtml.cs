using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TylersWebPage.Data;
using TylersWebPage.Model;

namespace TylersWebPage.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int DisplayOrder { get; set; }

        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
        public IActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _db.Category.Find(id);
            _db.Category.Remove(category);
            _db.SaveChanges();
            return Redirect("/Categories");
        }
    }
}