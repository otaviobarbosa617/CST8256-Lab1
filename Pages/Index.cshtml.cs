using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class IndexModel : PageModel
{
    //declarations
    
    [BindProperty]
    public string? FirstNumber { get; set; }
    
    [BindProperty]
    public string? SecondNumber { get; set; }
    
    [BindProperty]
    public string? ThirdNumber { get; set; }
    public List<double> Numbers { get; private set; }
    
    public string? ErrorMessage { get; private set; }

    private readonly ILogger<IndexModel> _logger;

    //methods
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Numbers = new List<double>();
    }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        if(double.TryParse(FirstNumber, out double firstNumber))
        {
            Numbers.Add(firstNumber);
        }
        
        if (double.TryParse(SecondNumber, out double secondNumber))
        {
            Numbers.Add(secondNumber);
        }
        
        if (double.TryParse(ThirdNumber, out double thirdNumber))
        {
            Numbers.Add(thirdNumber);
        }
        else
        {
            ErrorMessage = "You did not enter any number, no statistics were calculated.";
        }
    }
}