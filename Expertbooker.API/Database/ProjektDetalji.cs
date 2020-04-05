using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkspertBooker.WebAPI.Database
{
    public class ProjektDetalji
    {
        public int ProjektId { get; set; }
        public Projekt Projekt { get; set; }
        public string AktivanDetaljanOpis { get; set; }
        public string Napomena { get; set; }
        public ProjektDetaljiPrilog ProjektDetaljiPrilog { get; set;}

    }
}