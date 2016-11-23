using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Nowak");

            Autor autor1 = new Autor("Jan", "Nowak", "Polak");

            Ksiazka ks1 = new Ksiazka(123, autor1, "Cos", 22, "abc", 2016);
            ks1.WypiszInfo();
            

            Czasopismo cz1 = new Czasopismo(1, "Tak", 1, "cba", 2015);

            Console.WriteLine();
            cz1.WypiszInfo();


            Console.ReadKey();
        }
    }
}
