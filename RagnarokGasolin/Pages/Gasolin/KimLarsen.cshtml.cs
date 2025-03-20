using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnarokGasolin.Models;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class KimLarsenModel : PageModel
    {
        private readonly ILogger<KimLarsenModel> _logger;
        private BandMember bandMember = new BandMember("Kim Larsen", "KimLarsen/Kim4.jpg", "Kim Mellius Flyvholm Larsen (født 23. oktober 1945 i København, død 30. september 2018 i Odense) var en dansk sanger, sangskriver, folkeskolelærer, forfatter og guitarist. Han begyndte sin musikalske karriere i 1968 efter en kort periode som folkeskolelærer og blev fra 1969 kendt som medlem af rockgruppen Gasolin. I sin tid med Gasolin (varede indtil 1978) udgav Larsen dog også såvel soloplader og plader med sit fritidsband, der blev kendt under flere navne, og efter Gasolins opløsning fortsatte Larsen som solist og bandleder.");

        [BindProperty]
        public BandMember BandMember { get { return bandMember; } set { bandMember = value; } }

        public KimLarsenModel(ILogger<KimLarsenModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "23. oktober 1945", "Født i København", "Kim Melius Flyvholm Larsen blev født i København. Han voksede op på Christianshavn, hvor han tidligt blev fascineret af musik. Hans barndom var præget af arbejderklassemiljøet, hvilket senere kom til udtryk i hans musikalske tekster og temaer.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1958", "Opdager rock and roll", "Som 13-årig blev Kim introduceret til rock and roll, især Little Richard, hvilket vækkede hans interesse for musik. Denne musikalske opdagelse inspirerede ham til at begynde at spille guitar og drømme om en karriere inden for musikken.")); //(Kilde: Politiken)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1960'erne", "Studier og første musikalske forsøg", "Kim Larsen studerede på Askov Højskole og senere på Frederiksberg Seminarium, hvor han uddannede sig som skolelærer. Selvom han kortvarigt arbejdede som lærer, trak musikken ham i en anden retning, og han begyndte at optræde på lokale spillesteder.")); //(Kilde: Ekstra Bladet)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1969", "Danner Gasolin'", "Sammen med Franz Beckerlee og Wili Jønsson dannede Kim Larsen bandet Gasolin'. Med tilføjelsen af trommeslageren Søren Berlev blev de en af Danmarks mest succesrige rockgrupper. Deres musik kombinerede rock med danske tekster, hvilket gav dem en unik lyd.")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1971", "Udgiver debutalbummet \"Gasolin’\"", "Gasolin' udgav deres debutalbum \"Gasolin'\", som markerede starten på deres indflydelse på den danske rockscene. Albummet indeholdt sange, der hurtigt blev populære og cementerede bandets position i dansk musik.​")); //(Kilde: GAFFA)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1973-1977", "Succes med Gasolin’", "I denne periode udgav Gasolin' flere succesfulde albums, herunder \"Gas 5\" og \"Efter endnu en dag\". Deres musik blev soundtrack for en generation og indeholdt hits som \"Kvinde min\" og \"This is my life\".")); //(Kilde: Berlingske)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1978", "Gasolin’ opløses og Larsen går solo", "Efter Gasolin's opløsning fortsatte Kim Larsen som soloartist. Han flyttede kortvarigt til USA i håb om international succes, men vendte hurtigt tilbage til Danmark, hvor han fortsatte sin musikalske karriere. ​\r\nWikipedia, den frie encyklopædi")); //(Kilde: Wikipedia)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1983", "Udgiver Midt om natten", "Kim Larsen udgav soloalbummet \"Midt om natten\", som blev en af de bedst sælgende danske plader nogensinde. Albummet indeholdt sange fra filmen af samme navn, hvor Larsen også spillede hovedrollen. Filmen og musikken blev ikoniske i dansk kultur.")); //(Kilde: DR)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "1986", "Kim Larsen & Bellami", "Han dannede bandet Kim Larsen & Bellami og udgav albummet \"Forklædt som voksen\". Dette album indeholdt hits som \"Jutlandia\" og \"Om lidt\", som blev klassikere i dansk musik.")); //(Kilde: Politiken)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "1995", "Kim Larsen & Kjukken", "Kim Larsen dannede bandet Kim Larsen & Kjukken og udgav albummet \"Kim Larsen & Kjukken\". Dette markerede en ny æra i hans karriere, hvor han fortsatte med at udgive musik og turnere i Danmark.")); //(Kilde: Ekstra Bladet)

            BandMember.TimelineInfo.Add(new TimelineInfo(true, "2018", "Udgiver biografien Mine unge år", "I samarbejde med Jens Andersen udgav han selvbiografien \"Mine unge år\", hvor han reflekterede over sit liv og karriere. Bogen gav et intimt indblik i hans opvækst, musikalske rejse og personlige oplevelser.​​")); //(Kilde: Berlingske)

            BandMember.TimelineInfo.Add(new TimelineInfo(false, "30. september 2018", "Kim Larsen dør", "Kim Larsen døde i Odense, 72 år gammel, efter længere tids sygdom. Hans død blev mødt med stor sorg i Danmark, hvor han blev hyldet som en af landets største musikere. Hans musik lever videre og fortsætter med at inspirere nye generationer.")); //(Kilde: DR)

        }
    }
}
