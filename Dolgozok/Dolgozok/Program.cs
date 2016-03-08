using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Program
    {
        private static List<Alkalmazott> alkalmazottak = new List<Alkalmazott>();
        private static List<Alvallalkozo> alvallalkozok = new List<Alvallalkozo>();
        private static List<Kiszervezett> kiszervezettek = new List<Kiszervezett>();
        static void Main(string[] args)
        {
            FillLists();
            Print();
            Console.ReadLine();
        }

        private static void FillLists()
        {
            for (int i = 0; i < 5; i++)
            {
                alkalmazottak.Add(new Alkalmazott(MockData.Name(), MockData.Address(), MockData.RandomSzam(), MockData.RandomSzam(), MockData.Job(), MockData.Tulora()));
                alvallalkozok.Add(new Alvallalkozo(MockData.Name(), MockData.Address(), MockData.RandomSzam(), MockData.Date(), MockData.Job()));
                kiszervezettek.Add(new Kiszervezett(MockData.Name(), MockData.Address(), MockData.RandomSzam(), MockData.Job(), MockData.Company()));
            }
        }

        private static void Print()
        {
            foreach (Dolgozo alkalmazott in alkalmazottak)
            {
                Console.WriteLine(alkalmazott.ToString());
            }
            Console.WriteLine(Environment.NewLine);

            foreach (Alvallalkozo alvallalkozo in alvallalkozok)
            {
                Console.WriteLine(alvallalkozo.ToString());
            }
            Console.WriteLine(Environment.NewLine);

            foreach (Kiszervezett kiszervezett in kiszervezettek)
            {
                Console.WriteLine(kiszervezett.ToString());
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
