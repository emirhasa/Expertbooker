using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public KorisniciSearchRequest()
        {
            Administratori = Poslodavci = Eksperti = false;
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public bool Administratori { get; set; } 
        public bool Poslodavci { get; set; } 
        public bool Eksperti { get; set; }
    }
}
