using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Søren_BerlevModel : PageModel
    {
        private readonly ILogger<Søren_BerlevModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Søren Berlev", "SørenBerlev/Søren1.jpg", "Søren \"Charlie\" Berlev (født 4. maj 1950 i Skt. Nikolai sogn, Nakskov) er en dansk musiker, der blev kendt som trommeslager i Gasolin'. Før Gasolin medlem af Dig og mig og solskin fra 1967-1969. Siden har han blandt andet være medlem af bandet Midnight Blues.");//(Kilde: https://da.wikipedia.org/wiki/Bjørn_Uglebjerg)

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Søren_BerlevModel(ILogger<Søren_BerlevModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "4. maj 1950", "Født i Nakskov", "Søren Berlev bliver født den 4. maj 1950 i Nakskov, Danmark. Allerede i en tidlig alder begynder han at spille trommer og udvikler sin egen karakteristiske stil.")); //(Kilde: IMDb)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1967-1969", "Medlem af 'Dig og mig og solskin'", "Berlev starter sin professionelle karriere i slutningen af 1960'erne som trommeslager i bandet Dig og mig og solskin. Bandet spiller en blanding af beat og popmusik, men Berlev søger efter en hårdere rocklyd.")); //(Kilde: Music.cliggo.com)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1971", "Bliver medlem af Gasolin'", "I 1971 bliver Søren Berlev en del af Gasolin', hvor han erstatter Bjørn Uglebjerg på trommer. Med sin energiske spillestil bliver han en central del af bandets lyd og medvirker på alle deres album.")); //(Kilde: Rabalderband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1978", "Gasolin' opløses", "Efter næsten et årti med succes vælger Gasolin' at opløse bandet. Berlev står over for nye udfordringer, men han fortsætter sin karriere i forskellige musikprojekter.")); //(Kilde: Rabalderband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1980", "Medlem af Wild Remain", "Berlev flytter til USA og bliver en del af bandet Wild Remain, som spiller en blanding af rock og reggae. De udgiver en single på CBS, men bandet opnår aldrig den store succes.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1989", "Spiller med The Lollipops", "I slutningen af 1980'erne bliver Berlev en del af en ny udgave af The Lollipops. Bandet forsøger at genoplive deres tidligere succes, men de går fra hinanden kort tid efter.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2008", "Udgiver soloalbummet Timeless Choice", "Udgiver soloalbummet Timeless Choice Berlev udgiver sit første soloalbum Timeless Choice, hvor han viser en mere personlig og eksperimenterende side af sin musik.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2018", "Udgiver You Can Make It med Berlev's Rock 'N' Roll Hotel", "Udgiver You Can Make It med Berlev's Rock 'N' Roll Hotel Berlev danner bandet Berlev's Rock 'N' Roll Hotel og udgiver albummet You Can Make It, der hylder klassisk rockmusik.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2019", "Udgiver Close To The Line", "Bandet følger op med endnu et album, Close To The Line, der får positive anmeldelser i rockmiljøet.")); //(Kilde: Wikipedia)



        }
    }
}
