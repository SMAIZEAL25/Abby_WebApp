using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.FoodTypes
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
    
            private readonly ApplicationDbContext _db;
            // Property to hold the list of categories
            public FoodType FoodType { get; set; }

            // Constructor to inject the ApplicationDbContext
            public DeleteModel(ApplicationDbContext db)
            {
                _db = db;
            }
            public void OnGet(int Id)
            {
                FoodType = _db.FoodType.Find(Id);
            }

            public async Task<IActionResult> OnPostAsync()
            {
                if (ModelState.IsValid)
                {
                    var foodTypeFromDb = _db.FoodType.Find(FoodType.Id);
                    if (foodTypeFromDb != null)
                    {
                        //foodTypeFromDb.Name = foodType.Name;
                        ////foodTypeFromDb.Name = foodType.Description;
                        _db.FoodType.Remove(foodTypeFromDb);
                        await _db.SaveChangesAsync();
                        TempData["success"] = "Food Type Deleted successfully";
                        return RedirectToPage("Index");
                    }
                }
                return Page();
            }
        }
}

