using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.FoodTypes
{
    [BindProperties]
    public class EditModel : PageModel
    {
        // This class represents the model for the Edit page of the FoodType
        private readonly ApplicationDbContext _dbContext;

        // Property to hold the food type being edited
        public FoodType FoodType { get; set; }

        // Constructor to inject the ApplicationDbContext
        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // This method handles the GET request to retrieve the food type by its ID
        public void OnGet(int Id)
        {
            FoodType = _dbContext.FoodType.Find(Id);
        }

        // This method handles the POST request to update the food type
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var foodTypeFromDb = _dbContext.FoodType.Find(FoodType.Id);
                if (foodTypeFromDb != null)
                {
                   
                    _dbContext.FoodType.Update(FoodType);
                    await _dbContext.SaveChangesAsync();
                    TempData["success"] = "Food Type updated successfully";
                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
