using System;

namespace EkspertBooker.Model
{
    public class ProjektiSearchRequest
    {
        public string Naziv { get; set; }
        public bool? Hitan { get; set; } 
        public string StanjeId { get; set; }
        public int? KategorijaId { get; set; }

        public int? PoslodavacId { get; set; }
        public int? EkspertId { get; set; }
  
    }
}
