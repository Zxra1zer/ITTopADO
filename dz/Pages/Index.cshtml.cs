using Microsoft.AspNetCore.Mvc.RazorPages;
namespace dz.Pages;
public class IndexModel : PageModel
{
    public char RandomLetter { get; set; }

    public void OnGet()
    {
        Random random = new Random();
        int number = random.Next(0, 26);
        RandomLetter = (char)('A' + number);
    }
}