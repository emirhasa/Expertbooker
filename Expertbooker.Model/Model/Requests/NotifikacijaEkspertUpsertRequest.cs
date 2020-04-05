using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class NotifikacijaEkspertUpsertRequest
    {
        public int NotifikacijaEkspertId { get; set; }
        public int EkspertId { get; set; }
        public int ProjektId { get; set; }
        public string Poruka { get; set; }
    }
}
