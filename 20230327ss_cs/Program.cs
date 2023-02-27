using System.Text;
using System.IO;

namespace _20230327ss_cs
{
    internal class Program
    {
        static List<Csoki> Csoki_List = new List<Csoki>();
        static void Main(string[] args)
        {
            Fladat1();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
        }

        private static void Feladat8()
        {
            
        }

        private static void Feladat7()
        {
            int db = 0;
            foreach (var cs in Csoki_List)
            {
                if (cs.CsokiNeve.ToLower().Contains("k"))
                {
                    db++;
                }
            }
            Console.WriteLine($"k betűsek: {db}");
        }

        private static void Feladat6()
        {
            Console.Write("Kérem adjon meg egy kódot: ");
            string Kereses = Console.ReadLine();
            int szamlalo = 0;
            while (szamlalo < Csoki_List.Count && Kereses != Csoki_List[szamlalo].CsokiKod)
            {
                szamlalo++;
            }
            if (szamlalo == Csoki_List.Count)
            {
                Console.WriteLine("nincs ilyen csoki");
            }
            else
            {
                Console.WriteLine($"csoki neve: {Csoki_List[szamlalo].CsokiNeve}, {Csoki_List[szamlalo].CsokiAr}");
            }
        }

        private static void Feladat5()
        {
            int ossz = 0;
            foreach (var cs in Csoki_List)
            {
                ossz += cs.CsokiAr;
            }
            Console.WriteLine($"Összesen: {ossz} Ft");
        }

        private static void Feladat4()
        {
            foreach (var cs in Csoki_List)
            {
                if (cs.CsokiAr <= 150)
                {
                    Console.WriteLine($"{cs.CsokiNeve} : {cs.CsokiAr}");
                }
            }
        }

        private static void Feladat3()
        {
            int MaxCsokiAr = int.MinValue;
            int MaxIndex = 0;
            string MaxNev = "Cica";
            foreach (var cs in Csoki_List)
            {
                if (MaxCsokiAr < cs.CsokiAr)
                {
                    MaxCsokiAr = cs.CsokiAr;
                    MaxNev = cs.CsokiNeve;
                }
            }
            Console.WriteLine($"A legdrágább csoki ára: {MaxCsokiAr}, {MaxNev}");
        }

        private static void Fladat1()
        {
            int db = 0;
            var sr = new StreamReader(@"csoki.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                Csoki_List.Add(new Csoki(sr.ReadLine()));
                db++;
            }
            sr.Close();
            if (db >0)
            {
                Console.WriteLine("Sikeres beolvasás");
                Console.WriteLine($"beolvasott sorok száma: {db}");
            }
            else
            {
                Console.WriteLine("Nem sikerült beolvasni");
            }
        }
    }
}