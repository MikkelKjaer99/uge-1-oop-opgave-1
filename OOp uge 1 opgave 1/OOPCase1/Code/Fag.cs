using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUge1.Code
{
    public class Fag
    {
        public string FagNavn { get; set; }

        public Lære LæreInfo { get; set; }

        public Fag(string fagnavn, Lære læreinfo)
        {
            FagNavn = fagnavn;

            LæreInfo = læreinfo;
        }
    }
}
