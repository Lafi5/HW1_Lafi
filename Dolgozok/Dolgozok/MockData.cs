using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok
{
    static class MockData
    {
        private static readonly object syncLock = new object();
        private static readonly Random rand = new Random();
        private static List<string> names = new List<string>();
        private static List<string> companies = new List<string>();
        private static List<string> addresses = new List<string>();
        private static string nameListFileName = "names.dat";
        private static string jobListFileName = "jobs.dat";
        private static string addressListFileName = "addresses.dat";
        private static string companyListFileName = "companies.dat";
        private static int minDate = 2000, maxDate = 2030;
         

        static MockData()
        {
            Read();
        }
        private static void Read()
        {
            NameFormFile();
            JobFormFile();
            AddressFromFile();
            CompanyFromFile();
        }

        private static void CompanyFromFile()
        {
            string text = System.IO.File.ReadAllText(companyListFileName);
            string[] lines = text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
                );
            foreach (string item in lines)
            {
                companies.Add(item);
            }
        }

        private static void AddressFromFile()
        {
            string text = System.IO.File.ReadAllText(addressListFileName);
            string[] lines = text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
                );
            foreach (string item in lines)
            {
                addresses.Add(item);
            }
        }

        public static string RandomSzam()
        {
            
            int szam;
            int max = 10000, min = 0;
            lock (syncLock)
            { 
                szam = rand.Next(min, max);
            }
            return szam.ToString();
        } 

        private static void JobFormFile()
        {
            string text = System.IO.File.ReadAllText(jobListFileName);
            string[] lines = text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
                );
            foreach (string item in lines)
            {
                companies.Add(item);
            }
        }

        private static void NameFormFile()
        {
            string text = System.IO.File.ReadAllText(nameListFileName);
            string[] lines = text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
                );
            foreach (string item in lines)
            {
                names.Add(item);
            }
        }

        public static string Name()
        {
            string name;
            lock (syncLock)
            {
                name = names.ElementAt(rand.Next(0, names.Count));
            }
            return name;
        }

        public static string Address()
        {
            string address;
            lock (syncLock)
            {
                address = addresses.ElementAt(rand.Next(0, addresses.Count));
            }
            return address;
        }

        public static string Job()
        {
            string job;
            lock (syncLock)
            {
                job = companies.ElementAt(rand.Next(0, companies.Count));
            }
            return job;
        }

        public static int Date()
        {
            int date;
            lock (syncLock)
            {
                date = rand.Next(minDate, maxDate);
            }
            return date;
        }

        public static int Tulora()
        {
            int ora;
            lock (syncLock)
            {
                ora = rand.Next(0, 13);
            }
            return ora;
        }

        public static string Company()
        {
            string company;
            lock (syncLock)
            {
                company = companies.ElementAt(rand.Next(0, companies.Count));
            }
            return company;
        }
    }
}
