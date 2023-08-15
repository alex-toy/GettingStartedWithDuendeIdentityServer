using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecurityApp.Pages
{
    [Authorize]
    public class SecureModel : PageModel
    {
        public async Task OnGet()
        {
        }
    }
}
