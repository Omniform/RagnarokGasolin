using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class GasolinModel : PageModel
    {
        private readonly ILogger<GasolinModel> _logger;

        public GasolinModel(ILogger<GasolinModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
