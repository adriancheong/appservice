using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AzureAppService.Pages
{
    public class IndexModel : PageModel
    {
        public string Environment { get; set; }
        public IndexModel(IConfiguration config)
        {
            Environment = config["myval"];
        }

        public void OnGet()
        {

        }
    }
}
