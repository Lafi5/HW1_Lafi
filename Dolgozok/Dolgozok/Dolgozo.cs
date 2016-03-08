using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Dolgozo
    {
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string Adoszam { get; set; }
        public static int Alapfizetes { get; private set; }

        public Dolgozo(string nev, string cim, string adoszam)
        {
            Nev = nev;
            Cim = cim;
            Adoszam = adoszam;
            Alapfizetes = 90000;
        }

        public override string ToString()
        {
            return Nev + ", " + Cim;
        }
    }
}
