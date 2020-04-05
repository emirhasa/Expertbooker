using System;
using System.Collections.Generic;
using System.Text;

namespace EkspertBooker.Model.Requests
{
    public class EkspertKategorijeUploadRequest
    {
        //id eksperta kao prvi parametar put requesta
        public ICollection<int> EkspertKategorije { get; set; }
    }
}
