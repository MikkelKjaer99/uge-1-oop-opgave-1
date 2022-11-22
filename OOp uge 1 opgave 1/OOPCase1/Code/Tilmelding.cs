using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUge1.Code
{
    public class Tilmelding
    {
        public Fag FagInfo { get; set; }

        public Elev ElevInfo { get; set; }


        public Tilmelding (Elev elevinfo, Fag faginfo)
        {
            ElevInfo = elevinfo;

            FagInfo = faginfo;
        }
    }
}
