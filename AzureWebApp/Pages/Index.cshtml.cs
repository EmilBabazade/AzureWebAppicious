using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace AzureWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void OnGet()
        {
            Trace.TraceInformation("Hellooooo");
            Trace.TraceWarning("Hellooooo");
            Trace.TraceError("Hellooooo");
            ViewData.Add("env", _config["Environment"]);
        }
    }
}