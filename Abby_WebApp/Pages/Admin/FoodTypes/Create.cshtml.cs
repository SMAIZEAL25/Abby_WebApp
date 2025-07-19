using Abby_WebApp.Data;
using Abby_WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby_WebApp.Pages.Admin.FoodTypes
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDb;
        public FoodType FoodType { get; set; }
        public CreateModel(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                _applicationDb.FoodType.Add(FoodType);
                _applicationDb.SaveChanges();
                TempData["success"] = "FoodType created successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
