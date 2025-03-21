using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Franz_BeckerleeModel : PageModel
    {
        private readonly ILogger<Franz_BeckerleeModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Franz Beckerlee", "FranzBeckerlee/Franz1.jpg", "Franz Beckerlee (født 15. august 1942) er en dansk musiker, der var guitarist i rockgruppen Gasolin. Han har desuden spillet jazz.\r\n\r\nBeckerlee spiller guitar og saxofon. Han begyndte at spille saxofon som 12-årig. Sammen med Hugh Steinmetz, Niels Harrit, Steffen Andersen og Bo Thrige Andersen dannede han The Contemporary Jazz Quintet, som spillede avantgardejazz. Kvintetten fik megen ros af kritikere og presse, men fik ingen større succes hos publikum. Franz fik tildelt årets jazzlegat i 1964 og 1968. Derefter kom Franz Beckerlee med i Gasolin', hvor han spiller guitar a la Jimi Hendrix. Efter Gasolin' var Franz Beckerlee med i Christianshavns Bluesband sammen med Søren Berlev og Lone Kellermann.");

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Franz_BeckerleeModel(ILogger<Franz_BeckerleeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "15. august 1942", "Født i København", "Franz Beckerlee bliver født i København. Efter realeksamen kommer han i lære som værktøjsmager. Allerede som 16-årig begynder han at fremstille skulpturer af jern, inspireret af kunstneren Robert Jacobsen.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1954", "Begynder at spille saxofon", "Som 12-årig begynder Beckerlee at spille altsaxofon, hvilket markerer starten på hans musikalske rejse.")); //(Kilde: Søren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1960'erne", "Danner The Contemporary Jazz Quartet", "Sammen med musikere som Hugh Steinmetz og Steffen Andersen danner Beckerlee The Contemporary Jazz Quintet, der spiller avantgardejazz. Kvintetten modtager ros fra kritikere, men opnår ikke stor kommerciel succes.")); //(Kilde: Søren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1964", "Modtager jazzlegater", "Beckerlee modtager jazzlegater i både 1964 og 1968 som anerkendelse for sit bidrag til jazzscenen.")); //(Kilde: Søren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1969", "Skifter til guitar og danner Gasolin'", "Inspireret af Jimi Hendrix skifter Beckerlee til guitar og danner sammen med Willi Jønsson og Kim Larsen rockbandet Gasolin'. Bandet bliver en central del af den danske rockscene frem til 1978.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1971-1978", "Gasolin’s storhedstid", "Gasolin' udgiver flere succesfulde albums og bliver kendt for deres energiske liveoptrædener. Beckerlees karakteristiske guitarspil bidrager væsentligt til bandets unikke lyd.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1984-1985", "Udgiver kriminalromaner", "Beckerlee udgiver to kriminalromaner: De sjældne og truede arter. En storbykrimi og De gamle aber er de sjoveste. En storbykrimi. Sidstnævnte bliver trukket tilbage på grund af påstande om plagiat.")); //(Kilde: Søren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1979", "Gasolin' opløses og solokarriere begynder", "Efter Gasolin's opløsning vender Beckerlee tilbage til billedkunsten. Han arbejder primært med abstrakte malerier i stærke farver og skulpturer, ofte med elementer som lys, lyd og bevægelse.")); //(Kilde: Kunstgalleriet Odense)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2008", "Antaget på Charlottenborgs Forårsudstilling", "Beckerlee får for tredje gang sine værker antaget på Charlottenborgs Forårsudstilling, hvilket markerer hans position i den danske kunstscene.")); //(Kilde: Kunstgalleriet Odense)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2023 ", "Udgiver erindringsbogen Stonefree", "Beckerlee udgiver sin biografi Stonefree – et liv med og uden Gasolin’, hvor han deler personlige historier fra sin tid i Gasolin' og livet derefter.")); //(Kilde: Søren Skaftes blog)


        }
    }
}
