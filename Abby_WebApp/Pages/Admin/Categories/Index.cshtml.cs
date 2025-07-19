using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.Categories
{
    public class IndexModel : PageModel
    // This class represents the model for the Index page of the Category
    {
        private readonly ApplicationDbContext _db;
        // Property to hold the list of categories
        public IEnumerable<Category> Categories { get; set; }

        // Constructor to inject the ApplicationDbContext
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Categories.ToList();
        }
    }
}
