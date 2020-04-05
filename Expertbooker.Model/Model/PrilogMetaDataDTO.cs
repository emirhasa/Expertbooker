using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class PrilogMetaDataDTO
    {
        //dto koji sadrzi info o prilozima - bez povlacenja same datoteke radi cuvanja bandwidtha
        public int ProjektDetaljiId { get; set; }
        public string PrilogNaziv { get; set; }
        public string PrilogEkstenzija { get; set; }
        public DateTime? UploadVrijeme { get; set; }
    }
}
