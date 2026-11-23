using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dz.Pages;

public class CountriesModel : PageModel
{
    public List<string> Countries { get; set; } = new List<string>
    {
        "Россия",
        "Германия",
        "Франция",
        "Италия",
        "Япония",
        "Китай",
        "Бразилия",
        "Канада",
        "Австралия",
        "Испания"
    };

    public void OnGet()
    {
    }
}