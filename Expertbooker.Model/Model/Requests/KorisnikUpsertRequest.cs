using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class KorisnikUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string KorisnickoIme { get; set; }

        public byte[] Slika { get; set; }

        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public List<Uloga> Uloge { get; set; } = new List<Uloga>();
    }
}
