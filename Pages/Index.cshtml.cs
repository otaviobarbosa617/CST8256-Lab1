using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class IndexModel : PageModel
{
    //declarations
    public string FirstNumber { get; set; }
    public string SecondNumber { get; set; }
    public string ThirdNumber { get; set; }
    
    private readonly ILogger<IndexModel> _logger;

    //methods
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}