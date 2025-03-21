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

        public Artists artists = new();

        public void OnGet()
        {
        }
    }

    public class Card
    {
        public string Title { get; set; }
        public string ImgPath { get; set; }
        public string ImpAltText { get; set; }
        public string Description { get; set; }
        public string LinkPath { get; set; }
        public string ButtonText { get; set; }

        public Card(string title, string imgPath, string impAltText, string description, string linkPath, string buttonText)
        {
            Title = title;
            ImgPath = imgPath;
            ImpAltText = impAltText;
            Description = description;
            LinkPath = linkPath;
            ButtonText = buttonText;
        }
    }

    public class Artists
    {
        public List<Card> cards = new();

        public Artists()
        {
            cards.Add(new Card("Kim Larsen", "...", "Kim Larsen Img", "This is him", "KimLarsen", "Click me"));
            cards.Add(new Card("Bjørn Uglebjerg", "...", "Bjørn Uglebjerg Img", "This is him", "Bjørn Uglebjerg", "Click me"));
            cards.Add(new Card("Søren Berlev", "...", "Søren Berlev Img", "This is him", "Søren Berlev", "Click me"));
            cards.Add(new Card("Franz Beckerlee", "...", "Franz Beckerlee Img", "This is him", "Bjørn Uglebjerg", "Click me"));
            cards.Add(new Card("Wili Jønsson", "...", "Wili Jønsson Img", "This is him", "Wili Jønsson", "Click me"));
        }
    }
}
