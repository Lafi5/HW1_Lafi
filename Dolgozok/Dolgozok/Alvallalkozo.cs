using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Alvallalkozo : IComparable<Alvallalkozo>
    {
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string Adoszam { get; set; }
        public int SzerzodesVege { get; set; }
        public string Feladat { get; set; }
        public static int SikerDij { get; set; }

        public int Fizetes
        {
            get { return Dolgozo.Alapfizetes + SikerDij; }
        }

        public Alvallalkozo(string nev, string cim, string adoszam, int szerzodesVege, string feladat)
        {
            Nev = nev;
            Cim = cim;
            Adoszam = adoszam;
            SzerzodesVege = szerzodesVege;
            Feladat = feladat;
            SikerDij = 800;
        }

        public override string ToString()
        {
            return SzerzodesVege + ", " + Nev;
        }

        public int CompareTo(Alvallalkozo other)
        {
            int ret = -1;
            if (SzerzodesVege < other.SzerzodesVege)
                ret = -1;
            else if (SzerzodesVege > other.SzerzodesVege)
                ret = 1;
            else if (SzerzodesVege == other.SzerzodesVege)
                ret = 0;
            return ret;
        }
    }
}
