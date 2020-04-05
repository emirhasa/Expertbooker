
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkspertBooker.Model
{
    public class RecenzijaOPoslodavac
    {
        public int RecenzijaOPoslodavacId { get; set; }

        public int ProjektId { get; set; }

        public int PoslodavacId { get; set; }

        public int EkspertId { get; set; }
        public Ekspert Ekspert { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public DateTime Vrijeme { get; set; }

    }
}
