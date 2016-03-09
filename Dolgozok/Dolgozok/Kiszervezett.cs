using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Kiszervezett : Dolgozo,IComparable<Kiszervezett>
    {
        public string Munkakor { get; set; }
        public string Munkaltato { get; set; }
        public static int Muszakpotlek { get; set; }

        public int Fizetes
        {
            get { return Alapfizetes + Muszakpotlek; }
        }

        public Kiszervezett(string nev, string cim, string adoszam, string munkakor, string munkaltato) : base(nev, cim, adoszam)
        {
            Munkakor = munkakor;
            Munkaltato = munkaltato;
            Muszakpotlek = 800;
        }

        public override string ToString()
        {
            return Munkaltato + ", " + Nev;
        }

        public int CompareTo(Kiszervezett other)
        {
            int result = Munkaltato.CompareTo(other.Munkaltato);
            return result;
        }
    }
}
