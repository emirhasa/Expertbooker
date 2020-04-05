using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class ProjektDetaljiPrilogUpsertRequest
    {
        public int ProjektDetaljiId { get; set; }
        public string PrilogNaziv { get; set; }
        public string PrilogEkstenzija { get; set; }
        public byte[] Prilog { get; set; }

    }
}
