using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class KorisnikKategorijeUpsertRequest
    {
        //id korisnika kao drugi parametar requesta
        public ICollection<Kategorija> Kategorije { get; set; }
        
    }
}
