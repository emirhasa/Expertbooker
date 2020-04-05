using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class EkspertKategorijeSearchRequest
    {
        public int? EkspertId { get; set; }
        public int? KategorijaId { get; set; }
    }
}
