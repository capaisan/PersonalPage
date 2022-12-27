using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TylersWebPage.Data;
using TylersWebPage.Model;

namespace TylersWebPage.Pages.Categories
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int DisplayOrder { get; set; }
        
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
        public IActionResult OnPost()
        {
            var category = new Category()
            {
                Name = Name,
                DisplayOrder = DisplayOrder
            };
            
            _db.Category.Add(category);
            _db.SaveChanges();
            return Redirect("/Categories");
        }
    }
}
