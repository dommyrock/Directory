using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Putanja izvršavanja aplikacije
            Console.WriteLine(Environment.CurrentDirectory);

            //Klasa Path
            string datoteka = Path.Combine(Environment.CurrentDirectory, "poddirektorij\\datoteka.txt");
            datoteka = string.Format("{0}\\poddirektorij\\datoteka.txt", Environment.CurrentDirectory);

            Console.WriteLine(datoteka);
            Console.WriteLine(Path.GetFileName(datoteka));
            Console.WriteLine(Path.GetDirectoryName(datoteka));

            //Provjera postojanja direktorija
            string dir = Path.GetDirectoryName(datoteka);
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {
                Console.WriteLine("Direktorij postoji. Možemo dalje.");
            }

            //Dohvat svih poddirektorija na zadanoj putanji
            string[] poddirektoriji = Directory.GetDirectories(Environment.CurrentDirectory);
            
            foreach(string putanja in poddirektoriji)
            {
                Console.WriteLine(putanja);
            }

            //Dohvat svih datoteka na zadanoj putanji

            string[] datoteke = Directory.GetFiles(Environment.CurrentDirectory);
            foreach(string fajl in datoteke)
            {

                Console.WriteLine(Path.GetFileName(fajl));
            }

            //File klasa
            if(!File.Exists(datoteka))
            {
                File.Create(datoteka);
            }


            Console.ReadKey();
        }
    }
}
