using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class KorisniciKategorijeSearchRequest
    {
        //dobijanje info o kategorijama na koje je korisnik pretplacen, odnosno korisnicima pretplacenim na kategoriju!
        public int? KorisnikId { get; set; } = null;
        public int? KategorijaId { get; set; } = null;
    }
}
