using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class EkspertUpsertRequest
    {
        public int? EkspertStrucnaKategorijaId { get; set; }
        public bool? Notifikacije { get; set; }
    }
}
