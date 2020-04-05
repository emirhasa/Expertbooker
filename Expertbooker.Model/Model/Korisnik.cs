using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }
        public DateTime? DatumRegistracije { get; set; }

        public ICollection<KorisnikUloga> KorisnikUloge { get; set; }

        public KorisnikSlika KorisnikSlika { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
