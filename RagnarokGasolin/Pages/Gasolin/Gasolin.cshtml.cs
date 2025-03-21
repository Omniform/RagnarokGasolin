using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class GasolinModel : PageModel
    {
        
        public Artists artists = new();

        private readonly ILogger<GasolinModel> _logger;
        private BandMember bandMember = new BandMember("/Gasolin2.png", "/Gasolin1.jpg", "Gasolin' var et dansk rockband, der blev dannet i 1969 af Kim Larsen, Franz Beckerlee og Wili Jønsson. Senere blev trommeslager Søren Berlev en fast del af gruppen. Bandet var en af de mest markante og succesfulde musikgrupper i Danmark i 1970'erne og opnåede en enorm popularitet med deres energiske rockmusik, samfundsrelevante tekster og unikke blanding af blues, folk og hård rock.");

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public GasolinModel(ILogger<GasolinModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {


            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1969", "Dannelse af Gasolin'", "Gasolin' bliver dannet i 1969 i København af Kim Larsen (vokal), Franz Beckerlee (guitar) og Wili Jønsson (bas). Senere bliver Bjørn Uglebjerg tilføjet som trommeslager, men han bliver i 1971 erstattet af Søren Berlev.")); //(Kilde: Allmusic.com)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1970", "Første engelsksprogede singler", "Bandet forsøger sig først på det engelske marked og udgiver singler som \"Silky Sally\", \"Child of Institution\" og \"Johnny the Jackpot\", men de opnår ikke den store opmærksomhed.")); //(Kilde: Music.apple.com)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1971", "Første album på dansk", "Gasolin' beslutter at skifte til dansk og udgiver deres første dansksprogede album, Gasolin' 1. Det bliver starten på deres nationale gennembrud.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1972-1978", "Dominerende periode i dansk rock", "I denne periode udgiver Gasolin' en række succesfulde albums, herunder Gasolin' 2, Stakkels Jim, Efter endnu en dag og Gør det noget. Bandet bliver Danmarks største rocknavn.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1974", "Første engelsksprogede album", "Gasolin' forsøger at slå igennem internationalt og udgiver deres første engelsksprogede album, Gasolin' (1974), men de møder begrænset succes uden for Danmark.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "August 1978", "Afskedskoncert i Malmö", "Efter interne stridigheder og et mislykket internationalt gennembrud annoncerer Gasolin' deres opløsning. De spiller deres sidste koncert i Malmö i august 1978.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2006", "Dokumentarfilm om Gasolin'", "Dokumentarfilmen Gasolin' bliver udgivet og skaber fornyet interesse for bandet. Den viser interviews med de tidligere medlemmer og fortæller historien om bandets op- og nedture.")); //(Kilde: IMDb)

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
            cards.Add(new Card("Kim Larsen", "KimLarsen/Kim2.jpg", "Kim Larsen Img", "This is him", "KimLarsen", "Click me"));
            cards.Add(new Card("Bjørn Uglebjerg", "BjørnUglebjerg/Bjørn2.jpg", "Bjørn Uglebjerg Img", "This is him", "Bjørn Uglebjerg", "Click me"));
            cards.Add(new Card("Søren Berlev", "SørenBerlev/Søren1.jpg", "Søren Berlev Img", "This is him", "Søren Berlev", "Click me"));
            cards.Add(new Card("Franz Beckerlee", "FranzBeckerlee/Franz1.jpg", "Franz Beckerlee Img", "This is him", "Bjørn Uglebjerg", "Click me"));
            cards.Add(new Card("Wili Jønsson", "WiliJønsson/Wili3.jpg", "Wili Jønsson Img", "This is him", "Wili Jønsson", "Click me"));
        }
    }
}
