using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class Willi_JønssonModel : PageModel
    {
        private readonly ILogger<Willi_JønssonModel> _logger;
        //Description is taken from https://da.wikipedia.org/wiki/Franz_Beckerlee
        private BandMember bandMember = new BandMember("Wili Jønsson", "WiliJønsson/Wili1.jpg", "Wili Jønsson (født 27. marts 1942 på Amager) er dansk bassist, keyboardspiller og korsanger, der især er kendt for tiden som bassist med Gasolin', hvor han af især Kim Larsen blev kaldt \"den skeløjede halvsvensker\".[1] Han har også spillet i mange andre konstellationer, blandt andet med Sort Sol (band), Sanne Salomonsen og med Peter Belli. Modtog i 2008 Ken Gudman Prisen for sin fem årtier lange musiske karriere. I 2009 deltog Wili Jønsson i TV2 programmet Allstars, som en del af kollegaen – tidligere forsanger fra Sort Sol – Steen Jørgensens kor.");//(Kilde: https://da.wikipedia.org/wiki/Wili_Jønsson

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public Willi_JønssonModel(ILogger<Willi_JønssonModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            BandMember.TimelineInfo.Add(new TimelineInfo(true, "27. marts 1942", "Født på Amager", "Wili Jønsson bliver født på Amager, Danmark. Han vokser op med musik omkring sig og udvikler tidligt en passion for at spille bas og klaver.")); //(Kilde: Discogs.com)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1960'erne", "Tidlige musikalske engagementer", "I løbet af 1960'erne spiller Jønsson i forskellige danske bands, hvor han opbygger sin erfaring som musiker. Han bliver kendt for sin alsidighed på både bas og keyboard.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1969", "Medstifter af Gasolin'", "Sammen med Kim Larsen, Franz Beckerlee og Bjørn Uglebjerg danner Wili Jønsson Gasolin', der senere bliver et af Danmarks mest legendariske rockbands.")); //(Kilde: Rubberband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1971-1978", "Karriere med Gasolin'", "I denne periode medvirker Jønsson på alle Gasolin’s albums og bidrager både som bassist, keyboardspiller og korsanger. Han er en vigtig del af bandets karakteristiske lyd.")); //(Kilde: Rubberband.dk)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1980'erne", "Samarbejde med andre kunstnere", "Efter Gasolin' opløses i 1978 fortsætter Jønsson med at spille musik og samarbejder med danske kunstnere som Sanne Salomonsen, Sort Sol og Peter Belli.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2008", "Modtager Ken Gudman Prisen", "Jønsson modtager den prestigefyldte Ken Gudman Prisen som anerkendelse for sit bidrag til dansk musik gennem årtier.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2009", "Deltager i TV2-programmet Allstars", "Wili Jønsson deltager i TV2-programmet Allstars, hvor han synger kor for Steen Jørgensen. Hans optræden viser, at han stadig er aktiv i musikbranchen.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "2021", "Underskriver forlagsaftale med Edition Wilhelm Hansen", "I 2021 indgår Jønsson en forlagsaftale med Edition Wilhelm Hansen, hvilket understreger hans fortsatte engagement i musikken.")); //(Kilde: Rubberband.dk)



        }
    }
}
