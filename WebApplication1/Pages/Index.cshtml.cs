using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using TylersWebPage.Data;

namespace TylersWebPage.Pages
{
    public class IndexModel : PageModel
    {



        private readonly ApplicationDbContext _db;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
    

        public void OnGet()
        {
       

        }
    }
}