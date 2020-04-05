﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model
{
    public class NotifikacijaEkspert
    {
        public int NotifikacijaEkspertId { get; set; }
        public int EkspertId { get; set; }
        public Ekspert Ekspert { get; set; }
        public int ProjektId { get; set; }
        public Projekt Projekt { get; set; }
        public string Poruka { get; set; }
        public DateTime Vrijeme { get; set; }
    }
}
