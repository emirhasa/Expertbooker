
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.Model.Requests
{
    public class RecenzijaOPoslodavacUpsertRequest
    {
        public int ProjektId { get; set; }

        public int PoslodavacId { get; set; }

        public int EkspertId { get; set; }

        public int Ocjena { get; set; }
        public string Komentar { get; set; }

        public DateTime? Vrijeme { get; set; }

    }
}
