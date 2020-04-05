using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class ProjektDetaljiPrilogSearchRequest 
    {
        //uzmi attachment ili samo info o attachmentu - da li postoji, naziv, vrijemeuploada, extenziju itd.
        public bool GetOnlyMetaData { get; set; }

        //uzmi samo jedan
        public int? ProjektDetaljiId { get; set; }
    }
}
