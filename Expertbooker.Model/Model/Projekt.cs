using System;
using System.Collections.Generic;

namespace EkspertBooker.Model
{
    public class Projekt
    {
        public int ProjektId { get; set; }
        public int PoslodavacId { get; set; }
        public Poslodavac Poslodavac { get; set; }
        public int EkspertId { get; set; }
        public Ekspert Ekspert { get; set; }
        public string Naziv { get; set; }
        public string KratkiOpis { get; set; }
        public string DetaljniOpis { get; set; }
        public DateTime? DatumObjave { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public int? TrajanjeDana { get; set; }
        public string StanjeId { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public int? Budzet { get; set; }
        public bool? Hitan { get; set; }
        public ProjektDetalji ProjektDetalji { get; set; }
        public int BrojPonuda { get; set; }

        public RecenzijaOEkspert RecenzijaOEkspert { get; set; }
        public RecenzijaOPoslodavac RecenzijaOPoslodavac { get; set; }

        //public ICollection<Ponuda> Ponude { get; set; }

        public override string ToString()
        {
            return Naziv + KratkiOpis;
        }

    }
}
