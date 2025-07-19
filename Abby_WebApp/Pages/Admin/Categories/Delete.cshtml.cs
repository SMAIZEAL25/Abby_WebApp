using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public Category Category { get; set; }


        public DeleteModel(ApplicationDbContext dbContext)
        {
           
            _dbContext = dbContext;
        }
        public void OnGet(int id)
        {
            Category = _dbContext.Categories.FirstOrDefault(u => u.Id == id);
            //Category = _db.Category.FirstOrDefault(u=>u.Id==id);
            //Category = _db.Category.SingleOrDefault(u=>u.Id==id);
            //Category = _db.Category.Where(u => u.Id == id).FirstOrDefault();
        }

        public async Task<IActionResult> OnPost()
        {
            var categoryFromDb = _dbContext.Categories.FirstOrDefault(u => u.Id == Category.Id);
            if (categoryFromDb != null)
            {
                _dbContext.Categories.Remove(categoryFromDb);
                _dbContext.SaveChanges();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");

            }

            return Page();
        }
    }
}
