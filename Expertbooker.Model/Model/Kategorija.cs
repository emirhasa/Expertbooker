using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class Kategorija
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
