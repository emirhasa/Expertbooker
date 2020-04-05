using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class PonudaUpsertRequest
    {
        public int EkspertId { get; set; }

        public int ProjektId { get; set; }

        public string Naslov { get; set; }

        public string OpisPonude { get; set; }

        public DateTime? VrijemePonude { get; set; }

        public DateTime? VrijemePrihvatanja { get; set; }
        public DateTime? VrijemeOdbijanja { get; set; }
        public string PoslodavacKomentar { get; set; }
        public int? Cijena { get; set; }
        public int Status { get; set; }
    }
}
