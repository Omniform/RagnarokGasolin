using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Franz_BeckerleeModel : PageModel
    {
        private readonly ILogger<Franz_BeckerleeModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Franz Beckerlee", "FranzBeckerlee/Franz1.jpg", "Franz Beckerlee (f�dt 15. august 1942) er en dansk musiker, der var guitarist i rockgruppen Gasolin. Han har desuden spillet jazz.\r\n\r\nBeckerlee spiller guitar og saxofon. Han begyndte at spille saxofon som 12-�rig. Sammen med Hugh Steinmetz, Niels Harrit, Steffen Andersen og Bo Thrige Andersen dannede han The Contemporary Jazz Quintet, som spillede avantgardejazz. Kvintetten fik megen ros af kritikere og presse, men fik ingen st�rre succes hos publikum. Franz fik tildelt �rets jazzlegat i 1964 og 1968. Derefter kom Franz Beckerlee med i Gasolin', hvor han spiller guitar a la Jimi Hendrix. Efter Gasolin' var Franz Beckerlee med i Christianshavns Bluesband sammen med S�ren Berlev og Lone Kellermann.");

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Franz_BeckerleeModel(ILogger<Franz_BeckerleeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "15. august 1942", "F�dt i K�benhavn", "Franz Beckerlee bliver f�dt i K�benhavn. Efter realeksamen kommer han i l�re som v�rkt�jsmager. Allerede som 16-�rig begynder han at fremstille skulpturer af jern, inspireret af kunstneren Robert Jacobsen.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1954", "Begynder at spille saxofon", "Som 12-�rig begynder Beckerlee at spille altsaxofon, hvilket markerer starten p� hans musikalske rejse.")); //(Kilde: S�ren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1960'erne", "Danner The Contemporary Jazz Quartet", "Sammen med musikere som Hugh Steinmetz og Steffen Andersen danner Beckerlee The Contemporary Jazz Quintet, der spiller avantgardejazz. Kvintetten modtager ros fra kritikere, men opn�r ikke stor kommerciel succes.")); //(Kilde: S�ren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1964", "Modtager jazzlegater", "Beckerlee modtager jazzlegater i b�de 1964 og 1968 som anerkendelse for sit bidrag til jazzscenen.")); //(Kilde: S�ren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1969", "Skifter til guitar og danner Gasolin'", "Inspireret af Jimi Hendrix skifter Beckerlee til guitar og danner sammen med Willi J�nsson og Kim Larsen rockbandet Gasolin'. Bandet bliver en central del af den danske rockscene frem til 1978.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1971-1978", "Gasolin�s storhedstid", "Gasolin' udgiver flere succesfulde albums og bliver kendt for deres energiske liveoptr�dener. Beckerlees karakteristiske guitarspil bidrager v�sentligt til bandets unikke lyd.")); //(Kilde: Kunstgalleriet)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1984-1985", "Udgiver kriminalromaner", "Beckerlee udgiver to kriminalromaner: De sj�ldne og truede arter. En storbykrimi og De gamle aber er de sjoveste. En storbykrimi. Sidstn�vnte bliver trukket tilbage p� grund af p�stande om plagiat.")); //(Kilde: S�ren Skaftes blog)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1979", "Gasolin' opl�ses og solokarriere begynder", "Efter Gasolin's opl�sning vender Beckerlee tilbage til billedkunsten. Han arbejder prim�rt med abstrakte malerier i st�rke farver og skulpturer, ofte med elementer som lys, lyd og bev�gelse.")); //(Kilde: Kunstgalleriet Odense)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2008", "Antaget p� Charlottenborgs For�rsudstilling", "Beckerlee f�r for tredje gang sine v�rker antaget p� Charlottenborgs For�rsudstilling, hvilket markerer hans position i den danske kunstscene.")); //(Kilde: Kunstgalleriet Odense)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2023 ", "Udgiver erindringsbogen Stonefree", "Beckerlee udgiver sin biografi Stonefree � et liv med og uden Gasolin�, hvor han deler personlige historier fra sin tid i Gasolin' og livet derefter.")); //(Kilde: S�ren Skaftes blog)


        }
    }
}
