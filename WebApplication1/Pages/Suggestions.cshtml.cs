using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TylersWebPage.Data;
using TylersWebPage.Model;

namespace TylersWebPage.Pages
{
    public class SuggestionsModel : PageModel { 
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Description{ get; set; }
        [BindProperty]
        public DateTime Date { get; set; }

        private readonly ApplicationDbContext _db;
        public IEnumerable<Suggestion> Suggestions { get; set; }
        public SuggestionsModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Suggestions = _db.Suggestion;
        }
        public IActionResult OnPost()
        {
            var suggestion = new Suggestion()
            {
                Name = Name,
                Description = Description
            };

            _db.Suggestion.Add(suggestion);
            _db.SaveChanges();
            return Redirect("/Suggestions");
        }

        /* public IActionResult OnPost(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }
             var category = _db.Suggestion.Find(id);
             _db.Suggestion.Remove(category);
             _db.SaveChanges();
             return Redirect("/Suggestions");
         }*/
    }
}