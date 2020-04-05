using System;

namespace EkspertBooker.WebAPI.Database
{
    public class ProjektDetaljiPrilog
    {

        public int ProjektDetaljiId { get; set; }
        public ProjektDetalji ProjektDetalji { get; set; }
        public string PrilogNaziv { get; set; }
        public string PrilogEkstenzija { get; set; }
        public DateTime? UploadVrijeme { get; set; }
        public byte[] Prilog { get; set; }

    }
}