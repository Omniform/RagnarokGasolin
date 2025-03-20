using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Franz_BeckerleeModel : PageModel
    {
        private readonly ILogger<KimLarsenModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Franz Beckerlee", "Franz Beckerlee (født 15. august 1942) er en dansk musiker, der var guitarist i rockgruppen Gasolin. Han har desuden spillet jazz.\r\n\r\nBeckerlee spiller guitar og saxofon. Han begyndte at spille saxofon som 12-årig. Sammen med Hugh Steinmetz, Niels Harrit, Steffen Andersen og Bo Thrige Andersen dannede han The Contemporary Jazz Quintet, som spillede avantgardejazz. Kvintetten fik megen ros af kritikere og presse, men fik ingen større succes hos publikum. Franz fik tildelt årets jazzlegat i 1964 og 1968. Derefter kom Franz Beckerlee med i Gasolin', hvor han spiller guitar a la Jimi Hendrix. Efter Gasolin' var Franz Beckerlee med i Christianshavns Bluesband sammen med Søren Berlev og Lone Kellermann.");

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Franz_BeckerleeModel(ILogger<KimLarsenModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "15. august 1942", " Født på Amager", "Franz Beckerlee bliver født i København på Amager og vokser op i et miljø præget af kunst og musik."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1954", "Begynder at spille saxofon", "Som 12-årig får han interesse for musik og begynder at spille altsaxofon, hvilket bliver hans første skridt ind i musikkens verden."));

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1960'erne", "Danner The Contemporary Jazz Quartet", "Franz Beckerlee starter The Contemporary Jazz Quartet med Hugh Steinmetz og Steffen Andersen. Gruppen eksperimenterer med avantgardejazz og egne kompositioner."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1964", "Anerkendelse fra jazzmiljøet", "Kvartetten modtager positiv kritik for deres nyskabende jazzmusik og spiller koncerter i Danmark og udlandet."));

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1968", "Eksperimenter med elektrisk saxofon", "Han begynder at eksperimentere med elektrisk forstærkning af saxofonen, hvilket peger frem mod hans senere arbejde med elektrisk guitar."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1969", "Skifter til guitar og danner Gasolin'", "Inspireret af Jimi Hendrix skifter Beckerlee til guitar og er med til at danne Gasolin', der snart bliver Danmarks største rockband."));

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1971-1978", "Gasolin’s storhedstid", "Bandet udgiver otte studiealbums, hvor Franz Beckerlee bidrager med sin karakteristiske guitarstil og energi. Gruppen opnår massiv succes i Danmark."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1979", "Gasolin' opløses og solokarriere begynder", "Efter Gasolin’s opløsning udgiver Beckerlee soloalbummet No Kiddin’ og spiller med bands som Wild Honey og Christianshavns Bluesband."));

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1980'erne", "Skifter fokus til billedkunst", "Han uddanner sig til billedhugger og begynder at arbejde som kunstner, hvor han eksperimenterer med forskellige materialer og udtryksformer."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1998", " Anerkendelse som billedkunstner", "Beckerlee deltager i flere kunstudstillinger og får ros for sin evne til at kombinere musikalske og visuelle udtryk."));

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2002", "Separatudstillinger som kunstner", "Han afholder flere personlige udstillinger med sin kunst, hvor han fortsætter med at udfordre normerne inden for visuel kunst."));

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2023", " Udgiver erindringsbogen Stonefree", "Beckerlee udgiver sin biografi Stonefree – et liv med og uden Gasolin’, hvor han deler personlige historier fra sin tid i Gasolin' og livet derefter."));


        }
    }
}
