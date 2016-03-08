using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(MockData.Name() + " ; " + MockData.Address() + " ; " + MockData.RandomSzam());
            }
            Console.ReadLine();
        }
    }
}
