using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class ProjektDetaljiPrilog
    {
        public int ProjektDetaljiId { get; set; }
        public string PrilogNaziv { get; set; }
        public string PrilogEkstenzija { get; set; }
        public DateTime? UploadVrijeme { get; set; }
        public byte[] Prilog { get; set; }
    }
}
