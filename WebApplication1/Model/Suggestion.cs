using System.ComponentModel.DataAnnotations;

namespace TylersWebPage.Model
{
    public class Suggestion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Date { get; set; } //<-----
    }
}
