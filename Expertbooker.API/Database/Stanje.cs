using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EkspertBooker.WebAPI.Database
{
    public class Stanje
    {
        public Stanje()
        {
            Projekti = new HashSet<Projekt>();
        }

        public string StanjeId { get; set; }

        public ICollection<Projekt> Projekti { get; set; }
    }
}