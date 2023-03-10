using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TylersWebPage.Model;

namespace TylersWebPage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Suggestion> Suggestion { get; set; }
      /*  public DbSet<IdentityDbContext> Identities { get; set; }*/

    }
}
