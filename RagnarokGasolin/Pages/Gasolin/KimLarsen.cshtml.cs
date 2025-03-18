using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class KimLarsenModel : PageModel
    {
        private readonly ILogger<KimLarsenModel> _logger;

        public KimLarsenModel(ILogger<KimLarsenModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
