﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class PoslodavciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? BrojZavrsenihProjekata { get; set; }
    }
}
