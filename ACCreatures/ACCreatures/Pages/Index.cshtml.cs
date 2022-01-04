using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ACCreatures.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Runs when the page loads
        public void OnGet()
        {
            // Provides a default value to First Name
            if (string.IsNullOrEmpty(FirstName))
            {
                FirstName = "User";
            }
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FirstName { get; set; }

        // Runs when information is provided
        public void OnPost()
        {

        }
    }
}
