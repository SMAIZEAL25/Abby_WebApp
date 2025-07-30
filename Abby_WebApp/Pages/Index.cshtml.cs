using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Abby_Web.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, ErrorMessage = "Name is too long")]
        public string UserName { get; set; }

        public void OnGet()
        {
            // Initialization if needed
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the form submission
            // Could store the name in TempData for persistence across redirects
            TempData["WelcomeMessage"] = $"Welcome back, {UserName}!";

            return RedirectToPage("/Index");
        }
    }
}
