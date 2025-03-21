using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Bjørn_UglebjergModel : PageModel
    {
        private readonly ILogger<Bjørn_UglebjergModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Bjørn Uglebjerg", "BjørnUglebjerg/Bjørn1.jpg", "Bjørn Uglebjerg (21. marts 1948 i København – 21. juni 1994[1]) var en dansk trommeslager.\r\n\r\nSom 15-årig i 1963 dannede Bjørn Uglebjerg sammen med Peer Frost gruppen The Foottappers som senere blev til Les Rivals. Uglebjerg var første trommeslager i Gasolin'. I 1971 blev han udskiftet med Søren Berlev, og medvirkede senere som trommeslager og percussionist på Skousen & Ingemanns Herfra hvor vi står (1971) og Lone Kellermann og Rockbandets Før Natten Bli'r til dag (1978) og Tilfældigt Forbi (1979). Desuden var Uglebjerg fast medlem af Frede Norbrinks gruppe Frede Fup.");//(Kilde: https://da.wikipedia.org/wiki/Bjørn_Uglebjerg)

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Bjørn_UglebjergModel(ILogger<Bjørn_UglebjergModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "21. marts 1948", "Født i København", "Bjørn Uglebjerg bliver født i København. Allerede i en tidlig alder viser han interesse for musik, særligt trommer. Han starter sin musikalske rejse ved at spille i Tivoligarden og FDF’s orkester.")); //(Kilde: Danskefilm.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1958", "Begynder at spille trommer", "Som 10-årig begynder Uglebjerg at spille trommer i Tivoligarden. Hans tidlige interesse for rytmeinstrumenter fører ham hurtigt videre til rockmusikken, hvor han bliver en del af forskellige ungdomsbands.")); //(Kilde: Danskefilm.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1969", "Medlem af Gasolin'", "Bjørn Uglebjerg bliver en del af det nystartede rockband Gasolin', hvor han spiller trommer. Hans tid i bandet bliver dog kort, da han hurtigt bliver erstattet af Søren Berlev.")); //(Kilde: Rabalderband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1971", "Medlem af Skousen & Ingemann", "Efter sin tid i Gasolin' slutter Uglebjerg sig til det eksperimenterende rockband Skousen & Ingemann, hvor han fortsætter med at spille trommer og udvikle sin unikke spillestil.")); //(Kilde: Wikidata)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1979", "Medvirker i filmen Johnny Larsen", "Uglebjerg får sin debut som skuespiller i den danske film Johnny Larsen, hvor han optræder i en mindre rolle. Hans karisma og scenetilstedeværelse gør ham til en interessant figur i filmbranchen.")); //(Kilde: IMDb)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1983", "Rolle i Rocking Silver", "Han spiller karakteren René 'Buller' Olsen i filmen Rocking Silver, en film med stærke musikalske temaer, der passer godt til hans baggrund.")); //(Kilde: The Movie Database)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1986", "Medvirker i Manden i månen", "Uglebjerg optræder i filmen Manden i månen, hvor han igen bringer sin musikalske baggrund ind i filmverdenen.")); //(Kilde: The Movie Database)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1990 ", "Medlem af RubberBand", "I 1990 bliver Uglebjerg medlem af RubberBand, et band kendt for at spille covernumre af The Beatles. Han bidrager med sin rytmiske præcision og energi bag trommerne.")); //(Kilde: Rubberband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1991", "Forlader RubberBand", "Efter blot et år i RubberBand vælger Uglebjerg at forlade gruppen. Han bliver erstattet af Paul Callaby, mens han selv søger nye kunstneriske udfordringer.")); //(Kilde: Rubberband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "21. juni 1994", "Dør i en alder af 46 år", "Bjørn Uglebjerg går bort den 21. juni 1994 og bliver begravet på Assistens Kirkegård i København. Hans bidrag til dansk rockmusik lever videre i de bands, han har været en del af.")); //(Kilde: Wikidata)


        }
    }
}
