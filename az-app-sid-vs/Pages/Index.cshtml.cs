using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_app_sid_vs.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _configuration;


    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        this._configuration = configuration;
    }

    public void OnGet()
    {
        //These are development settings we can set this value in
        //App Settings of Configuration Settings of  Azure for Production Enviroment
        ViewData["Greeting"] = _configuration["Greeting"];


    }
}
