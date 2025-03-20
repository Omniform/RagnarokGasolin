using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RagnarokGasolin.Pages.Gasolin
{
    public class GasolinModel : PageModel
    {
        private readonly ILogger<GasolinModel> _logger;

        public MtkArtist m_artists = new();

        public GasolinModel(ILogger<GasolinModel> logger)
        {
            _logger = logger;

            m_artists.Add("Kim Larsen", "/Gasolin/KimLarsen");
            m_artists.Add("Franz Beckerlee", "/Gasolin/Franz Beckerlee");
            m_artists.Add("Wili Jønsson", "/Gasolin/Wili Jønsson");
            m_artists.Add("Søren Berlev", "/Gasolin/Søren Berlev");
            m_artists.Add("Bjørn Uglebjerg", "/Gasolin/Bjørn Uglebjerg");
        }

        public List<string> GetArtists()
        {
            return m_artists.GetArtists();
        }

        public List<string> GetLinks()
        {
            return m_artists.GetLinks();
        }

        public string GetArtistAt(int position)
        {
            return m_artists.GetArtistAt(position);
        }

        public string GetLinkAt(int position)
        {
            return m_artists.GetLinkAt(position);
        }

        public void OnGet()
        {
        }
    }

    public class MtkArtist
    {
        private List<string> m_artistNames = new();
        private List<string> m_links = new();

        public MtkArtist(){}

        public string GetArtistAt(int artistPosition)
        {
            return m_artistNames[artistPosition];
        }

        public string GetLinkAt(int linkPosition)
        {
            return m_links[linkPosition];
        }

        public List<string> GetArtists()
        {
            return m_artistNames;
        }

        public List<string> GetLinks()
        {
            return m_links;
        }

        public void Add(string artist, string link)
        {
            m_artistNames.Add(artist);
            m_links.Add(link);
        }
    }


    // public class MtkArtist<T, T2>
    // {
    //     private List<T> m_artistNames = new();
    //     private List<T2> m_links = new();

    //     public MtkArtist(){}

    //     public T GetArtist(int artistPosition)
    //     {
    //         return m_artistNames[artistPosition];
    //     }

    //     public T2 GetLink(int linkPosition)
    //     {
    //         return m_links[linkPosition];
    //     }

    //     public List<T> GetArtists()
    //     {
    //         return m_artistNames;
    //     }

    //     public List<T2> GetLinks()
    //     {
    //         return m_links;
    //     }

    //     public void Add(T artist, T2 link)
    //     {
    //         m_artistNames.Add(artist);
    //         m_links.Add(link);
    //     }
    // }
}
