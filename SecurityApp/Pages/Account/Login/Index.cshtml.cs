using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecurityApp.Pages.Account.Login;

public class Index : PageModel
{
    [BindProperty]
    public string UserName { get; set; }

    [BindProperty]
    public string Password { get; set; }

    [BindProperty(SupportsGet=true)]
    public string ReturnUrl { get; set; }

    public Index()
    {
    }

    public async Task OnGet(string returnUrl)
    {
    }

    public async Task OnPost(string returnUrl)
    {
        return Page();
    }
}