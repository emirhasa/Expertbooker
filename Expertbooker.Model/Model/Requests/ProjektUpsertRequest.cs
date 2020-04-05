using System;

namespace EkspertBooker.Model
{
    public class ProjektUpsertRequest
    {
        public string Naziv { get; set; }
        public string KratkiOpis { get; set; }
        public string DetaljniOpis { get; set; }
        public DateTime? DatumObjave { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public int? TrajanjeDana { get; set; }
        public string StanjeId { get; set; }
        public int KategorijaId { get; set; }
        public int? Budzet { get; set; }
        public bool? Hitan { get; set; }
        public int PoslodavacId { get; set; }
    }
}
