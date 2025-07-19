using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.FoodTypes
{
    public class IndexModel : PageModel
    // This class represents the model for the Index page of the Category
    {
        private readonly ApplicationDbContext _db;
        // Property to hold the list of categories
        public IEnumerable<FoodType> FoodTypes { get; set; }

        // Constructor to inject the ApplicationDbContext
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            FoodTypes = _db.FoodType.ToList();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var foodTypeFromDb = _db.FoodType.Find(FoodType.Id);
        //        if (foodTypeFromDb != null)
        //        {
        //            //foodTypeFromDb.Name = foodType.Name;
        //            ////foodTypeFromDb.Name = foodType.Description;
        //            _db.FoodType.Remove(foodTypeFromDb);
        //            await _db.SaveChangesAsync();
        //            TempData["success"] = "Food Type Deleted successfully";
        //            return RedirectToPage("Index");
        //        }
        //    }
        //    return Page();
        //}
    }
}
