using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Registration.Areas.Identity.Pages.Account
{
    public class LogOutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LogOutModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            
            await _signInManager.SignOutAsync();
            return Page();
        }
    }
}
