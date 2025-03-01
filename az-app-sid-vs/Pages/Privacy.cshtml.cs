﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_app_sid_vs.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private readonly IConfiguration _configuration;

    public PrivacyModel(ILogger<PrivacyModel> logger,IConfiguration configuration)
    {
        _logger = logger;
        this._configuration = configuration;
    }

    public void OnGet()
    {
          
       
    }
}

