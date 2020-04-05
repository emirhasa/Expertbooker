using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class EkspertKategorijaPretplata
    {
        public int EkspertKategorijaPretplataId { get; set; }
        public int EkspertId { get; set; }
        public Ekspert Ekspert { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
