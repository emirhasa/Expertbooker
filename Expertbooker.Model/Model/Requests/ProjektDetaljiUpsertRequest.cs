using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class ProjektDetaljiUpsertRequest
    {
        public int ProjektId { get; set; }
        public string AktivanDetaljanOpis { get; set; }
        public string Napomena { get; set; }
    }
}
