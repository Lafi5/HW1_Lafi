using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Alkalmazott : Dolgozo
    {
        public string Azonosito { get; set; }
        public string Beosztas { get; set; }
        public static int TuloraDij { get; set; }
        public int TuloraSzam { get; set; }

        public int Fizetes
        {
            get { return Alapfizetes + TuloraSzam * TuloraDij; }
        }

        public Alkalmazott(string nev, string cim, string adoszam, string azonosito, string beosztas, int tuloraSzam) : base(nev, cim, adoszam)
        {
            Azonosito = azonosito;
            Beosztas = beosztas;
            TuloraDij = 800;
            TuloraSzam = tuloraSzam;
        }

        public override string ToString()
        {
            return Beosztas + ", " + Nev;
        }
    }
}
