using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class PonudeSearchRequest
    {
        public int? EkspertId { get; set; }
        public int? ProjektId { get; set; }
        public int? Status { get; set; }
    }
}
