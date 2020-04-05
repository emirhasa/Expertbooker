using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class KorisnikSlikaUpsertRequest
    {
        public int KorisnikId { get; set; }
        public byte[] ProfilnaSlika { get; set; }
    }
}
